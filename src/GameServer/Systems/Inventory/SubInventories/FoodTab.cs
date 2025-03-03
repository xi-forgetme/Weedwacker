﻿using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using Weedwacker.GameServer.Database;
using Weedwacker.GameServer.Enums;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Systems.Inventory
{
    internal class FoodTab : MaterialsTab
    {
        [BsonIgnore] public new const int InventoryLimit = 2000;
        private static string mongoPathToItems = $"{nameof(InventoryManager.SubInventories)}.{ItemType.ITEM_MATERIAL}.{nameof(FoodTab)}.{nameof(Items)}";
        public FoodTab(Player.Player owner, InventoryManager inventory) : base(owner, inventory) { }

        public override async Task<GameItem?> AddItemAsync(int itemId, int count = 1, int level = 1, int refinement = 0)
        {
            if (Items.TryGetValue(itemId, out GameItem? material))
            {
                if ((material as MaterialItem).ItemData.stackLimit >= material.Count + count)
                {
                    material.Count += count;

                    // Update Database
                    var filter = Builders<InventoryManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
                    var update = Builders<InventoryManager>.Update.Set($"{mongoPathToItems}.{itemId}.{nameof(GameItem.Count)}", material.Count);
                    await DatabaseManager.UpdateInventoryAsync(filter, update);

                    //TODO update codex
                    return material;
                }
                else return null;
            }
            else
            {
                var newMaterial = new MaterialItem(Owner.GetNextGameGuid(), itemId, count);
                Items.Add(itemId, newMaterial);

                // Update Database
                var filter = Builders<InventoryManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
                var update = Builders<InventoryManager>.Update.Set($"{mongoPathToItems}.{itemId}", newMaterial);
                await DatabaseManager.UpdateInventoryAsync(filter, update);

                //TODO update codex
                return newMaterial;
            }
        }

        internal override async Task<bool> RemoveItemAsync(GameItem item, int count = 1)
        {
            if (Items.TryGetValue(item.ItemId, out GameItem? material))
            {
                if (material.Count - count >= 1)
                {
                    material.Count -= count;

                    // Update Database
                    var filter = Builders<InventoryManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
                    var update = Builders<InventoryManager>.Update.Set($"{mongoPathToItems}.{material.ItemId}.{nameof(GameItem.Count)}", material.Count);
                    await DatabaseManager.UpdateInventoryAsync(filter, update);

                    return true;
                }
                else if (material.Count - count == 0)
                {
                    // Update Database
                    var filter = Builders<InventoryManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
                    var update = Builders<InventoryManager>.Update.Unset($"{mongoPathToItems}.{material.ItemId}");
                    await DatabaseManager.UpdateInventoryAsync(filter, update);

                    Items.Remove(material.ItemId);
                    return true;
                }
                else
                {
                    Logger.WriteErrorLine("ItemId: " + item.ItemId + ". Tried to remove " + count + " have " + item.Count);
                    return false;
                }
            }
            else
            {
                Logger.WriteErrorLine("Tried to remove inexistent item");
                return false;
            }
        }
    }
}
