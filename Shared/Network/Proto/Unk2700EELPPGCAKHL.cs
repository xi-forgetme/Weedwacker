// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Unk2700_EELPPGCAKHL.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from Unk2700_EELPPGCAKHL.proto</summary>
  public static partial class Unk2700EELPPGCAKHLReflection {

    #region Descriptor
    /// <summary>File descriptor for Unk2700_EELPPGCAKHL.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static Unk2700EELPPGCAKHLReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlVbmsyNzAwX0VFTFBQR0NBS0hMLnByb3RvIrUCChNVbmsyNzAwX0VFTFBQ",
            "R0NBS0hMEkkKE1VuazI3MDBfQk1MQk1HR0JGSkcYDyADKAsyLC5VbmsyNzAw",
            "X0VFTFBQR0NBS0hMLlVuazI3MDBCTUxCTUdHQkZKR0VudHJ5EkkKE1VuazI3",
            "MDBfT0JGUEtGRUdHSUsYDiADKAsyLC5VbmsyNzAwX0VFTFBQR0NBS0hMLlVu",
            "azI3MDBPQkZQS0ZFR0dJS0VudHJ5EhIKCmR1bmdlb25faWQYBSABKA0aOQoX",
            "VW5rMjcwMEJNTEJNR0dCRkpHRW50cnkSCwoDa2V5GAEgASgNEg0KBXZhbHVl",
            "GAIgASgNOgI4ARo5ChdVbmsyNzAwT0JGUEtGRUdHSUtFbnRyeRILCgNrZXkY",
            "ASABKA0SDQoFdmFsdWUYAiABKA06AjgBQiKqAh9XZWVkd2Fja2VyLlNoYXJl",
            "ZC5OZXR3b3JrLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.Unk2700_EELPPGCAKHL), global::Weedwacker.Shared.Network.Proto.Unk2700_EELPPGCAKHL.Parser, new[]{ "Unk2700BMLBMGGBFJG", "Unk2700OBFPKFEGGIK", "DungeonId" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 8373
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// IsAllowClient: true
  /// </summary>
  public sealed partial class Unk2700_EELPPGCAKHL : pb::IMessage<Unk2700_EELPPGCAKHL>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Unk2700_EELPPGCAKHL> _parser = new pb::MessageParser<Unk2700_EELPPGCAKHL>(() => new Unk2700_EELPPGCAKHL());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Unk2700_EELPPGCAKHL> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.Unk2700EELPPGCAKHLReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_EELPPGCAKHL() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_EELPPGCAKHL(Unk2700_EELPPGCAKHL other) : this() {
      unk2700BMLBMGGBFJG_ = other.unk2700BMLBMGGBFJG_.Clone();
      unk2700OBFPKFEGGIK_ = other.unk2700OBFPKFEGGIK_.Clone();
      dungeonId_ = other.dungeonId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_EELPPGCAKHL Clone() {
      return new Unk2700_EELPPGCAKHL(this);
    }

    /// <summary>Field number for the "Unk2700_BMLBMGGBFJG" field.</summary>
    public const int Unk2700BMLBMGGBFJGFieldNumber = 15;
    private static readonly pbc::MapField<uint, uint>.Codec _map_unk2700BMLBMGGBFJG_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 122);
    private readonly pbc::MapField<uint, uint> unk2700BMLBMGGBFJG_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> Unk2700BMLBMGGBFJG {
      get { return unk2700BMLBMGGBFJG_; }
    }

    /// <summary>Field number for the "Unk2700_OBFPKFEGGIK" field.</summary>
    public const int Unk2700OBFPKFEGGIKFieldNumber = 14;
    private static readonly pbc::MapField<uint, uint>.Codec _map_unk2700OBFPKFEGGIK_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 114);
    private readonly pbc::MapField<uint, uint> unk2700OBFPKFEGGIK_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> Unk2700OBFPKFEGGIK {
      get { return unk2700OBFPKFEGGIK_; }
    }

    /// <summary>Field number for the "dungeon_id" field.</summary>
    public const int DungeonIdFieldNumber = 5;
    private uint dungeonId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DungeonId {
      get { return dungeonId_; }
      set {
        dungeonId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Unk2700_EELPPGCAKHL);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Unk2700_EELPPGCAKHL other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!Unk2700BMLBMGGBFJG.Equals(other.Unk2700BMLBMGGBFJG)) return false;
      if (!Unk2700OBFPKFEGGIK.Equals(other.Unk2700OBFPKFEGGIK)) return false;
      if (DungeonId != other.DungeonId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= Unk2700BMLBMGGBFJG.GetHashCode();
      hash ^= Unk2700OBFPKFEGGIK.GetHashCode();
      if (DungeonId != 0) hash ^= DungeonId.GetHashCode();
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
      if (DungeonId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(DungeonId);
      }
      unk2700OBFPKFEGGIK_.WriteTo(output, _map_unk2700OBFPKFEGGIK_codec);
      unk2700BMLBMGGBFJG_.WriteTo(output, _map_unk2700BMLBMGGBFJG_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (DungeonId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(DungeonId);
      }
      unk2700OBFPKFEGGIK_.WriteTo(ref output, _map_unk2700OBFPKFEGGIK_codec);
      unk2700BMLBMGGBFJG_.WriteTo(ref output, _map_unk2700BMLBMGGBFJG_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += unk2700BMLBMGGBFJG_.CalculateSize(_map_unk2700BMLBMGGBFJG_codec);
      size += unk2700OBFPKFEGGIK_.CalculateSize(_map_unk2700OBFPKFEGGIK_codec);
      if (DungeonId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DungeonId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Unk2700_EELPPGCAKHL other) {
      if (other == null) {
        return;
      }
      unk2700BMLBMGGBFJG_.Add(other.unk2700BMLBMGGBFJG_);
      unk2700OBFPKFEGGIK_.Add(other.unk2700OBFPKFEGGIK_);
      if (other.DungeonId != 0) {
        DungeonId = other.DungeonId;
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
            DungeonId = input.ReadUInt32();
            break;
          }
          case 114: {
            unk2700OBFPKFEGGIK_.AddEntriesFrom(input, _map_unk2700OBFPKFEGGIK_codec);
            break;
          }
          case 122: {
            unk2700BMLBMGGBFJG_.AddEntriesFrom(input, _map_unk2700BMLBMGGBFJG_codec);
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
            DungeonId = input.ReadUInt32();
            break;
          }
          case 114: {
            unk2700OBFPKFEGGIK_.AddEntriesFrom(ref input, _map_unk2700OBFPKFEGGIK_codec);
            break;
          }
          case 122: {
            unk2700BMLBMGGBFJG_.AddEntriesFrom(ref input, _map_unk2700BMLBMGGBFJG_codec);
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