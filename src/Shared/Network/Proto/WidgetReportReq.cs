// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WidgetReportReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from WidgetReportReq.proto</summary>
  public static partial class WidgetReportReqReflection {

    #region Descriptor
    /// <summary>File descriptor for WidgetReportReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static WidgetReportReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVXaWRnZXRSZXBvcnRSZXEucHJvdG8iewoPV2lkZ2V0UmVwb3J0UmVxEiEK",
            "GWlzX2NsZWFyX3NreV9jcnlzdGFsX2hpbnQYBSABKAgSGQoRaXNfY2xpZW50",
            "X2NvbGxlY3QYDiABKAgSFQoNaXNfY2xlYXJfaGludBgNIAEoCBITCgttYXRl",
            "cmlhbF9pZBgPIAEoDUIiqgIfV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Q",
            "cm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.WidgetReportReq), global::Weedwacker.Shared.Network.Proto.WidgetReportReq.Parser, new[]{ "IsClearSkyCrystalHint", "IsClientCollect", "IsClearHint", "MaterialId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 4291
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// IsAllowClient: true
  /// </summary>
  public sealed partial class WidgetReportReq : pb::IMessage<WidgetReportReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<WidgetReportReq> _parser = new pb::MessageParser<WidgetReportReq>(() => new WidgetReportReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<WidgetReportReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.WidgetReportReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WidgetReportReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WidgetReportReq(WidgetReportReq other) : this() {
      isClearSkyCrystalHint_ = other.isClearSkyCrystalHint_;
      isClientCollect_ = other.isClientCollect_;
      isClearHint_ = other.isClearHint_;
      materialId_ = other.materialId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WidgetReportReq Clone() {
      return new WidgetReportReq(this);
    }

    /// <summary>Field number for the "is_clear_sky_crystal_hint" field.</summary>
    public const int IsClearSkyCrystalHintFieldNumber = 5;
    private bool isClearSkyCrystalHint_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsClearSkyCrystalHint {
      get { return isClearSkyCrystalHint_; }
      set {
        isClearSkyCrystalHint_ = value;
      }
    }

    /// <summary>Field number for the "is_client_collect" field.</summary>
    public const int IsClientCollectFieldNumber = 14;
    private bool isClientCollect_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsClientCollect {
      get { return isClientCollect_; }
      set {
        isClientCollect_ = value;
      }
    }

    /// <summary>Field number for the "is_clear_hint" field.</summary>
    public const int IsClearHintFieldNumber = 13;
    private bool isClearHint_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsClearHint {
      get { return isClearHint_; }
      set {
        isClearHint_ = value;
      }
    }

    /// <summary>Field number for the "material_id" field.</summary>
    public const int MaterialIdFieldNumber = 15;
    private uint materialId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MaterialId {
      get { return materialId_; }
      set {
        materialId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as WidgetReportReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(WidgetReportReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsClearSkyCrystalHint != other.IsClearSkyCrystalHint) return false;
      if (IsClientCollect != other.IsClientCollect) return false;
      if (IsClearHint != other.IsClearHint) return false;
      if (MaterialId != other.MaterialId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsClearSkyCrystalHint != false) hash ^= IsClearSkyCrystalHint.GetHashCode();
      if (IsClientCollect != false) hash ^= IsClientCollect.GetHashCode();
      if (IsClearHint != false) hash ^= IsClearHint.GetHashCode();
      if (MaterialId != 0) hash ^= MaterialId.GetHashCode();
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
      if (IsClearSkyCrystalHint != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsClearSkyCrystalHint);
      }
      if (IsClearHint != false) {
        output.WriteRawTag(104);
        output.WriteBool(IsClearHint);
      }
      if (IsClientCollect != false) {
        output.WriteRawTag(112);
        output.WriteBool(IsClientCollect);
      }
      if (MaterialId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(MaterialId);
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
      if (IsClearSkyCrystalHint != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsClearSkyCrystalHint);
      }
      if (IsClearHint != false) {
        output.WriteRawTag(104);
        output.WriteBool(IsClearHint);
      }
      if (IsClientCollect != false) {
        output.WriteRawTag(112);
        output.WriteBool(IsClientCollect);
      }
      if (MaterialId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(MaterialId);
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
      if (IsClearSkyCrystalHint != false) {
        size += 1 + 1;
      }
      if (IsClientCollect != false) {
        size += 1 + 1;
      }
      if (IsClearHint != false) {
        size += 1 + 1;
      }
      if (MaterialId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MaterialId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(WidgetReportReq other) {
      if (other == null) {
        return;
      }
      if (other.IsClearSkyCrystalHint != false) {
        IsClearSkyCrystalHint = other.IsClearSkyCrystalHint;
      }
      if (other.IsClientCollect != false) {
        IsClientCollect = other.IsClientCollect;
      }
      if (other.IsClearHint != false) {
        IsClearHint = other.IsClearHint;
      }
      if (other.MaterialId != 0) {
        MaterialId = other.MaterialId;
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
          case 40: {
            IsClearSkyCrystalHint = input.ReadBool();
            break;
          }
          case 104: {
            IsClearHint = input.ReadBool();
            break;
          }
          case 112: {
            IsClientCollect = input.ReadBool();
            break;
          }
          case 120: {
            MaterialId = input.ReadUInt32();
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
          case 40: {
            IsClearSkyCrystalHint = input.ReadBool();
            break;
          }
          case 104: {
            IsClearHint = input.ReadBool();
            break;
          }
          case 112: {
            IsClientCollect = input.ReadBool();
            break;
          }
          case 120: {
            MaterialId = input.ReadUInt32();
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
