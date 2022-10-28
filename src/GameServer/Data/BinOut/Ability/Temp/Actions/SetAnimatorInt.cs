﻿using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class SetAnimatorInt : BaseAction
    {
        [JsonProperty] public readonly BasePredicate[] predicates;
        [JsonProperty] public readonly string intID;
        [JsonProperty] public readonly float value;
    }
}
