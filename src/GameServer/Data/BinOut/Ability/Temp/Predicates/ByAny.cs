﻿using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates
{
    internal class ByAny : BasePredicate
    {
        [JsonProperty] public readonly BasePredicate[] predicates;
    }
}
