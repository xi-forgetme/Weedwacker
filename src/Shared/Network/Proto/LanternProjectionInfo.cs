// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: LanternProjectionInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from LanternProjectionInfo.proto</summary>
  public static partial class LanternProjectionInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for LanternProjectionInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LanternProjectionInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtMYW50ZXJuUHJvamVjdGlvbkluZm8ucHJvdG8aFUNsaWVudElucHV0VHlw",
            "ZS5wcm90bxogTGFudGVyblByb2plY3Rpb25MZXZlbEluZm8ucHJvdG8iwgEK",
            "FUxhbnRlcm5Qcm9qZWN0aW9uSW5mbxIvChV2aWV3X3N3aXRjaF90aXBzX2xp",
            "c3QYDCADKA4yEC5DbGllbnRJbnB1dFR5cGUSLwoKbGV2ZWxfbGlzdBgGIAMo",
            "CzIbLkxhbnRlcm5Qcm9qZWN0aW9uTGV2ZWxJbmZvEhcKD29wZW5fc3RhZ2Vf",
            "bGlzdBgKIAMoDRIuChR2aWV3X2lucHV0X3RpcHNfbGlzdBgNIAMoDjIQLkNs",
            "aWVudElucHV0VHlwZUIiqgIfV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Q",
            "cm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.ClientInputTypeReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.LanternProjectionLevelInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.LanternProjectionInfo), global::Weedwacker.Shared.Network.Proto.LanternProjectionInfo.Parser, new[]{ "ViewSwitchTipsList", "LevelList", "OpenStageList", "ViewInputTipsList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class LanternProjectionInfo : pb::IMessage<LanternProjectionInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<LanternProjectionInfo> _parser = new pb::MessageParser<LanternProjectionInfo>(() => new LanternProjectionInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<LanternProjectionInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.LanternProjectionInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LanternProjectionInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LanternProjectionInfo(LanternProjectionInfo other) : this() {
      viewSwitchTipsList_ = other.viewSwitchTipsList_.Clone();
      levelList_ = other.levelList_.Clone();
      openStageList_ = other.openStageList_.Clone();
      viewInputTipsList_ = other.viewInputTipsList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LanternProjectionInfo Clone() {
      return new LanternProjectionInfo(this);
    }

    /// <summary>Field number for the "view_switch_tips_list" field.</summary>
    public const int ViewSwitchTipsListFieldNumber = 12;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.ClientInputType> _repeated_viewSwitchTipsList_codec
        = pb::FieldCodec.ForEnum(98, x => (int) x, x => (global::Weedwacker.Shared.Network.Proto.ClientInputType) x);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ClientInputType> viewSwitchTipsList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ClientInputType>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ClientInputType> ViewSwitchTipsList {
      get { return viewSwitchTipsList_; }
    }

    /// <summary>Field number for the "level_list" field.</summary>
    public const int LevelListFieldNumber = 6;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.LanternProjectionLevelInfo> _repeated_levelList_codec
        = pb::FieldCodec.ForMessage(50, global::Weedwacker.Shared.Network.Proto.LanternProjectionLevelInfo.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.LanternProjectionLevelInfo> levelList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.LanternProjectionLevelInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.LanternProjectionLevelInfo> LevelList {
      get { return levelList_; }
    }

    /// <summary>Field number for the "open_stage_list" field.</summary>
    public const int OpenStageListFieldNumber = 10;
    private static readonly pb::FieldCodec<uint> _repeated_openStageList_codec
        = pb::FieldCodec.ForUInt32(82);
    private readonly pbc::RepeatedField<uint> openStageList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> OpenStageList {
      get { return openStageList_; }
    }

    /// <summary>Field number for the "view_input_tips_list" field.</summary>
    public const int ViewInputTipsListFieldNumber = 13;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.ClientInputType> _repeated_viewInputTipsList_codec
        = pb::FieldCodec.ForEnum(106, x => (int) x, x => (global::Weedwacker.Shared.Network.Proto.ClientInputType) x);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ClientInputType> viewInputTipsList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ClientInputType>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ClientInputType> ViewInputTipsList {
      get { return viewInputTipsList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as LanternProjectionInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(LanternProjectionInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!viewSwitchTipsList_.Equals(other.viewSwitchTipsList_)) return false;
      if(!levelList_.Equals(other.levelList_)) return false;
      if(!openStageList_.Equals(other.openStageList_)) return false;
      if(!viewInputTipsList_.Equals(other.viewInputTipsList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= viewSwitchTipsList_.GetHashCode();
      hash ^= levelList_.GetHashCode();
      hash ^= openStageList_.GetHashCode();
      hash ^= viewInputTipsList_.GetHashCode();
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
      levelList_.WriteTo(output, _repeated_levelList_codec);
      openStageList_.WriteTo(output, _repeated_openStageList_codec);
      viewSwitchTipsList_.WriteTo(output, _repeated_viewSwitchTipsList_codec);
      viewInputTipsList_.WriteTo(output, _repeated_viewInputTipsList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      levelList_.WriteTo(ref output, _repeated_levelList_codec);
      openStageList_.WriteTo(ref output, _repeated_openStageList_codec);
      viewSwitchTipsList_.WriteTo(ref output, _repeated_viewSwitchTipsList_codec);
      viewInputTipsList_.WriteTo(ref output, _repeated_viewInputTipsList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += viewSwitchTipsList_.CalculateSize(_repeated_viewSwitchTipsList_codec);
      size += levelList_.CalculateSize(_repeated_levelList_codec);
      size += openStageList_.CalculateSize(_repeated_openStageList_codec);
      size += viewInputTipsList_.CalculateSize(_repeated_viewInputTipsList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(LanternProjectionInfo other) {
      if (other == null) {
        return;
      }
      viewSwitchTipsList_.Add(other.viewSwitchTipsList_);
      levelList_.Add(other.levelList_);
      openStageList_.Add(other.openStageList_);
      viewInputTipsList_.Add(other.viewInputTipsList_);
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
          case 50: {
            levelList_.AddEntriesFrom(input, _repeated_levelList_codec);
            break;
          }
          case 82:
          case 80: {
            openStageList_.AddEntriesFrom(input, _repeated_openStageList_codec);
            break;
          }
          case 98:
          case 96: {
            viewSwitchTipsList_.AddEntriesFrom(input, _repeated_viewSwitchTipsList_codec);
            break;
          }
          case 106:
          case 104: {
            viewInputTipsList_.AddEntriesFrom(input, _repeated_viewInputTipsList_codec);
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
          case 50: {
            levelList_.AddEntriesFrom(ref input, _repeated_levelList_codec);
            break;
          }
          case 82:
          case 80: {
            openStageList_.AddEntriesFrom(ref input, _repeated_openStageList_codec);
            break;
          }
          case 98:
          case 96: {
            viewSwitchTipsList_.AddEntriesFrom(ref input, _repeated_viewSwitchTipsList_codec);
            break;
          }
          case 106:
          case 104: {
            viewInputTipsList_.AddEntriesFrom(ref input, _repeated_viewInputTipsList_codec);
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
