// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Unk2800_IGKGDAGGCEC.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from Unk2800_IGKGDAGGCEC.proto</summary>
  public static partial class Unk2800IGKGDAGGCECReflection {

    #region Descriptor
    /// <summary>File descriptor for Unk2800_IGKGDAGGCEC.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static Unk2800IGKGDAGGCECReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlVbmsyODAwX0lHS0dEQUdHQ0VDLnByb3RvIk0KE1VuazI4MDBfSUdLR0RB",
            "R0dDRUMSFwoPY3VyX2F2YXRhcl9ndWlkGAggASgEEh0KFWF2YXRhcl90ZWFt",
            "X2d1aWRfbGlzdBgDIAMoBEIiqgIfV2VlZHdhY2tlci5TaGFyZWQuTmV0d29y",
            "ay5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.Unk2800_IGKGDAGGCEC), global::Weedwacker.Shared.Network.Proto.Unk2800_IGKGDAGGCEC.Parser, new[]{ "CurAvatarGuid", "AvatarTeamGuidList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 1684
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// IsAllowClient: true
  /// </summary>
  public sealed partial class Unk2800_IGKGDAGGCEC : pb::IMessage<Unk2800_IGKGDAGGCEC>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Unk2800_IGKGDAGGCEC> _parser = new pb::MessageParser<Unk2800_IGKGDAGGCEC>(() => new Unk2800_IGKGDAGGCEC());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Unk2800_IGKGDAGGCEC> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.Unk2800IGKGDAGGCECReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2800_IGKGDAGGCEC() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2800_IGKGDAGGCEC(Unk2800_IGKGDAGGCEC other) : this() {
      curAvatarGuid_ = other.curAvatarGuid_;
      avatarTeamGuidList_ = other.avatarTeamGuidList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2800_IGKGDAGGCEC Clone() {
      return new Unk2800_IGKGDAGGCEC(this);
    }

    /// <summary>Field number for the "cur_avatar_guid" field.</summary>
    public const int CurAvatarGuidFieldNumber = 8;
    private ulong curAvatarGuid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong CurAvatarGuid {
      get { return curAvatarGuid_; }
      set {
        curAvatarGuid_ = value;
      }
    }

    /// <summary>Field number for the "avatar_team_guid_list" field.</summary>
    public const int AvatarTeamGuidListFieldNumber = 3;
    private static readonly pb::FieldCodec<ulong> _repeated_avatarTeamGuidList_codec
        = pb::FieldCodec.ForUInt64(26);
    private readonly pbc::RepeatedField<ulong> avatarTeamGuidList_ = new pbc::RepeatedField<ulong>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<ulong> AvatarTeamGuidList {
      get { return avatarTeamGuidList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Unk2800_IGKGDAGGCEC);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Unk2800_IGKGDAGGCEC other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CurAvatarGuid != other.CurAvatarGuid) return false;
      if(!avatarTeamGuidList_.Equals(other.avatarTeamGuidList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CurAvatarGuid != 0UL) hash ^= CurAvatarGuid.GetHashCode();
      hash ^= avatarTeamGuidList_.GetHashCode();
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
      avatarTeamGuidList_.WriteTo(output, _repeated_avatarTeamGuidList_codec);
      if (CurAvatarGuid != 0UL) {
        output.WriteRawTag(64);
        output.WriteUInt64(CurAvatarGuid);
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
      avatarTeamGuidList_.WriteTo(ref output, _repeated_avatarTeamGuidList_codec);
      if (CurAvatarGuid != 0UL) {
        output.WriteRawTag(64);
        output.WriteUInt64(CurAvatarGuid);
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
      if (CurAvatarGuid != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(CurAvatarGuid);
      }
      size += avatarTeamGuidList_.CalculateSize(_repeated_avatarTeamGuidList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Unk2800_IGKGDAGGCEC other) {
      if (other == null) {
        return;
      }
      if (other.CurAvatarGuid != 0UL) {
        CurAvatarGuid = other.CurAvatarGuid;
      }
      avatarTeamGuidList_.Add(other.avatarTeamGuidList_);
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
          case 26:
          case 24: {
            avatarTeamGuidList_.AddEntriesFrom(input, _repeated_avatarTeamGuidList_codec);
            break;
          }
          case 64: {
            CurAvatarGuid = input.ReadUInt64();
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
          case 26:
          case 24: {
            avatarTeamGuidList_.AddEntriesFrom(ref input, _repeated_avatarTeamGuidList_codec);
            break;
          }
          case 64: {
            CurAvatarGuid = input.ReadUInt64();
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