// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Unk2700_PHGGAEDHLBN.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from Unk2700_PHGGAEDHLBN.proto</summary>
  public static partial class Unk2700PHGGAEDHLBNReflection {

    #region Descriptor
    /// <summary>File descriptor for Unk2700_PHGGAEDHLBN.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static Unk2700PHGGAEDHLBNReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlVbmsyNzAwX1BIR0dBRURITEJOLnByb3RvIuABChNVbmsyNzAwX1BIR0dB",
            "RURITEJOEhsKE1VuazI3MDBfQU5ISkFGREVBQ0YYASADKA0SGwoTVW5rMjcw",
            "MF9JQkRDRkFNQkdPSxgOIAEoCBIbChNVbmsyNzAwX0tFTkdFR0pHQUVMGAYg",
            "ASgNEhsKE1VuazI3MDBfRE9JTU1CSkRBTEIYBCABKA0SGwoTVW5rMjcwMF9G",
            "S0xCQ05MQkJOTRgDIAEoCBIbChNVbmsyNzAwX0lGTkZDTk5CUElCGAogASgN",
            "EhsKE1VuazI3MDBfUEJCUEdGTU5NTkoYCSABKA1CIqoCH1dlZWR3YWNrZXIu",
            "U2hhcmVkLk5ldHdvcmsuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.Unk2700_PHGGAEDHLBN), global::Weedwacker.Shared.Network.Proto.Unk2700_PHGGAEDHLBN.Parser, new[]{ "Unk2700ANHJAFDEACF", "Unk2700IBDCFAMBGOK", "Unk2700KENGEGJGAEL", "Unk2700DOIMMBJDALB", "Unk2700FKLBCNLBBNM", "Unk2700IFNFCNNBPIB", "Unk2700PBBPGFMNMNJ" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Unk2700_PHGGAEDHLBN : pb::IMessage<Unk2700_PHGGAEDHLBN>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Unk2700_PHGGAEDHLBN> _parser = new pb::MessageParser<Unk2700_PHGGAEDHLBN>(() => new Unk2700_PHGGAEDHLBN());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Unk2700_PHGGAEDHLBN> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.Unk2700PHGGAEDHLBNReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_PHGGAEDHLBN() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_PHGGAEDHLBN(Unk2700_PHGGAEDHLBN other) : this() {
      unk2700ANHJAFDEACF_ = other.unk2700ANHJAFDEACF_.Clone();
      unk2700IBDCFAMBGOK_ = other.unk2700IBDCFAMBGOK_;
      unk2700KENGEGJGAEL_ = other.unk2700KENGEGJGAEL_;
      unk2700DOIMMBJDALB_ = other.unk2700DOIMMBJDALB_;
      unk2700FKLBCNLBBNM_ = other.unk2700FKLBCNLBBNM_;
      unk2700IFNFCNNBPIB_ = other.unk2700IFNFCNNBPIB_;
      unk2700PBBPGFMNMNJ_ = other.unk2700PBBPGFMNMNJ_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_PHGGAEDHLBN Clone() {
      return new Unk2700_PHGGAEDHLBN(this);
    }

    /// <summary>Field number for the "Unk2700_ANHJAFDEACF" field.</summary>
    public const int Unk2700ANHJAFDEACFFieldNumber = 1;
    private static readonly pb::FieldCodec<uint> _repeated_unk2700ANHJAFDEACF_codec
        = pb::FieldCodec.ForUInt32(10);
    private readonly pbc::RepeatedField<uint> unk2700ANHJAFDEACF_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> Unk2700ANHJAFDEACF {
      get { return unk2700ANHJAFDEACF_; }
    }

    /// <summary>Field number for the "Unk2700_IBDCFAMBGOK" field.</summary>
    public const int Unk2700IBDCFAMBGOKFieldNumber = 14;
    private bool unk2700IBDCFAMBGOK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk2700IBDCFAMBGOK {
      get { return unk2700IBDCFAMBGOK_; }
      set {
        unk2700IBDCFAMBGOK_ = value;
      }
    }

    /// <summary>Field number for the "Unk2700_KENGEGJGAEL" field.</summary>
    public const int Unk2700KENGEGJGAELFieldNumber = 6;
    private uint unk2700KENGEGJGAEL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk2700KENGEGJGAEL {
      get { return unk2700KENGEGJGAEL_; }
      set {
        unk2700KENGEGJGAEL_ = value;
      }
    }

    /// <summary>Field number for the "Unk2700_DOIMMBJDALB" field.</summary>
    public const int Unk2700DOIMMBJDALBFieldNumber = 4;
    private uint unk2700DOIMMBJDALB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk2700DOIMMBJDALB {
      get { return unk2700DOIMMBJDALB_; }
      set {
        unk2700DOIMMBJDALB_ = value;
      }
    }

    /// <summary>Field number for the "Unk2700_FKLBCNLBBNM" field.</summary>
    public const int Unk2700FKLBCNLBBNMFieldNumber = 3;
    private bool unk2700FKLBCNLBBNM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk2700FKLBCNLBBNM {
      get { return unk2700FKLBCNLBBNM_; }
      set {
        unk2700FKLBCNLBBNM_ = value;
      }
    }

    /// <summary>Field number for the "Unk2700_IFNFCNNBPIB" field.</summary>
    public const int Unk2700IFNFCNNBPIBFieldNumber = 10;
    private uint unk2700IFNFCNNBPIB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk2700IFNFCNNBPIB {
      get { return unk2700IFNFCNNBPIB_; }
      set {
        unk2700IFNFCNNBPIB_ = value;
      }
    }

    /// <summary>Field number for the "Unk2700_PBBPGFMNMNJ" field.</summary>
    public const int Unk2700PBBPGFMNMNJFieldNumber = 9;
    private uint unk2700PBBPGFMNMNJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk2700PBBPGFMNMNJ {
      get { return unk2700PBBPGFMNMNJ_; }
      set {
        unk2700PBBPGFMNMNJ_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Unk2700_PHGGAEDHLBN);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Unk2700_PHGGAEDHLBN other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!unk2700ANHJAFDEACF_.Equals(other.unk2700ANHJAFDEACF_)) return false;
      if (Unk2700IBDCFAMBGOK != other.Unk2700IBDCFAMBGOK) return false;
      if (Unk2700KENGEGJGAEL != other.Unk2700KENGEGJGAEL) return false;
      if (Unk2700DOIMMBJDALB != other.Unk2700DOIMMBJDALB) return false;
      if (Unk2700FKLBCNLBBNM != other.Unk2700FKLBCNLBBNM) return false;
      if (Unk2700IFNFCNNBPIB != other.Unk2700IFNFCNNBPIB) return false;
      if (Unk2700PBBPGFMNMNJ != other.Unk2700PBBPGFMNMNJ) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= unk2700ANHJAFDEACF_.GetHashCode();
      if (Unk2700IBDCFAMBGOK != false) hash ^= Unk2700IBDCFAMBGOK.GetHashCode();
      if (Unk2700KENGEGJGAEL != 0) hash ^= Unk2700KENGEGJGAEL.GetHashCode();
      if (Unk2700DOIMMBJDALB != 0) hash ^= Unk2700DOIMMBJDALB.GetHashCode();
      if (Unk2700FKLBCNLBBNM != false) hash ^= Unk2700FKLBCNLBBNM.GetHashCode();
      if (Unk2700IFNFCNNBPIB != 0) hash ^= Unk2700IFNFCNNBPIB.GetHashCode();
      if (Unk2700PBBPGFMNMNJ != 0) hash ^= Unk2700PBBPGFMNMNJ.GetHashCode();
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
      unk2700ANHJAFDEACF_.WriteTo(output, _repeated_unk2700ANHJAFDEACF_codec);
      if (Unk2700FKLBCNLBBNM != false) {
        output.WriteRawTag(24);
        output.WriteBool(Unk2700FKLBCNLBBNM);
      }
      if (Unk2700DOIMMBJDALB != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Unk2700DOIMMBJDALB);
      }
      if (Unk2700KENGEGJGAEL != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Unk2700KENGEGJGAEL);
      }
      if (Unk2700PBBPGFMNMNJ != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Unk2700PBBPGFMNMNJ);
      }
      if (Unk2700IFNFCNNBPIB != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Unk2700IFNFCNNBPIB);
      }
      if (Unk2700IBDCFAMBGOK != false) {
        output.WriteRawTag(112);
        output.WriteBool(Unk2700IBDCFAMBGOK);
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
      unk2700ANHJAFDEACF_.WriteTo(ref output, _repeated_unk2700ANHJAFDEACF_codec);
      if (Unk2700FKLBCNLBBNM != false) {
        output.WriteRawTag(24);
        output.WriteBool(Unk2700FKLBCNLBBNM);
      }
      if (Unk2700DOIMMBJDALB != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Unk2700DOIMMBJDALB);
      }
      if (Unk2700KENGEGJGAEL != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Unk2700KENGEGJGAEL);
      }
      if (Unk2700PBBPGFMNMNJ != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Unk2700PBBPGFMNMNJ);
      }
      if (Unk2700IFNFCNNBPIB != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Unk2700IFNFCNNBPIB);
      }
      if (Unk2700IBDCFAMBGOK != false) {
        output.WriteRawTag(112);
        output.WriteBool(Unk2700IBDCFAMBGOK);
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
      size += unk2700ANHJAFDEACF_.CalculateSize(_repeated_unk2700ANHJAFDEACF_codec);
      if (Unk2700IBDCFAMBGOK != false) {
        size += 1 + 1;
      }
      if (Unk2700KENGEGJGAEL != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk2700KENGEGJGAEL);
      }
      if (Unk2700DOIMMBJDALB != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk2700DOIMMBJDALB);
      }
      if (Unk2700FKLBCNLBBNM != false) {
        size += 1 + 1;
      }
      if (Unk2700IFNFCNNBPIB != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk2700IFNFCNNBPIB);
      }
      if (Unk2700PBBPGFMNMNJ != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk2700PBBPGFMNMNJ);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Unk2700_PHGGAEDHLBN other) {
      if (other == null) {
        return;
      }
      unk2700ANHJAFDEACF_.Add(other.unk2700ANHJAFDEACF_);
      if (other.Unk2700IBDCFAMBGOK != false) {
        Unk2700IBDCFAMBGOK = other.Unk2700IBDCFAMBGOK;
      }
      if (other.Unk2700KENGEGJGAEL != 0) {
        Unk2700KENGEGJGAEL = other.Unk2700KENGEGJGAEL;
      }
      if (other.Unk2700DOIMMBJDALB != 0) {
        Unk2700DOIMMBJDALB = other.Unk2700DOIMMBJDALB;
      }
      if (other.Unk2700FKLBCNLBBNM != false) {
        Unk2700FKLBCNLBBNM = other.Unk2700FKLBCNLBBNM;
      }
      if (other.Unk2700IFNFCNNBPIB != 0) {
        Unk2700IFNFCNNBPIB = other.Unk2700IFNFCNNBPIB;
      }
      if (other.Unk2700PBBPGFMNMNJ != 0) {
        Unk2700PBBPGFMNMNJ = other.Unk2700PBBPGFMNMNJ;
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
          case 10:
          case 8: {
            unk2700ANHJAFDEACF_.AddEntriesFrom(input, _repeated_unk2700ANHJAFDEACF_codec);
            break;
          }
          case 24: {
            Unk2700FKLBCNLBBNM = input.ReadBool();
            break;
          }
          case 32: {
            Unk2700DOIMMBJDALB = input.ReadUInt32();
            break;
          }
          case 48: {
            Unk2700KENGEGJGAEL = input.ReadUInt32();
            break;
          }
          case 72: {
            Unk2700PBBPGFMNMNJ = input.ReadUInt32();
            break;
          }
          case 80: {
            Unk2700IFNFCNNBPIB = input.ReadUInt32();
            break;
          }
          case 112: {
            Unk2700IBDCFAMBGOK = input.ReadBool();
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
          case 10:
          case 8: {
            unk2700ANHJAFDEACF_.AddEntriesFrom(ref input, _repeated_unk2700ANHJAFDEACF_codec);
            break;
          }
          case 24: {
            Unk2700FKLBCNLBBNM = input.ReadBool();
            break;
          }
          case 32: {
            Unk2700DOIMMBJDALB = input.ReadUInt32();
            break;
          }
          case 48: {
            Unk2700KENGEGJGAEL = input.ReadUInt32();
            break;
          }
          case 72: {
            Unk2700PBBPGFMNMNJ = input.ReadUInt32();
            break;
          }
          case 80: {
            Unk2700IFNFCNNBPIB = input.ReadUInt32();
            break;
          }
          case 112: {
            Unk2700IBDCFAMBGOK = input.ReadBool();
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