﻿using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates
{
    internal class ByEntityAppearVisionType : BasePredicate
    {
        [JsonProperty] public readonly VisionType visionType;
    }
}
