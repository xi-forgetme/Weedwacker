// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Unk2700_HLHHNGHJLAO.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from Unk2700_HLHHNGHJLAO.proto</summary>
  public static partial class Unk2700HLHHNGHJLAOReflection {

    #region Descriptor
    /// <summary>File descriptor for Unk2700_HLHHNGHJLAO.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static Unk2700HLHHNGHJLAOReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlVbmsyNzAwX0hMSEhOR0hKTEFPLnByb3RvGhlVbmsyNzAwX01PRkFCUE5H",
            "SUtQLnByb3RvIsEBChNVbmsyNzAwX0hMSEhOR0hKTEFPEhoKEmtpbGxfbW9u",
            "c3Rlcl9jb3VudBgMIAEoDRIiChpraWxsX3NwZWNpYWxfbW9uc3Rlcl9jb3Vu",
            "dBgIIAEoDRIbChNVbmsyNzAwX09GS0hMR0xPUENNGAogASgNEhIKCmdhbGxl",
            "cnlfaWQYAiABKA0SJAoGcmVhc29uGAsgASgOMhQuVW5rMjcwMF9NT0ZBQlBO",
            "R0lLUBITCgtmaW5hbF9zY29yZRgNIAEoDUIiqgIfV2VlZHdhY2tlci5TaGFy",
            "ZWQuTmV0d29yay5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.Unk2700MOFABPNGIKPReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.Unk2700_HLHHNGHJLAO), global::Weedwacker.Shared.Network.Proto.Unk2700_HLHHNGHJLAO.Parser, new[]{ "KillMonsterCount", "KillSpecialMonsterCount", "Unk2700OFKHLGLOPCM", "GalleryId", "Reason", "FinalScore" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Unk2700_HLHHNGHJLAO : pb::IMessage<Unk2700_HLHHNGHJLAO>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Unk2700_HLHHNGHJLAO> _parser = new pb::MessageParser<Unk2700_HLHHNGHJLAO>(() => new Unk2700_HLHHNGHJLAO());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Unk2700_HLHHNGHJLAO> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.Unk2700HLHHNGHJLAOReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_HLHHNGHJLAO() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_HLHHNGHJLAO(Unk2700_HLHHNGHJLAO other) : this() {
      killMonsterCount_ = other.killMonsterCount_;
      killSpecialMonsterCount_ = other.killSpecialMonsterCount_;
      unk2700OFKHLGLOPCM_ = other.unk2700OFKHLGLOPCM_;
      galleryId_ = other.galleryId_;
      reason_ = other.reason_;
      finalScore_ = other.finalScore_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_HLHHNGHJLAO Clone() {
      return new Unk2700_HLHHNGHJLAO(this);
    }

    /// <summary>Field number for the "kill_monster_count" field.</summary>
    public const int KillMonsterCountFieldNumber = 12;
    private uint killMonsterCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint KillMonsterCount {
      get { return killMonsterCount_; }
      set {
        killMonsterCount_ = value;
      }
    }

    /// <summary>Field number for the "kill_special_monster_count" field.</summary>
    public const int KillSpecialMonsterCountFieldNumber = 8;
    private uint killSpecialMonsterCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint KillSpecialMonsterCount {
      get { return killSpecialMonsterCount_; }
      set {
        killSpecialMonsterCount_ = value;
      }
    }

    /// <summary>Field number for the "Unk2700_OFKHLGLOPCM" field.</summary>
    public const int Unk2700OFKHLGLOPCMFieldNumber = 10;
    private uint unk2700OFKHLGLOPCM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk2700OFKHLGLOPCM {
      get { return unk2700OFKHLGLOPCM_; }
      set {
        unk2700OFKHLGLOPCM_ = value;
      }
    }

    /// <summary>Field number for the "gallery_id" field.</summary>
    public const int GalleryIdFieldNumber = 2;
    private uint galleryId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GalleryId {
      get { return galleryId_; }
      set {
        galleryId_ = value;
      }
    }

    /// <summary>Field number for the "reason" field.</summary>
    public const int ReasonFieldNumber = 11;
    private global::Weedwacker.Shared.Network.Proto.Unk2700_MOFABPNGIKP reason_ = global::Weedwacker.Shared.Network.Proto.Unk2700_MOFABPNGIKP.Unk2700Dgjfkkiblcj;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Unk2700_MOFABPNGIKP Reason {
      get { return reason_; }
      set {
        reason_ = value;
      }
    }

    /// <summary>Field number for the "final_score" field.</summary>
    public const int FinalScoreFieldNumber = 13;
    private uint finalScore_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FinalScore {
      get { return finalScore_; }
      set {
        finalScore_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Unk2700_HLHHNGHJLAO);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Unk2700_HLHHNGHJLAO other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (KillMonsterCount != other.KillMonsterCount) return false;
      if (KillSpecialMonsterCount != other.KillSpecialMonsterCount) return false;
      if (Unk2700OFKHLGLOPCM != other.Unk2700OFKHLGLOPCM) return false;
      if (GalleryId != other.GalleryId) return false;
      if (Reason != other.Reason) return false;
      if (FinalScore != other.FinalScore) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (KillMonsterCount != 0) hash ^= KillMonsterCount.GetHashCode();
      if (KillSpecialMonsterCount != 0) hash ^= KillSpecialMonsterCount.GetHashCode();
      if (Unk2700OFKHLGLOPCM != 0) hash ^= Unk2700OFKHLGLOPCM.GetHashCode();
      if (GalleryId != 0) hash ^= GalleryId.GetHashCode();
      if (Reason != global::Weedwacker.Shared.Network.Proto.Unk2700_MOFABPNGIKP.Unk2700Dgjfkkiblcj) hash ^= Reason.GetHashCode();
      if (FinalScore != 0) hash ^= FinalScore.GetHashCode();
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
      if (GalleryId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(GalleryId);
      }
      if (KillSpecialMonsterCount != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(KillSpecialMonsterCount);
      }
      if (Unk2700OFKHLGLOPCM != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Unk2700OFKHLGLOPCM);
      }
      if (Reason != global::Weedwacker.Shared.Network.Proto.Unk2700_MOFABPNGIKP.Unk2700Dgjfkkiblcj) {
        output.WriteRawTag(88);
        output.WriteEnum((int) Reason);
      }
      if (KillMonsterCount != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(KillMonsterCount);
      }
      if (FinalScore != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(FinalScore);
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
      if (GalleryId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(GalleryId);
      }
      if (KillSpecialMonsterCount != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(KillSpecialMonsterCount);
      }
      if (Unk2700OFKHLGLOPCM != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Unk2700OFKHLGLOPCM);
      }
      if (Reason != global::Weedwacker.Shared.Network.Proto.Unk2700_MOFABPNGIKP.Unk2700Dgjfkkiblcj) {
        output.WriteRawTag(88);
        output.WriteEnum((int) Reason);
      }
      if (KillMonsterCount != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(KillMonsterCount);
      }
      if (FinalScore != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(FinalScore);
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
      if (KillMonsterCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KillMonsterCount);
      }
      if (KillSpecialMonsterCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KillSpecialMonsterCount);
      }
      if (Unk2700OFKHLGLOPCM != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk2700OFKHLGLOPCM);
      }
      if (GalleryId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GalleryId);
      }
      if (Reason != global::Weedwacker.Shared.Network.Proto.Unk2700_MOFABPNGIKP.Unk2700Dgjfkkiblcj) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Reason);
      }
      if (FinalScore != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FinalScore);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Unk2700_HLHHNGHJLAO other) {
      if (other == null) {
        return;
      }
      if (other.KillMonsterCount != 0) {
        KillMonsterCount = other.KillMonsterCount;
      }
      if (other.KillSpecialMonsterCount != 0) {
        KillSpecialMonsterCount = other.KillSpecialMonsterCount;
      }
      if (other.Unk2700OFKHLGLOPCM != 0) {
        Unk2700OFKHLGLOPCM = other.Unk2700OFKHLGLOPCM;
      }
      if (other.GalleryId != 0) {
        GalleryId = other.GalleryId;
      }
      if (other.Reason != global::Weedwacker.Shared.Network.Proto.Unk2700_MOFABPNGIKP.Unk2700Dgjfkkiblcj) {
        Reason = other.Reason;
      }
      if (other.FinalScore != 0) {
        FinalScore = other.FinalScore;
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
          case 16: {
            GalleryId = input.ReadUInt32();
            break;
          }
          case 64: {
            KillSpecialMonsterCount = input.ReadUInt32();
            break;
          }
          case 80: {
            Unk2700OFKHLGLOPCM = input.ReadUInt32();
            break;
          }
          case 88: {
            Reason = (global::Weedwacker.Shared.Network.Proto.Unk2700_MOFABPNGIKP) input.ReadEnum();
            break;
          }
          case 96: {
            KillMonsterCount = input.ReadUInt32();
            break;
          }
          case 104: {
            FinalScore = input.ReadUInt32();
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
          case 16: {
            GalleryId = input.ReadUInt32();
            break;
          }
          case 64: {
            KillSpecialMonsterCount = input.ReadUInt32();
            break;
          }
          case 80: {
            Unk2700OFKHLGLOPCM = input.ReadUInt32();
            break;
          }
          case 88: {
            Reason = (global::Weedwacker.Shared.Network.Proto.Unk2700_MOFABPNGIKP) input.ReadEnum();
            break;
          }
          case 96: {
            KillMonsterCount = input.ReadUInt32();
            break;
          }
          case 104: {
            FinalScore = input.ReadUInt32();
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