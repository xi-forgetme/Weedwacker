// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: VintageMarketInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from VintageMarketInfo.proto</summary>
  public static partial class VintageMarketInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for VintageMarketInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static VintageMarketInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdWaW50YWdlTWFya2V0SW5mby5wcm90bxobVmludGFnZU1hcmtldERlYWxJ",
            "bmZvLnByb3RvGhxWaW50YWdlTWFya2V0U3RvcmVJbmZvLnByb3RvIpsGChFW",
            "aW50YWdlTWFya2V0SW5mbxIcChNpc19oZWxwX21vZHVsZV9vcGVuGM0LIAEo",
            "CBIiChppc19zdG9yZV9jb250ZW50X2ludGVycnVwdBgPIAEoCBIpCglkZWFs",
            "X2luZm8YCyABKAsyFi5WaW50YWdlTWFya2V0RGVhbEluZm8SEwoLc3RvcmVf",
            "cm91bmQYByABKA0SIAoXc3RvcmVfcm91bmRfaW5jb21lX2xpc3QYzwEgAygN",
            "Eh8KF2lzX3N0b3JlX2NvbnRlbnRfZmluaXNoGAUgASgIEhoKEmN1cl9lbnZf",
            "ZXZlbnRfbGlzdBgIIAMoDRIeChZpc19tYXJrZXRfY29udGVudF9vcGVuGAog",
            "ASgIEiAKF25leHRfY2FuX3VzZV9oZWxwX3JvdW5kGIgOIAEoDRIgChhpc19t",
            "YXJrZXRfY29udGVudF9maW5pc2gYAiABKAgSHAoUdmlld2VkX3N0cmF0ZWd5",
            "X2xpc3QYDiADKA0SFwoPcHJldl9jb2luX2NfbnVtGAMgASgNEkAKEGJhcmdh",
            "aW5faW5mb19tYXAYBiADKAsyJi5WaW50YWdlTWFya2V0SW5mby5CYXJnYWlu",
            "SW5mb01hcEVudHJ5Eh4KFWRpdmlkZW5kX3Jld2FyZF9jb3VudBiGDiABKA0S",
            "GgoSY3VyX25wY19ldmVudF9saXN0GAQgAygNEhYKDWlzX2hlbHBfaW5fY2QY",
            "7gIgASgIEhcKD3ByZXZfY29pbl9iX251bRgBIAEoDRIwCg9vcGVuX3N0b3Jl",
            "X2xpc3QYCSADKAsyFy5WaW50YWdlTWFya2V0U3RvcmVJbmZvEhYKDWhlbHBf",
            "c2tpbGxfaWQY+AUgASgNEhoKEmlzX3JvdW5kX3RpcHNfdmlldxgMIAEoCBIg",
            "Chdpc19zdHJhdGVneV9tb2R1bGVfb3BlbhjsBiABKAgSHAoUdW5sb2NrX3N0",
            "cmF0ZWd5X2xpc3QYDSADKA0aNQoTQmFyZ2FpbkluZm9NYXBFbnRyeRILCgNr",
            "ZXkYASABKA0SDQoFdmFsdWUYAiABKAg6AjgBQiKqAh9XZWVkd2Fja2VyLlNo",
            "YXJlZC5OZXR3b3JrLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.VintageMarketDealInfoReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.VintageMarketStoreInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.VintageMarketInfo), global::Weedwacker.Shared.Network.Proto.VintageMarketInfo.Parser, new[]{ "IsHelpModuleOpen", "IsStoreContentInterrupt", "DealInfo", "StoreRound", "StoreRoundIncomeList", "IsStoreContentFinish", "CurEnvEventList", "IsMarketContentOpen", "NextCanUseHelpRound", "IsMarketContentFinish", "ViewedStrategyList", "PrevCoinCNum", "BargainInfoMap", "DividendRewardCount", "CurNpcEventList", "IsHelpInCd", "PrevCoinBNum", "OpenStoreList", "HelpSkillId", "IsRoundTipsView", "IsStrategyModuleOpen", "UnlockStrategyList" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class VintageMarketInfo : pb::IMessage<VintageMarketInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<VintageMarketInfo> _parser = new pb::MessageParser<VintageMarketInfo>(() => new VintageMarketInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<VintageMarketInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.VintageMarketInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VintageMarketInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VintageMarketInfo(VintageMarketInfo other) : this() {
      isHelpModuleOpen_ = other.isHelpModuleOpen_;
      isStoreContentInterrupt_ = other.isStoreContentInterrupt_;
      dealInfo_ = other.dealInfo_ != null ? other.dealInfo_.Clone() : null;
      storeRound_ = other.storeRound_;
      storeRoundIncomeList_ = other.storeRoundIncomeList_.Clone();
      isStoreContentFinish_ = other.isStoreContentFinish_;
      curEnvEventList_ = other.curEnvEventList_.Clone();
      isMarketContentOpen_ = other.isMarketContentOpen_;
      nextCanUseHelpRound_ = other.nextCanUseHelpRound_;
      isMarketContentFinish_ = other.isMarketContentFinish_;
      viewedStrategyList_ = other.viewedStrategyList_.Clone();
      prevCoinCNum_ = other.prevCoinCNum_;
      bargainInfoMap_ = other.bargainInfoMap_.Clone();
      dividendRewardCount_ = other.dividendRewardCount_;
      curNpcEventList_ = other.curNpcEventList_.Clone();
      isHelpInCd_ = other.isHelpInCd_;
      prevCoinBNum_ = other.prevCoinBNum_;
      openStoreList_ = other.openStoreList_.Clone();
      helpSkillId_ = other.helpSkillId_;
      isRoundTipsView_ = other.isRoundTipsView_;
      isStrategyModuleOpen_ = other.isStrategyModuleOpen_;
      unlockStrategyList_ = other.unlockStrategyList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VintageMarketInfo Clone() {
      return new VintageMarketInfo(this);
    }

    /// <summary>Field number for the "is_help_module_open" field.</summary>
    public const int IsHelpModuleOpenFieldNumber = 1485;
    private bool isHelpModuleOpen_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsHelpModuleOpen {
      get { return isHelpModuleOpen_; }
      set {
        isHelpModuleOpen_ = value;
      }
    }

    /// <summary>Field number for the "is_store_content_interrupt" field.</summary>
    public const int IsStoreContentInterruptFieldNumber = 15;
    private bool isStoreContentInterrupt_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsStoreContentInterrupt {
      get { return isStoreContentInterrupt_; }
      set {
        isStoreContentInterrupt_ = value;
      }
    }

    /// <summary>Field number for the "deal_info" field.</summary>
    public const int DealInfoFieldNumber = 11;
    private global::Weedwacker.Shared.Network.Proto.VintageMarketDealInfo dealInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.VintageMarketDealInfo DealInfo {
      get { return dealInfo_; }
      set {
        dealInfo_ = value;
      }
    }

    /// <summary>Field number for the "store_round" field.</summary>
    public const int StoreRoundFieldNumber = 7;
    private uint storeRound_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StoreRound {
      get { return storeRound_; }
      set {
        storeRound_ = value;
      }
    }

    /// <summary>Field number for the "store_round_income_list" field.</summary>
    public const int StoreRoundIncomeListFieldNumber = 207;
    private static readonly pb::FieldCodec<uint> _repeated_storeRoundIncomeList_codec
        = pb::FieldCodec.ForUInt32(1658);
    private readonly pbc::RepeatedField<uint> storeRoundIncomeList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> StoreRoundIncomeList {
      get { return storeRoundIncomeList_; }
    }

    /// <summary>Field number for the "is_store_content_finish" field.</summary>
    public const int IsStoreContentFinishFieldNumber = 5;
    private bool isStoreContentFinish_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsStoreContentFinish {
      get { return isStoreContentFinish_; }
      set {
        isStoreContentFinish_ = value;
      }
    }

    /// <summary>Field number for the "cur_env_event_list" field.</summary>
    public const int CurEnvEventListFieldNumber = 8;
    private static readonly pb::FieldCodec<uint> _repeated_curEnvEventList_codec
        = pb::FieldCodec.ForUInt32(66);
    private readonly pbc::RepeatedField<uint> curEnvEventList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> CurEnvEventList {
      get { return curEnvEventList_; }
    }

    /// <summary>Field number for the "is_market_content_open" field.</summary>
    public const int IsMarketContentOpenFieldNumber = 10;
    private bool isMarketContentOpen_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsMarketContentOpen {
      get { return isMarketContentOpen_; }
      set {
        isMarketContentOpen_ = value;
      }
    }

    /// <summary>Field number for the "next_can_use_help_round" field.</summary>
    public const int NextCanUseHelpRoundFieldNumber = 1800;
    private uint nextCanUseHelpRound_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NextCanUseHelpRound {
      get { return nextCanUseHelpRound_; }
      set {
        nextCanUseHelpRound_ = value;
      }
    }

    /// <summary>Field number for the "is_market_content_finish" field.</summary>
    public const int IsMarketContentFinishFieldNumber = 2;
    private bool isMarketContentFinish_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsMarketContentFinish {
      get { return isMarketContentFinish_; }
      set {
        isMarketContentFinish_ = value;
      }
    }

    /// <summary>Field number for the "viewed_strategy_list" field.</summary>
    public const int ViewedStrategyListFieldNumber = 14;
    private static readonly pb::FieldCodec<uint> _repeated_viewedStrategyList_codec
        = pb::FieldCodec.ForUInt32(114);
    private readonly pbc::RepeatedField<uint> viewedStrategyList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> ViewedStrategyList {
      get { return viewedStrategyList_; }
    }

    /// <summary>Field number for the "prev_coin_c_num" field.</summary>
    public const int PrevCoinCNumFieldNumber = 3;
    private uint prevCoinCNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PrevCoinCNum {
      get { return prevCoinCNum_; }
      set {
        prevCoinCNum_ = value;
      }
    }

    /// <summary>Field number for the "bargain_info_map" field.</summary>
    public const int BargainInfoMapFieldNumber = 6;
    private static readonly pbc::MapField<uint, bool>.Codec _map_bargainInfoMap_codec
        = new pbc::MapField<uint, bool>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForBool(16, false), 50);
    private readonly pbc::MapField<uint, bool> bargainInfoMap_ = new pbc::MapField<uint, bool>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, bool> BargainInfoMap {
      get { return bargainInfoMap_; }
    }

    /// <summary>Field number for the "dividend_reward_count" field.</summary>
    public const int DividendRewardCountFieldNumber = 1798;
    private uint dividendRewardCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DividendRewardCount {
      get { return dividendRewardCount_; }
      set {
        dividendRewardCount_ = value;
      }
    }

    /// <summary>Field number for the "cur_npc_event_list" field.</summary>
    public const int CurNpcEventListFieldNumber = 4;
    private static readonly pb::FieldCodec<uint> _repeated_curNpcEventList_codec
        = pb::FieldCodec.ForUInt32(34);
    private readonly pbc::RepeatedField<uint> curNpcEventList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> CurNpcEventList {
      get { return curNpcEventList_; }
    }

    /// <summary>Field number for the "is_help_in_cd" field.</summary>
    public const int IsHelpInCdFieldNumber = 366;
    private bool isHelpInCd_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsHelpInCd {
      get { return isHelpInCd_; }
      set {
        isHelpInCd_ = value;
      }
    }

    /// <summary>Field number for the "prev_coin_b_num" field.</summary>
    public const int PrevCoinBNumFieldNumber = 1;
    private uint prevCoinBNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PrevCoinBNum {
      get { return prevCoinBNum_; }
      set {
        prevCoinBNum_ = value;
      }
    }

    /// <summary>Field number for the "open_store_list" field.</summary>
    public const int OpenStoreListFieldNumber = 9;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.VintageMarketStoreInfo> _repeated_openStoreList_codec
        = pb::FieldCodec.ForMessage(74, global::Weedwacker.Shared.Network.Proto.VintageMarketStoreInfo.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.VintageMarketStoreInfo> openStoreList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.VintageMarketStoreInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.VintageMarketStoreInfo> OpenStoreList {
      get { return openStoreList_; }
    }

    /// <summary>Field number for the "help_skill_id" field.</summary>
    public const int HelpSkillIdFieldNumber = 760;
    private uint helpSkillId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HelpSkillId {
      get { return helpSkillId_; }
      set {
        helpSkillId_ = value;
      }
    }

    /// <summary>Field number for the "is_round_tips_view" field.</summary>
    public const int IsRoundTipsViewFieldNumber = 12;
    private bool isRoundTipsView_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsRoundTipsView {
      get { return isRoundTipsView_; }
      set {
        isRoundTipsView_ = value;
      }
    }

    /// <summary>Field number for the "is_strategy_module_open" field.</summary>
    public const int IsStrategyModuleOpenFieldNumber = 876;
    private bool isStrategyModuleOpen_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsStrategyModuleOpen {
      get { return isStrategyModuleOpen_; }
      set {
        isStrategyModuleOpen_ = value;
      }
    }

    /// <summary>Field number for the "unlock_strategy_list" field.</summary>
    public const int UnlockStrategyListFieldNumber = 13;
    private static readonly pb::FieldCodec<uint> _repeated_unlockStrategyList_codec
        = pb::FieldCodec.ForUInt32(106);
    private readonly pbc::RepeatedField<uint> unlockStrategyList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> UnlockStrategyList {
      get { return unlockStrategyList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as VintageMarketInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(VintageMarketInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsHelpModuleOpen != other.IsHelpModuleOpen) return false;
      if (IsStoreContentInterrupt != other.IsStoreContentInterrupt) return false;
      if (!object.Equals(DealInfo, other.DealInfo)) return false;
      if (StoreRound != other.StoreRound) return false;
      if(!storeRoundIncomeList_.Equals(other.storeRoundIncomeList_)) return false;
      if (IsStoreContentFinish != other.IsStoreContentFinish) return false;
      if(!curEnvEventList_.Equals(other.curEnvEventList_)) return false;
      if (IsMarketContentOpen != other.IsMarketContentOpen) return false;
      if (NextCanUseHelpRound != other.NextCanUseHelpRound) return false;
      if (IsMarketContentFinish != other.IsMarketContentFinish) return false;
      if(!viewedStrategyList_.Equals(other.viewedStrategyList_)) return false;
      if (PrevCoinCNum != other.PrevCoinCNum) return false;
      if (!BargainInfoMap.Equals(other.BargainInfoMap)) return false;
      if (DividendRewardCount != other.DividendRewardCount) return false;
      if(!curNpcEventList_.Equals(other.curNpcEventList_)) return false;
      if (IsHelpInCd != other.IsHelpInCd) return false;
      if (PrevCoinBNum != other.PrevCoinBNum) return false;
      if(!openStoreList_.Equals(other.openStoreList_)) return false;
      if (HelpSkillId != other.HelpSkillId) return false;
      if (IsRoundTipsView != other.IsRoundTipsView) return false;
      if (IsStrategyModuleOpen != other.IsStrategyModuleOpen) return false;
      if(!unlockStrategyList_.Equals(other.unlockStrategyList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsHelpModuleOpen != false) hash ^= IsHelpModuleOpen.GetHashCode();
      if (IsStoreContentInterrupt != false) hash ^= IsStoreContentInterrupt.GetHashCode();
      if (dealInfo_ != null) hash ^= DealInfo.GetHashCode();
      if (StoreRound != 0) hash ^= StoreRound.GetHashCode();
      hash ^= storeRoundIncomeList_.GetHashCode();
      if (IsStoreContentFinish != false) hash ^= IsStoreContentFinish.GetHashCode();
      hash ^= curEnvEventList_.GetHashCode();
      if (IsMarketContentOpen != false) hash ^= IsMarketContentOpen.GetHashCode();
      if (NextCanUseHelpRound != 0) hash ^= NextCanUseHelpRound.GetHashCode();
      if (IsMarketContentFinish != false) hash ^= IsMarketContentFinish.GetHashCode();
      hash ^= viewedStrategyList_.GetHashCode();
      if (PrevCoinCNum != 0) hash ^= PrevCoinCNum.GetHashCode();
      hash ^= BargainInfoMap.GetHashCode();
      if (DividendRewardCount != 0) hash ^= DividendRewardCount.GetHashCode();
      hash ^= curNpcEventList_.GetHashCode();
      if (IsHelpInCd != false) hash ^= IsHelpInCd.GetHashCode();
      if (PrevCoinBNum != 0) hash ^= PrevCoinBNum.GetHashCode();
      hash ^= openStoreList_.GetHashCode();
      if (HelpSkillId != 0) hash ^= HelpSkillId.GetHashCode();
      if (IsRoundTipsView != false) hash ^= IsRoundTipsView.GetHashCode();
      if (IsStrategyModuleOpen != false) hash ^= IsStrategyModuleOpen.GetHashCode();
      hash ^= unlockStrategyList_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (PrevCoinBNum != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(PrevCoinBNum);
      }
      if (IsMarketContentFinish != false) {
        output.WriteRawTag(16);
        output.WriteBool(IsMarketContentFinish);
      }
      if (PrevCoinCNum != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(PrevCoinCNum);
      }
      curNpcEventList_.WriteTo(output, _repeated_curNpcEventList_codec);
      if (IsStoreContentFinish != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsStoreContentFinish);
      }
      bargainInfoMap_.WriteTo(output, _map_bargainInfoMap_codec);
      if (StoreRound != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(StoreRound);
      }
      curEnvEventList_.WriteTo(output, _repeated_curEnvEventList_codec);
      openStoreList_.WriteTo(output, _repeated_openStoreList_codec);
      if (IsMarketContentOpen != false) {
        output.WriteRawTag(80);
        output.WriteBool(IsMarketContentOpen);
      }
      if (dealInfo_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(DealInfo);
      }
      if (IsRoundTipsView != false) {
        output.WriteRawTag(96);
        output.WriteBool(IsRoundTipsView);
      }
      unlockStrategyList_.WriteTo(output, _repeated_unlockStrategyList_codec);
      viewedStrategyList_.WriteTo(output, _repeated_viewedStrategyList_codec);
      if (IsStoreContentInterrupt != false) {
        output.WriteRawTag(120);
        output.WriteBool(IsStoreContentInterrupt);
      }
      storeRoundIncomeList_.WriteTo(output, _repeated_storeRoundIncomeList_codec);
      if (IsHelpInCd != false) {
        output.WriteRawTag(240, 22);
        output.WriteBool(IsHelpInCd);
      }
      if (HelpSkillId != 0) {
        output.WriteRawTag(192, 47);
        output.WriteUInt32(HelpSkillId);
      }
      if (IsStrategyModuleOpen != false) {
        output.WriteRawTag(224, 54);
        output.WriteBool(IsStrategyModuleOpen);
      }
      if (IsHelpModuleOpen != false) {
        output.WriteRawTag(232, 92);
        output.WriteBool(IsHelpModuleOpen);
      }
      if (DividendRewardCount != 0) {
        output.WriteRawTag(176, 112);
        output.WriteUInt32(DividendRewardCount);
      }
      if (NextCanUseHelpRound != 0) {
        output.WriteRawTag(192, 112);
        output.WriteUInt32(NextCanUseHelpRound);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (PrevCoinBNum != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(PrevCoinBNum);
      }
      if (IsMarketContentFinish != false) {
        output.WriteRawTag(16);
        output.WriteBool(IsMarketContentFinish);
      }
      if (PrevCoinCNum != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(PrevCoinCNum);
      }
      curNpcEventList_.WriteTo(ref output, _repeated_curNpcEventList_codec);
      if (IsStoreContentFinish != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsStoreContentFinish);
      }
      bargainInfoMap_.WriteTo(ref output, _map_bargainInfoMap_codec);
      if (StoreRound != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(StoreRound);
      }
      curEnvEventList_.WriteTo(ref output, _repeated_curEnvEventList_codec);
      openStoreList_.WriteTo(ref output, _repeated_openStoreList_codec);
      if (IsMarketContentOpen != false) {
        output.WriteRawTag(80);
        output.WriteBool(IsMarketContentOpen);
      }
      if (dealInfo_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(DealInfo);
      }
      if (IsRoundTipsView != false) {
        output.WriteRawTag(96);
        output.WriteBool(IsRoundTipsView);
      }
      unlockStrategyList_.WriteTo(ref output, _repeated_unlockStrategyList_codec);
      viewedStrategyList_.WriteTo(ref output, _repeated_viewedStrategyList_codec);
      if (IsStoreContentInterrupt != false) {
        output.WriteRawTag(120);
        output.WriteBool(IsStoreContentInterrupt);
      }
      storeRoundIncomeList_.WriteTo(ref output, _repeated_storeRoundIncomeList_codec);
      if (IsHelpInCd != false) {
        output.WriteRawTag(240, 22);
        output.WriteBool(IsHelpInCd);
      }
      if (HelpSkillId != 0) {
        output.WriteRawTag(192, 47);
        output.WriteUInt32(HelpSkillId);
      }
      if (IsStrategyModuleOpen != false) {
        output.WriteRawTag(224, 54);
        output.WriteBool(IsStrategyModuleOpen);
      }
      if (IsHelpModuleOpen != false) {
        output.WriteRawTag(232, 92);
        output.WriteBool(IsHelpModuleOpen);
      }
      if (DividendRewardCount != 0) {
        output.WriteRawTag(176, 112);
        output.WriteUInt32(DividendRewardCount);
      }
      if (NextCanUseHelpRound != 0) {
        output.WriteRawTag(192, 112);
        output.WriteUInt32(NextCanUseHelpRound);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (IsHelpModuleOpen != false) {
        size += 2 + 1;
      }
      if (IsStoreContentInterrupt != false) {
        size += 1 + 1;
      }
      if (dealInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DealInfo);
      }
      if (StoreRound != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StoreRound);
      }
      size += storeRoundIncomeList_.CalculateSize(_repeated_storeRoundIncomeList_codec);
      if (IsStoreContentFinish != false) {
        size += 1 + 1;
      }
      size += curEnvEventList_.CalculateSize(_repeated_curEnvEventList_codec);
      if (IsMarketContentOpen != false) {
        size += 1 + 1;
      }
      if (NextCanUseHelpRound != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(NextCanUseHelpRound);
      }
      if (IsMarketContentFinish != false) {
        size += 1 + 1;
      }
      size += viewedStrategyList_.CalculateSize(_repeated_viewedStrategyList_codec);
      if (PrevCoinCNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PrevCoinCNum);
      }
      size += bargainInfoMap_.CalculateSize(_map_bargainInfoMap_codec);
      if (DividendRewardCount != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(DividendRewardCount);
      }
      size += curNpcEventList_.CalculateSize(_repeated_curNpcEventList_codec);
      if (IsHelpInCd != false) {
        size += 2 + 1;
      }
      if (PrevCoinBNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PrevCoinBNum);
      }
      size += openStoreList_.CalculateSize(_repeated_openStoreList_codec);
      if (HelpSkillId != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(HelpSkillId);
      }
      if (IsRoundTipsView != false) {
        size += 1 + 1;
      }
      if (IsStrategyModuleOpen != false) {
        size += 2 + 1;
      }
      size += unlockStrategyList_.CalculateSize(_repeated_unlockStrategyList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(VintageMarketInfo other) {
      if (other == null) {
        return;
      }
      if (other.IsHelpModuleOpen != false) {
        IsHelpModuleOpen = other.IsHelpModuleOpen;
      }
      if (other.IsStoreContentInterrupt != false) {
        IsStoreContentInterrupt = other.IsStoreContentInterrupt;
      }
      if (other.dealInfo_ != null) {
        if (dealInfo_ == null) {
          DealInfo = new global::Weedwacker.Shared.Network.Proto.VintageMarketDealInfo();
        }
        DealInfo.MergeFrom(other.DealInfo);
      }
      if (other.StoreRound != 0) {
        StoreRound = other.StoreRound;
      }
      storeRoundIncomeList_.Add(other.storeRoundIncomeList_);
      if (other.IsStoreContentFinish != false) {
        IsStoreContentFinish = other.IsStoreContentFinish;
      }
      curEnvEventList_.Add(other.curEnvEventList_);
      if (other.IsMarketContentOpen != false) {
        IsMarketContentOpen = other.IsMarketContentOpen;
      }
      if (other.NextCanUseHelpRound != 0) {
        NextCanUseHelpRound = other.NextCanUseHelpRound;
      }
      if (other.IsMarketContentFinish != false) {
        IsMarketContentFinish = other.IsMarketContentFinish;
      }
      viewedStrategyList_.Add(other.viewedStrategyList_);
      if (other.PrevCoinCNum != 0) {
        PrevCoinCNum = other.PrevCoinCNum;
      }
      bargainInfoMap_.Add(other.bargainInfoMap_);
      if (other.DividendRewardCount != 0) {
        DividendRewardCount = other.DividendRewardCount;
      }
      curNpcEventList_.Add(other.curNpcEventList_);
      if (other.IsHelpInCd != false) {
        IsHelpInCd = other.IsHelpInCd;
      }
      if (other.PrevCoinBNum != 0) {
        PrevCoinBNum = other.PrevCoinBNum;
      }
      openStoreList_.Add(other.openStoreList_);
      if (other.HelpSkillId != 0) {
        HelpSkillId = other.HelpSkillId;
      }
      if (other.IsRoundTipsView != false) {
        IsRoundTipsView = other.IsRoundTipsView;
      }
      if (other.IsStrategyModuleOpen != false) {
        IsStrategyModuleOpen = other.IsStrategyModuleOpen;
      }
      unlockStrategyList_.Add(other.unlockStrategyList_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            PrevCoinBNum = input.ReadUInt32();
            break;
          }
          case 16: {
            IsMarketContentFinish = input.ReadBool();
            break;
          }
          case 24: {
            PrevCoinCNum = input.ReadUInt32();
            break;
          }
          case 34:
          case 32: {
            curNpcEventList_.AddEntriesFrom(input, _repeated_curNpcEventList_codec);
            break;
          }
          case 40: {
            IsStoreContentFinish = input.ReadBool();
            break;
          }
          case 50: {
            bargainInfoMap_.AddEntriesFrom(input, _map_bargainInfoMap_codec);
            break;
          }
          case 56: {
            StoreRound = input.ReadUInt32();
            break;
          }
          case 66:
          case 64: {
            curEnvEventList_.AddEntriesFrom(input, _repeated_curEnvEventList_codec);
            break;
          }
          case 74: {
            openStoreList_.AddEntriesFrom(input, _repeated_openStoreList_codec);
            break;
          }
          case 80: {
            IsMarketContentOpen = input.ReadBool();
            break;
          }
          case 90: {
            if (dealInfo_ == null) {
              DealInfo = new global::Weedwacker.Shared.Network.Proto.VintageMarketDealInfo();
            }
            input.ReadMessage(DealInfo);
            break;
          }
          case 96: {
            IsRoundTipsView = input.ReadBool();
            break;
          }
          case 106:
          case 104: {
            unlockStrategyList_.AddEntriesFrom(input, _repeated_unlockStrategyList_codec);
            break;
          }
          case 114:
          case 112: {
            viewedStrategyList_.AddEntriesFrom(input, _repeated_viewedStrategyList_codec);
            break;
          }
          case 120: {
            IsStoreContentInterrupt = input.ReadBool();
            break;
          }
          case 1658:
          case 1656: {
            storeRoundIncomeList_.AddEntriesFrom(input, _repeated_storeRoundIncomeList_codec);
            break;
          }
          case 2928: {
            IsHelpInCd = input.ReadBool();
            break;
          }
          case 6080: {
            HelpSkillId = input.ReadUInt32();
            break;
          }
          case 7008: {
            IsStrategyModuleOpen = input.ReadBool();
            break;
          }
          case 11880: {
            IsHelpModuleOpen = input.ReadBool();
            break;
          }
          case 14384: {
            DividendRewardCount = input.ReadUInt32();
            break;
          }
          case 14400: {
            NextCanUseHelpRound = input.ReadUInt32();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            PrevCoinBNum = input.ReadUInt32();
            break;
          }
          case 16: {
            IsMarketContentFinish = input.ReadBool();
            break;
          }
          case 24: {
            PrevCoinCNum = input.ReadUInt32();
            break;
          }
          case 34:
          case 32: {
            curNpcEventList_.AddEntriesFrom(ref input, _repeated_curNpcEventList_codec);
            break;
          }
          case 40: {
            IsStoreContentFinish = input.ReadBool();
            break;
          }
          case 50: {
            bargainInfoMap_.AddEntriesFrom(ref input, _map_bargainInfoMap_codec);
            break;
          }
          case 56: {
            StoreRound = input.ReadUInt32();
            break;
          }
          case 66:
          case 64: {
            curEnvEventList_.AddEntriesFrom(ref input, _repeated_curEnvEventList_codec);
            break;
          }
          case 74: {
            openStoreList_.AddEntriesFrom(ref input, _repeated_openStoreList_codec);
            break;
          }
          case 80: {
            IsMarketContentOpen = input.ReadBool();
            break;
          }
          case 90: {
            if (dealInfo_ == null) {
              DealInfo = new global::Weedwacker.Shared.Network.Proto.VintageMarketDealInfo();
            }
            input.ReadMessage(DealInfo);
            break;
          }
          case 96: {
            IsRoundTipsView = input.ReadBool();
            break;
          }
          case 106:
          case 104: {
            unlockStrategyList_.AddEntriesFrom(ref input, _repeated_unlockStrategyList_codec);
            break;
          }
          case 114:
          case 112: {
            viewedStrategyList_.AddEntriesFrom(ref input, _repeated_viewedStrategyList_codec);
            break;
          }
          case 120: {
            IsStoreContentInterrupt = input.ReadBool();
            break;
          }
          case 1658:
          case 1656: {
            storeRoundIncomeList_.AddEntriesFrom(ref input, _repeated_storeRoundIncomeList_codec);
            break;
          }
          case 2928: {
            IsHelpInCd = input.ReadBool();
            break;
          }
          case 6080: {
            HelpSkillId = input.ReadUInt32();
            break;
          }
          case 7008: {
            IsStrategyModuleOpen = input.ReadBool();
            break;
          }
          case 11880: {
            IsHelpModuleOpen = input.ReadBool();
            break;
          }
          case 14384: {
            DividendRewardCount = input.ReadUInt32();
            break;
          }
          case 14400: {
            NextCanUseHelpRound = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
