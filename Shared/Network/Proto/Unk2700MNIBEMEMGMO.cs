// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Unk2700_MNIBEMEMGMO.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from Unk2700_MNIBEMEMGMO.proto</summary>
  public static partial class Unk2700MNIBEMEMGMOReflection {

    #region Descriptor
    /// <summary>File descriptor for Unk2700_MNIBEMEMGMO.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static Unk2700MNIBEMEMGMOReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlVbmsyNzAwX01OSUJFTUVNR01PLnByb3RvGhlVbmsyNzAwX0hKTEZOS0xQ",
            "RkJILnByb3RvIp8BChNVbmsyNzAwX01OSUJFTUVNR01PEjEKE1VuazI3MDBf",
            "Qk5ITkNQUEFEUEoYCiADKAsyFC5VbmsyNzAwX0hKTEZOS0xQRkJIEhsKE1Vu",
            "azI3MDBfS0dNRkRDT01DT0YYBiABKA0SGwoTVW5rMjcwMF9NTE1KQUJHTERQ",
            "SBgIIAEoDRIbChNVbmsyNzAwX05ITUpLQkdFSElEGAcgASgIQiKqAh9XZWVk",
            "d2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.Unk2700HJLFNKLPFBHReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.Unk2700_MNIBEMEMGMO), global::Weedwacker.Shared.Network.Proto.Unk2700_MNIBEMEMGMO.Parser, new[]{ "Unk2700BNHNCPPADPJ", "Unk2700KGMFDCOMCOF", "Unk2700MLMJABGLDPH", "Unk2700NHMJKBGEHID" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 8514
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// IsAllowClient: true
  /// </summary>
  public sealed partial class Unk2700_MNIBEMEMGMO : pb::IMessage<Unk2700_MNIBEMEMGMO>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Unk2700_MNIBEMEMGMO> _parser = new pb::MessageParser<Unk2700_MNIBEMEMGMO>(() => new Unk2700_MNIBEMEMGMO());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Unk2700_MNIBEMEMGMO> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.Unk2700MNIBEMEMGMOReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_MNIBEMEMGMO() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_MNIBEMEMGMO(Unk2700_MNIBEMEMGMO other) : this() {
      unk2700BNHNCPPADPJ_ = other.unk2700BNHNCPPADPJ_.Clone();
      unk2700KGMFDCOMCOF_ = other.unk2700KGMFDCOMCOF_;
      unk2700MLMJABGLDPH_ = other.unk2700MLMJABGLDPH_;
      unk2700NHMJKBGEHID_ = other.unk2700NHMJKBGEHID_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_MNIBEMEMGMO Clone() {
      return new Unk2700_MNIBEMEMGMO(this);
    }

    /// <summary>Field number for the "Unk2700_BNHNCPPADPJ" field.</summary>
    public const int Unk2700BNHNCPPADPJFieldNumber = 10;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.Unk2700_HJLFNKLPFBH> _repeated_unk2700BNHNCPPADPJ_codec
        = pb::FieldCodec.ForMessage(82, global::Weedwacker.Shared.Network.Proto.Unk2700_HJLFNKLPFBH.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.Unk2700_HJLFNKLPFBH> unk2700BNHNCPPADPJ_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.Unk2700_HJLFNKLPFBH>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.Unk2700_HJLFNKLPFBH> Unk2700BNHNCPPADPJ {
      get { return unk2700BNHNCPPADPJ_; }
    }

    /// <summary>Field number for the "Unk2700_KGMFDCOMCOF" field.</summary>
    public const int Unk2700KGMFDCOMCOFFieldNumber = 6;
    private uint unk2700KGMFDCOMCOF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk2700KGMFDCOMCOF {
      get { return unk2700KGMFDCOMCOF_; }
      set {
        unk2700KGMFDCOMCOF_ = value;
      }
    }

    /// <summary>Field number for the "Unk2700_MLMJABGLDPH" field.</summary>
    public const int Unk2700MLMJABGLDPHFieldNumber = 8;
    private uint unk2700MLMJABGLDPH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk2700MLMJABGLDPH {
      get { return unk2700MLMJABGLDPH_; }
      set {
        unk2700MLMJABGLDPH_ = value;
      }
    }

    /// <summary>Field number for the "Unk2700_NHMJKBGEHID" field.</summary>
    public const int Unk2700NHMJKBGEHIDFieldNumber = 7;
    private bool unk2700NHMJKBGEHID_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk2700NHMJKBGEHID {
      get { return unk2700NHMJKBGEHID_; }
      set {
        unk2700NHMJKBGEHID_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Unk2700_MNIBEMEMGMO);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Unk2700_MNIBEMEMGMO other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!unk2700BNHNCPPADPJ_.Equals(other.unk2700BNHNCPPADPJ_)) return false;
      if (Unk2700KGMFDCOMCOF != other.Unk2700KGMFDCOMCOF) return false;
      if (Unk2700MLMJABGLDPH != other.Unk2700MLMJABGLDPH) return false;
      if (Unk2700NHMJKBGEHID != other.Unk2700NHMJKBGEHID) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= unk2700BNHNCPPADPJ_.GetHashCode();
      if (Unk2700KGMFDCOMCOF != 0) hash ^= Unk2700KGMFDCOMCOF.GetHashCode();
      if (Unk2700MLMJABGLDPH != 0) hash ^= Unk2700MLMJABGLDPH.GetHashCode();
      if (Unk2700NHMJKBGEHID != false) hash ^= Unk2700NHMJKBGEHID.GetHashCode();
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
      if (Unk2700KGMFDCOMCOF != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Unk2700KGMFDCOMCOF);
      }
      if (Unk2700NHMJKBGEHID != false) {
        output.WriteRawTag(56);
        output.WriteBool(Unk2700NHMJKBGEHID);
      }
      if (Unk2700MLMJABGLDPH != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Unk2700MLMJABGLDPH);
      }
      unk2700BNHNCPPADPJ_.WriteTo(output, _repeated_unk2700BNHNCPPADPJ_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Unk2700KGMFDCOMCOF != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Unk2700KGMFDCOMCOF);
      }
      if (Unk2700NHMJKBGEHID != false) {
        output.WriteRawTag(56);
        output.WriteBool(Unk2700NHMJKBGEHID);
      }
      if (Unk2700MLMJABGLDPH != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Unk2700MLMJABGLDPH);
      }
      unk2700BNHNCPPADPJ_.WriteTo(ref output, _repeated_unk2700BNHNCPPADPJ_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += unk2700BNHNCPPADPJ_.CalculateSize(_repeated_unk2700BNHNCPPADPJ_codec);
      if (Unk2700KGMFDCOMCOF != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk2700KGMFDCOMCOF);
      }
      if (Unk2700MLMJABGLDPH != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk2700MLMJABGLDPH);
      }
      if (Unk2700NHMJKBGEHID != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Unk2700_MNIBEMEMGMO other) {
      if (other == null) {
        return;
      }
      unk2700BNHNCPPADPJ_.Add(other.unk2700BNHNCPPADPJ_);
      if (other.Unk2700KGMFDCOMCOF != 0) {
        Unk2700KGMFDCOMCOF = other.Unk2700KGMFDCOMCOF;
      }
      if (other.Unk2700MLMJABGLDPH != 0) {
        Unk2700MLMJABGLDPH = other.Unk2700MLMJABGLDPH;
      }
      if (other.Unk2700NHMJKBGEHID != false) {
        Unk2700NHMJKBGEHID = other.Unk2700NHMJKBGEHID;
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
          case 48: {
            Unk2700KGMFDCOMCOF = input.ReadUInt32();
            break;
          }
          case 56: {
            Unk2700NHMJKBGEHID = input.ReadBool();
            break;
          }
          case 64: {
            Unk2700MLMJABGLDPH = input.ReadUInt32();
            break;
          }
          case 82: {
            unk2700BNHNCPPADPJ_.AddEntriesFrom(input, _repeated_unk2700BNHNCPPADPJ_codec);
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
          case 48: {
            Unk2700KGMFDCOMCOF = input.ReadUInt32();
            break;
          }
          case 56: {
            Unk2700NHMJKBGEHID = input.ReadBool();
            break;
          }
          case 64: {
            Unk2700MLMJABGLDPH = input.ReadUInt32();
            break;
          }
          case 82: {
            unk2700BNHNCPPADPJ_.AddEntriesFrom(ref input, _repeated_unk2700BNHNCPPADPJ_codec);
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