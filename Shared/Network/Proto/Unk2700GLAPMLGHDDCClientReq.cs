// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Unk2700_GLAPMLGHDDC_ClientReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from Unk2700_GLAPMLGHDDC_ClientReq.proto</summary>
  public static partial class Unk2700GLAPMLGHDDCClientReqReflection {

    #region Descriptor
    /// <summary>File descriptor for Unk2700_GLAPMLGHDDC_ClientReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static Unk2700GLAPMLGHDDCClientReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNVbmsyNzAwX0dMQVBNTEdIRERDX0NsaWVudFJlcS5wcm90bxoZVW5rMjcw",
            "MF9OT0NMTkNDSkVHSy5wcm90byKEAQodVW5rMjcwMF9HTEFQTUxHSEREQ19D",
            "bGllbnRSZXESEwoLbWF0ZXJpYWxfaWQYDiABKA0SMQoTVW5rMjcwMF9NSEVL",
            "SkdBSUZCTxgKIAEoDjIULlVuazI3MDBfTk9DTE5DQ0pFR0sSGwoTVW5rMjcw",
            "MF9HTUhMSEtJSUdJQxgHIAEoDUIiqgIfV2VlZHdhY2tlci5TaGFyZWQuTmV0",
            "d29yay5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.Unk2700NOCLNCCJEGKReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.Unk2700_GLAPMLGHDDC_ClientReq), global::Weedwacker.Shared.Network.Proto.Unk2700_GLAPMLGHDDC_ClientReq.Parser, new[]{ "MaterialId", "Unk2700MHEKJGAIFBO", "Unk2700GMHLHKIIGIC" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 5960
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// IsAllowClient: true
  /// </summary>
  public sealed partial class Unk2700_GLAPMLGHDDC_ClientReq : pb::IMessage<Unk2700_GLAPMLGHDDC_ClientReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Unk2700_GLAPMLGHDDC_ClientReq> _parser = new pb::MessageParser<Unk2700_GLAPMLGHDDC_ClientReq>(() => new Unk2700_GLAPMLGHDDC_ClientReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Unk2700_GLAPMLGHDDC_ClientReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.Unk2700GLAPMLGHDDCClientReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_GLAPMLGHDDC_ClientReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_GLAPMLGHDDC_ClientReq(Unk2700_GLAPMLGHDDC_ClientReq other) : this() {
      materialId_ = other.materialId_;
      unk2700MHEKJGAIFBO_ = other.unk2700MHEKJGAIFBO_;
      unk2700GMHLHKIIGIC_ = other.unk2700GMHLHKIIGIC_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_GLAPMLGHDDC_ClientReq Clone() {
      return new Unk2700_GLAPMLGHDDC_ClientReq(this);
    }

    /// <summary>Field number for the "material_id" field.</summary>
    public const int MaterialIdFieldNumber = 14;
    private uint materialId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MaterialId {
      get { return materialId_; }
      set {
        materialId_ = value;
      }
    }

    /// <summary>Field number for the "Unk2700_MHEKJGAIFBO" field.</summary>
    public const int Unk2700MHEKJGAIFBOFieldNumber = 10;
    private global::Weedwacker.Shared.Network.Proto.Unk2700_NOCLNCCJEGK unk2700MHEKJGAIFBO_ = global::Weedwacker.Shared.Network.Proto.Unk2700_NOCLNCCJEGK.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Unk2700_NOCLNCCJEGK Unk2700MHEKJGAIFBO {
      get { return unk2700MHEKJGAIFBO_; }
      set {
        unk2700MHEKJGAIFBO_ = value;
      }
    }

    /// <summary>Field number for the "Unk2700_GMHLHKIIGIC" field.</summary>
    public const int Unk2700GMHLHKIIGICFieldNumber = 7;
    private uint unk2700GMHLHKIIGIC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk2700GMHLHKIIGIC {
      get { return unk2700GMHLHKIIGIC_; }
      set {
        unk2700GMHLHKIIGIC_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Unk2700_GLAPMLGHDDC_ClientReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Unk2700_GLAPMLGHDDC_ClientReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MaterialId != other.MaterialId) return false;
      if (Unk2700MHEKJGAIFBO != other.Unk2700MHEKJGAIFBO) return false;
      if (Unk2700GMHLHKIIGIC != other.Unk2700GMHLHKIIGIC) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (MaterialId != 0) hash ^= MaterialId.GetHashCode();
      if (Unk2700MHEKJGAIFBO != global::Weedwacker.Shared.Network.Proto.Unk2700_NOCLNCCJEGK.None) hash ^= Unk2700MHEKJGAIFBO.GetHashCode();
      if (Unk2700GMHLHKIIGIC != 0) hash ^= Unk2700GMHLHKIIGIC.GetHashCode();
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
      if (Unk2700GMHLHKIIGIC != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Unk2700GMHLHKIIGIC);
      }
      if (Unk2700MHEKJGAIFBO != global::Weedwacker.Shared.Network.Proto.Unk2700_NOCLNCCJEGK.None) {
        output.WriteRawTag(80);
        output.WriteEnum((int) Unk2700MHEKJGAIFBO);
      }
      if (MaterialId != 0) {
        output.WriteRawTag(112);
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
      if (Unk2700GMHLHKIIGIC != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Unk2700GMHLHKIIGIC);
      }
      if (Unk2700MHEKJGAIFBO != global::Weedwacker.Shared.Network.Proto.Unk2700_NOCLNCCJEGK.None) {
        output.WriteRawTag(80);
        output.WriteEnum((int) Unk2700MHEKJGAIFBO);
      }
      if (MaterialId != 0) {
        output.WriteRawTag(112);
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
      if (MaterialId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MaterialId);
      }
      if (Unk2700MHEKJGAIFBO != global::Weedwacker.Shared.Network.Proto.Unk2700_NOCLNCCJEGK.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Unk2700MHEKJGAIFBO);
      }
      if (Unk2700GMHLHKIIGIC != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk2700GMHLHKIIGIC);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Unk2700_GLAPMLGHDDC_ClientReq other) {
      if (other == null) {
        return;
      }
      if (other.MaterialId != 0) {
        MaterialId = other.MaterialId;
      }
      if (other.Unk2700MHEKJGAIFBO != global::Weedwacker.Shared.Network.Proto.Unk2700_NOCLNCCJEGK.None) {
        Unk2700MHEKJGAIFBO = other.Unk2700MHEKJGAIFBO;
      }
      if (other.Unk2700GMHLHKIIGIC != 0) {
        Unk2700GMHLHKIIGIC = other.Unk2700GMHLHKIIGIC;
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
          case 56: {
            Unk2700GMHLHKIIGIC = input.ReadUInt32();
            break;
          }
          case 80: {
            Unk2700MHEKJGAIFBO = (global::Weedwacker.Shared.Network.Proto.Unk2700_NOCLNCCJEGK) input.ReadEnum();
            break;
          }
          case 112: {
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
          case 56: {
            Unk2700GMHLHKIIGIC = input.ReadUInt32();
            break;
          }
          case 80: {
            Unk2700MHEKJGAIFBO = (global::Weedwacker.Shared.Network.Proto.Unk2700_NOCLNCCJEGK) input.ReadEnum();
            break;
          }
          case 112: {
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