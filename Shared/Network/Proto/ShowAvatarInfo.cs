// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ShowAvatarInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from ShowAvatarInfo.proto</summary>
  public static partial class ShowAvatarInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for ShowAvatarInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ShowAvatarInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRTaG93QXZhdGFySW5mby5wcm90bxoVQXZhdGFyRXhjZWxJbmZvLnByb3Rv",
            "GhZBdmF0YXJGZXR0ZXJJbmZvLnByb3RvGg9Qcm9wVmFsdWUucHJvdG8aD1No",
            "b3dFcXVpcC5wcm90byL6BQoOU2hvd0F2YXRhckluZm8SEQoJYXZhdGFyX2lk",
            "GAEgASgNEi4KCHByb3BfbWFwGAIgAygLMhwuU2hvd0F2YXRhckluZm8uUHJv",
            "cE1hcEVudHJ5EhYKDnRhbGVudF9pZF9saXN0GAMgAygNEjkKDmZpZ2h0X3By",
            "b3BfbWFwGAQgAygLMiEuU2hvd0F2YXRhckluZm8uRmlnaHRQcm9wTWFwRW50",
            "cnkSFgoOc2tpbGxfZGVwb3RfaWQYBSABKA0SHgoWY29yZV9wcm91ZF9za2ls",
            "bF9sZXZlbBgGIAEoDRIhChlpbmhlcmVudF9wcm91ZF9za2lsbF9saXN0GAcg",
            "AygNEjsKD3NraWxsX2xldmVsX21hcBgIIAMoCzIiLlNob3dBdmF0YXJJbmZv",
            "LlNraWxsTGV2ZWxNYXBFbnRyeRJRChtwcm91ZF9za2lsbF9leHRyYV9sZXZl",
            "bF9tYXAYCSADKAsyLC5TaG93QXZhdGFySW5mby5Qcm91ZFNraWxsRXh0cmFM",
            "ZXZlbE1hcEVudHJ5Eh4KCmVxdWlwX2xpc3QYCiADKAsyCi5TaG93RXF1aXAS",
            "JgoLZmV0dGVyX2luZm8YCyABKAsyES5BdmF0YXJGZXR0ZXJJbmZvEhIKCmNv",
            "c3R1bWVfaWQYDCABKA0SJAoKZXhjZWxfaW5mbxgNIAEoCzIQLkF2YXRhckV4",
            "Y2VsSW5mbxo6CgxQcm9wTWFwRW50cnkSCwoDa2V5GAEgASgNEhkKBXZhbHVl",
            "GAIgASgLMgouUHJvcFZhbHVlOgI4ARozChFGaWdodFByb3BNYXBFbnRyeRIL",
            "CgNrZXkYASABKA0SDQoFdmFsdWUYAiABKAI6AjgBGjQKElNraWxsTGV2ZWxN",
            "YXBFbnRyeRILCgNrZXkYASABKA0SDQoFdmFsdWUYAiABKA06AjgBGj4KHFBy",
            "b3VkU2tpbGxFeHRyYUxldmVsTWFwRW50cnkSCwoDa2V5GAEgASgNEg0KBXZh",
            "bHVlGAIgASgNOgI4AUIiqgIfV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Q",
            "cm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.AvatarExcelInfoReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.AvatarFetterInfoReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.PropValueReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.ShowEquipReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.ShowAvatarInfo), global::Weedwacker.Shared.Network.Proto.ShowAvatarInfo.Parser, new[]{ "AvatarId", "PropMap", "TalentIdList", "FightPropMap", "SkillDepotId", "CoreProudSkillLevel", "InherentProudSkillList", "SkillLevelMap", "ProudSkillExtraLevelMap", "EquipList", "FetterInfo", "CostumeId", "ExcelInfo" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, null, null, null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ShowAvatarInfo : pb::IMessage<ShowAvatarInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ShowAvatarInfo> _parser = new pb::MessageParser<ShowAvatarInfo>(() => new ShowAvatarInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ShowAvatarInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.ShowAvatarInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ShowAvatarInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ShowAvatarInfo(ShowAvatarInfo other) : this() {
      avatarId_ = other.avatarId_;
      propMap_ = other.propMap_.Clone();
      talentIdList_ = other.talentIdList_.Clone();
      fightPropMap_ = other.fightPropMap_.Clone();
      skillDepotId_ = other.skillDepotId_;
      coreProudSkillLevel_ = other.coreProudSkillLevel_;
      inherentProudSkillList_ = other.inherentProudSkillList_.Clone();
      skillLevelMap_ = other.skillLevelMap_.Clone();
      proudSkillExtraLevelMap_ = other.proudSkillExtraLevelMap_.Clone();
      equipList_ = other.equipList_.Clone();
      fetterInfo_ = other.fetterInfo_ != null ? other.fetterInfo_.Clone() : null;
      costumeId_ = other.costumeId_;
      excelInfo_ = other.excelInfo_ != null ? other.excelInfo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ShowAvatarInfo Clone() {
      return new ShowAvatarInfo(this);
    }

    /// <summary>Field number for the "avatar_id" field.</summary>
    public const int AvatarIdFieldNumber = 1;
    private uint avatarId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AvatarId {
      get { return avatarId_; }
      set {
        avatarId_ = value;
      }
    }

    /// <summary>Field number for the "prop_map" field.</summary>
    public const int PropMapFieldNumber = 2;
    private static readonly pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.PropValue>.Codec _map_propMap_codec
        = new pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.PropValue>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForMessage(18, global::Weedwacker.Shared.Network.Proto.PropValue.Parser), 18);
    private readonly pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.PropValue> propMap_ = new pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.PropValue>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.PropValue> PropMap {
      get { return propMap_; }
    }

    /// <summary>Field number for the "talent_id_list" field.</summary>
    public const int TalentIdListFieldNumber = 3;
    private static readonly pb::FieldCodec<uint> _repeated_talentIdList_codec
        = pb::FieldCodec.ForUInt32(26);
    private readonly pbc::RepeatedField<uint> talentIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> TalentIdList {
      get { return talentIdList_; }
    }

    /// <summary>Field number for the "fight_prop_map" field.</summary>
    public const int FightPropMapFieldNumber = 4;
    private static readonly pbc::MapField<uint, float>.Codec _map_fightPropMap_codec
        = new pbc::MapField<uint, float>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForFloat(21, 0F), 34);
    private readonly pbc::MapField<uint, float> fightPropMap_ = new pbc::MapField<uint, float>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, float> FightPropMap {
      get { return fightPropMap_; }
    }

    /// <summary>Field number for the "skill_depot_id" field.</summary>
    public const int SkillDepotIdFieldNumber = 5;
    private uint skillDepotId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SkillDepotId {
      get { return skillDepotId_; }
      set {
        skillDepotId_ = value;
      }
    }

    /// <summary>Field number for the "core_proud_skill_level" field.</summary>
    public const int CoreProudSkillLevelFieldNumber = 6;
    private uint coreProudSkillLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CoreProudSkillLevel {
      get { return coreProudSkillLevel_; }
      set {
        coreProudSkillLevel_ = value;
      }
    }

    /// <summary>Field number for the "inherent_proud_skill_list" field.</summary>
    public const int InherentProudSkillListFieldNumber = 7;
    private static readonly pb::FieldCodec<uint> _repeated_inherentProudSkillList_codec
        = pb::FieldCodec.ForUInt32(58);
    private readonly pbc::RepeatedField<uint> inherentProudSkillList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> InherentProudSkillList {
      get { return inherentProudSkillList_; }
    }

    /// <summary>Field number for the "skill_level_map" field.</summary>
    public const int SkillLevelMapFieldNumber = 8;
    private static readonly pbc::MapField<uint, uint>.Codec _map_skillLevelMap_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 66);
    private readonly pbc::MapField<uint, uint> skillLevelMap_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> SkillLevelMap {
      get { return skillLevelMap_; }
    }

    /// <summary>Field number for the "proud_skill_extra_level_map" field.</summary>
    public const int ProudSkillExtraLevelMapFieldNumber = 9;
    private static readonly pbc::MapField<uint, uint>.Codec _map_proudSkillExtraLevelMap_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 74);
    private readonly pbc::MapField<uint, uint> proudSkillExtraLevelMap_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> ProudSkillExtraLevelMap {
      get { return proudSkillExtraLevelMap_; }
    }

    /// <summary>Field number for the "equip_list" field.</summary>
    public const int EquipListFieldNumber = 10;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.ShowEquip> _repeated_equipList_codec
        = pb::FieldCodec.ForMessage(82, global::Weedwacker.Shared.Network.Proto.ShowEquip.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ShowEquip> equipList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ShowEquip>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ShowEquip> EquipList {
      get { return equipList_; }
    }

    /// <summary>Field number for the "fetter_info" field.</summary>
    public const int FetterInfoFieldNumber = 11;
    private global::Weedwacker.Shared.Network.Proto.AvatarFetterInfo fetterInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.AvatarFetterInfo FetterInfo {
      get { return fetterInfo_; }
      set {
        fetterInfo_ = value;
      }
    }

    /// <summary>Field number for the "costume_id" field.</summary>
    public const int CostumeIdFieldNumber = 12;
    private uint costumeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CostumeId {
      get { return costumeId_; }
      set {
        costumeId_ = value;
      }
    }

    /// <summary>Field number for the "excel_info" field.</summary>
    public const int ExcelInfoFieldNumber = 13;
    private global::Weedwacker.Shared.Network.Proto.AvatarExcelInfo excelInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.AvatarExcelInfo ExcelInfo {
      get { return excelInfo_; }
      set {
        excelInfo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ShowAvatarInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ShowAvatarInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AvatarId != other.AvatarId) return false;
      if (!PropMap.Equals(other.PropMap)) return false;
      if(!talentIdList_.Equals(other.talentIdList_)) return false;
      if (!FightPropMap.Equals(other.FightPropMap)) return false;
      if (SkillDepotId != other.SkillDepotId) return false;
      if (CoreProudSkillLevel != other.CoreProudSkillLevel) return false;
      if(!inherentProudSkillList_.Equals(other.inherentProudSkillList_)) return false;
      if (!SkillLevelMap.Equals(other.SkillLevelMap)) return false;
      if (!ProudSkillExtraLevelMap.Equals(other.ProudSkillExtraLevelMap)) return false;
      if(!equipList_.Equals(other.equipList_)) return false;
      if (!object.Equals(FetterInfo, other.FetterInfo)) return false;
      if (CostumeId != other.CostumeId) return false;
      if (!object.Equals(ExcelInfo, other.ExcelInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (AvatarId != 0) hash ^= AvatarId.GetHashCode();
      hash ^= PropMap.GetHashCode();
      hash ^= talentIdList_.GetHashCode();
      hash ^= FightPropMap.GetHashCode();
      if (SkillDepotId != 0) hash ^= SkillDepotId.GetHashCode();
      if (CoreProudSkillLevel != 0) hash ^= CoreProudSkillLevel.GetHashCode();
      hash ^= inherentProudSkillList_.GetHashCode();
      hash ^= SkillLevelMap.GetHashCode();
      hash ^= ProudSkillExtraLevelMap.GetHashCode();
      hash ^= equipList_.GetHashCode();
      if (fetterInfo_ != null) hash ^= FetterInfo.GetHashCode();
      if (CostumeId != 0) hash ^= CostumeId.GetHashCode();
      if (excelInfo_ != null) hash ^= ExcelInfo.GetHashCode();
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
      if (AvatarId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(AvatarId);
      }
      propMap_.WriteTo(output, _map_propMap_codec);
      talentIdList_.WriteTo(output, _repeated_talentIdList_codec);
      fightPropMap_.WriteTo(output, _map_fightPropMap_codec);
      if (SkillDepotId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(SkillDepotId);
      }
      if (CoreProudSkillLevel != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(CoreProudSkillLevel);
      }
      inherentProudSkillList_.WriteTo(output, _repeated_inherentProudSkillList_codec);
      skillLevelMap_.WriteTo(output, _map_skillLevelMap_codec);
      proudSkillExtraLevelMap_.WriteTo(output, _map_proudSkillExtraLevelMap_codec);
      equipList_.WriteTo(output, _repeated_equipList_codec);
      if (fetterInfo_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(FetterInfo);
      }
      if (CostumeId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(CostumeId);
      }
      if (excelInfo_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(ExcelInfo);
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
      if (AvatarId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(AvatarId);
      }
      propMap_.WriteTo(ref output, _map_propMap_codec);
      talentIdList_.WriteTo(ref output, _repeated_talentIdList_codec);
      fightPropMap_.WriteTo(ref output, _map_fightPropMap_codec);
      if (SkillDepotId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(SkillDepotId);
      }
      if (CoreProudSkillLevel != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(CoreProudSkillLevel);
      }
      inherentProudSkillList_.WriteTo(ref output, _repeated_inherentProudSkillList_codec);
      skillLevelMap_.WriteTo(ref output, _map_skillLevelMap_codec);
      proudSkillExtraLevelMap_.WriteTo(ref output, _map_proudSkillExtraLevelMap_codec);
      equipList_.WriteTo(ref output, _repeated_equipList_codec);
      if (fetterInfo_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(FetterInfo);
      }
      if (CostumeId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(CostumeId);
      }
      if (excelInfo_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(ExcelInfo);
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
      if (AvatarId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AvatarId);
      }
      size += propMap_.CalculateSize(_map_propMap_codec);
      size += talentIdList_.CalculateSize(_repeated_talentIdList_codec);
      size += fightPropMap_.CalculateSize(_map_fightPropMap_codec);
      if (SkillDepotId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SkillDepotId);
      }
      if (CoreProudSkillLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CoreProudSkillLevel);
      }
      size += inherentProudSkillList_.CalculateSize(_repeated_inherentProudSkillList_codec);
      size += skillLevelMap_.CalculateSize(_map_skillLevelMap_codec);
      size += proudSkillExtraLevelMap_.CalculateSize(_map_proudSkillExtraLevelMap_codec);
      size += equipList_.CalculateSize(_repeated_equipList_codec);
      if (fetterInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FetterInfo);
      }
      if (CostumeId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CostumeId);
      }
      if (excelInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ExcelInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ShowAvatarInfo other) {
      if (other == null) {
        return;
      }
      if (other.AvatarId != 0) {
        AvatarId = other.AvatarId;
      }
      propMap_.Add(other.propMap_);
      talentIdList_.Add(other.talentIdList_);
      fightPropMap_.Add(other.fightPropMap_);
      if (other.SkillDepotId != 0) {
        SkillDepotId = other.SkillDepotId;
      }
      if (other.CoreProudSkillLevel != 0) {
        CoreProudSkillLevel = other.CoreProudSkillLevel;
      }
      inherentProudSkillList_.Add(other.inherentProudSkillList_);
      skillLevelMap_.Add(other.skillLevelMap_);
      proudSkillExtraLevelMap_.Add(other.proudSkillExtraLevelMap_);
      equipList_.Add(other.equipList_);
      if (other.fetterInfo_ != null) {
        if (fetterInfo_ == null) {
          FetterInfo = new global::Weedwacker.Shared.Network.Proto.AvatarFetterInfo();
        }
        FetterInfo.MergeFrom(other.FetterInfo);
      }
      if (other.CostumeId != 0) {
        CostumeId = other.CostumeId;
      }
      if (other.excelInfo_ != null) {
        if (excelInfo_ == null) {
          ExcelInfo = new global::Weedwacker.Shared.Network.Proto.AvatarExcelInfo();
        }
        ExcelInfo.MergeFrom(other.ExcelInfo);
      }
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
            AvatarId = input.ReadUInt32();
            break;
          }
          case 18: {
            propMap_.AddEntriesFrom(input, _map_propMap_codec);
            break;
          }
          case 26:
          case 24: {
            talentIdList_.AddEntriesFrom(input, _repeated_talentIdList_codec);
            break;
          }
          case 34: {
            fightPropMap_.AddEntriesFrom(input, _map_fightPropMap_codec);
            break;
          }
          case 40: {
            SkillDepotId = input.ReadUInt32();
            break;
          }
          case 48: {
            CoreProudSkillLevel = input.ReadUInt32();
            break;
          }
          case 58:
          case 56: {
            inherentProudSkillList_.AddEntriesFrom(input, _repeated_inherentProudSkillList_codec);
            break;
          }
          case 66: {
            skillLevelMap_.AddEntriesFrom(input, _map_skillLevelMap_codec);
            break;
          }
          case 74: {
            proudSkillExtraLevelMap_.AddEntriesFrom(input, _map_proudSkillExtraLevelMap_codec);
            break;
          }
          case 82: {
            equipList_.AddEntriesFrom(input, _repeated_equipList_codec);
            break;
          }
          case 90: {
            if (fetterInfo_ == null) {
              FetterInfo = new global::Weedwacker.Shared.Network.Proto.AvatarFetterInfo();
            }
            input.ReadMessage(FetterInfo);
            break;
          }
          case 96: {
            CostumeId = input.ReadUInt32();
            break;
          }
          case 106: {
            if (excelInfo_ == null) {
              ExcelInfo = new global::Weedwacker.Shared.Network.Proto.AvatarExcelInfo();
            }
            input.ReadMessage(ExcelInfo);
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
            AvatarId = input.ReadUInt32();
            break;
          }
          case 18: {
            propMap_.AddEntriesFrom(ref input, _map_propMap_codec);
            break;
          }
          case 26:
          case 24: {
            talentIdList_.AddEntriesFrom(ref input, _repeated_talentIdList_codec);
            break;
          }
          case 34: {
            fightPropMap_.AddEntriesFrom(ref input, _map_fightPropMap_codec);
            break;
          }
          case 40: {
            SkillDepotId = input.ReadUInt32();
            break;
          }
          case 48: {
            CoreProudSkillLevel = input.ReadUInt32();
            break;
          }
          case 58:
          case 56: {
            inherentProudSkillList_.AddEntriesFrom(ref input, _repeated_inherentProudSkillList_codec);
            break;
          }
          case 66: {
            skillLevelMap_.AddEntriesFrom(ref input, _map_skillLevelMap_codec);
            break;
          }
          case 74: {
            proudSkillExtraLevelMap_.AddEntriesFrom(ref input, _map_proudSkillExtraLevelMap_codec);
            break;
          }
          case 82: {
            equipList_.AddEntriesFrom(ref input, _repeated_equipList_codec);
            break;
          }
          case 90: {
            if (fetterInfo_ == null) {
              FetterInfo = new global::Weedwacker.Shared.Network.Proto.AvatarFetterInfo();
            }
            input.ReadMessage(FetterInfo);
            break;
          }
          case 96: {
            CostumeId = input.ReadUInt32();
            break;
          }
          case 106: {
            if (excelInfo_ == null) {
              ExcelInfo = new global::Weedwacker.Shared.Network.Proto.AvatarExcelInfo();
            }
            input.ReadMessage(ExcelInfo);
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