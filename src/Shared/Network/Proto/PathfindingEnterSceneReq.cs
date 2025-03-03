// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PathfindingEnterSceneReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from PathfindingEnterSceneReq.proto</summary>
  public static partial class PathfindingEnterSceneReqReflection {

    #region Descriptor
    /// <summary>File descriptor for PathfindingEnterSceneReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PathfindingEnterSceneReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5QYXRoZmluZGluZ0VudGVyU2NlbmVSZXEucHJvdG8aEk9ic3RhY2xlSW5m",
            "by5wcm90byKzAQoYUGF0aGZpbmRpbmdFbnRlclNjZW5lUmVxEhAKCHNjZW5l",
            "X2lkGAwgASgNEhMKC2FjdGl2aXR5X2lkGA4gAygNEhYKDnNjZW5lX3RhZ19o",
            "YXNoGA8gASgNEg8KB3ZlcnNpb24YBiABKA0SEQoJaXNfZWRpdG9yGAsgASgI",
            "EiAKCW9ic3RhY2xlcxgNIAMoCzINLk9ic3RhY2xlSW5mbxISCgpwb2x5Z29u",
            "X2lkGAQgASgNQiKqAh9XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3Rv",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.ObstacleInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.PathfindingEnterSceneReq), global::Weedwacker.Shared.Network.Proto.PathfindingEnterSceneReq.Parser, new[]{ "SceneId", "ActivityId", "SceneTagHash", "Version", "IsEditor", "Obstacles", "PolygonId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 2307
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// IsAllowClient: true
  /// </summary>
  public sealed partial class PathfindingEnterSceneReq : pb::IMessage<PathfindingEnterSceneReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PathfindingEnterSceneReq> _parser = new pb::MessageParser<PathfindingEnterSceneReq>(() => new PathfindingEnterSceneReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PathfindingEnterSceneReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.PathfindingEnterSceneReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PathfindingEnterSceneReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PathfindingEnterSceneReq(PathfindingEnterSceneReq other) : this() {
      sceneId_ = other.sceneId_;
      activityId_ = other.activityId_.Clone();
      sceneTagHash_ = other.sceneTagHash_;
      version_ = other.version_;
      isEditor_ = other.isEditor_;
      obstacles_ = other.obstacles_.Clone();
      polygonId_ = other.polygonId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PathfindingEnterSceneReq Clone() {
      return new PathfindingEnterSceneReq(this);
    }

    /// <summary>Field number for the "scene_id" field.</summary>
    public const int SceneIdFieldNumber = 12;
    private uint sceneId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SceneId {
      get { return sceneId_; }
      set {
        sceneId_ = value;
      }
    }

    /// <summary>Field number for the "activity_id" field.</summary>
    public const int ActivityIdFieldNumber = 14;
    private static readonly pb::FieldCodec<uint> _repeated_activityId_codec
        = pb::FieldCodec.ForUInt32(114);
    private readonly pbc::RepeatedField<uint> activityId_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> ActivityId {
      get { return activityId_; }
    }

    /// <summary>Field number for the "scene_tag_hash" field.</summary>
    public const int SceneTagHashFieldNumber = 15;
    private uint sceneTagHash_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SceneTagHash {
      get { return sceneTagHash_; }
      set {
        sceneTagHash_ = value;
      }
    }

    /// <summary>Field number for the "version" field.</summary>
    public const int VersionFieldNumber = 6;
    private uint version_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Version {
      get { return version_; }
      set {
        version_ = value;
      }
    }

    /// <summary>Field number for the "is_editor" field.</summary>
    public const int IsEditorFieldNumber = 11;
    private bool isEditor_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsEditor {
      get { return isEditor_; }
      set {
        isEditor_ = value;
      }
    }

    /// <summary>Field number for the "obstacles" field.</summary>
    public const int ObstaclesFieldNumber = 13;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.ObstacleInfo> _repeated_obstacles_codec
        = pb::FieldCodec.ForMessage(106, global::Weedwacker.Shared.Network.Proto.ObstacleInfo.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ObstacleInfo> obstacles_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ObstacleInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ObstacleInfo> Obstacles {
      get { return obstacles_; }
    }

    /// <summary>Field number for the "polygon_id" field.</summary>
    public const int PolygonIdFieldNumber = 4;
    private uint polygonId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PolygonId {
      get { return polygonId_; }
      set {
        polygonId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PathfindingEnterSceneReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PathfindingEnterSceneReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SceneId != other.SceneId) return false;
      if(!activityId_.Equals(other.activityId_)) return false;
      if (SceneTagHash != other.SceneTagHash) return false;
      if (Version != other.Version) return false;
      if (IsEditor != other.IsEditor) return false;
      if(!obstacles_.Equals(other.obstacles_)) return false;
      if (PolygonId != other.PolygonId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (SceneId != 0) hash ^= SceneId.GetHashCode();
      hash ^= activityId_.GetHashCode();
      if (SceneTagHash != 0) hash ^= SceneTagHash.GetHashCode();
      if (Version != 0) hash ^= Version.GetHashCode();
      if (IsEditor != false) hash ^= IsEditor.GetHashCode();
      hash ^= obstacles_.GetHashCode();
      if (PolygonId != 0) hash ^= PolygonId.GetHashCode();
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
      if (PolygonId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(PolygonId);
      }
      if (Version != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Version);
      }
      if (IsEditor != false) {
        output.WriteRawTag(88);
        output.WriteBool(IsEditor);
      }
      if (SceneId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(SceneId);
      }
      obstacles_.WriteTo(output, _repeated_obstacles_codec);
      activityId_.WriteTo(output, _repeated_activityId_codec);
      if (SceneTagHash != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(SceneTagHash);
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
      if (PolygonId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(PolygonId);
      }
      if (Version != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Version);
      }
      if (IsEditor != false) {
        output.WriteRawTag(88);
        output.WriteBool(IsEditor);
      }
      if (SceneId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(SceneId);
      }
      obstacles_.WriteTo(ref output, _repeated_obstacles_codec);
      activityId_.WriteTo(ref output, _repeated_activityId_codec);
      if (SceneTagHash != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(SceneTagHash);
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
      if (SceneId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SceneId);
      }
      size += activityId_.CalculateSize(_repeated_activityId_codec);
      if (SceneTagHash != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SceneTagHash);
      }
      if (Version != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Version);
      }
      if (IsEditor != false) {
        size += 1 + 1;
      }
      size += obstacles_.CalculateSize(_repeated_obstacles_codec);
      if (PolygonId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PolygonId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PathfindingEnterSceneReq other) {
      if (other == null) {
        return;
      }
      if (other.SceneId != 0) {
        SceneId = other.SceneId;
      }
      activityId_.Add(other.activityId_);
      if (other.SceneTagHash != 0) {
        SceneTagHash = other.SceneTagHash;
      }
      if (other.Version != 0) {
        Version = other.Version;
      }
      if (other.IsEditor != false) {
        IsEditor = other.IsEditor;
      }
      obstacles_.Add(other.obstacles_);
      if (other.PolygonId != 0) {
        PolygonId = other.PolygonId;
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
          case 32: {
            PolygonId = input.ReadUInt32();
            break;
          }
          case 48: {
            Version = input.ReadUInt32();
            break;
          }
          case 88: {
            IsEditor = input.ReadBool();
            break;
          }
          case 96: {
            SceneId = input.ReadUInt32();
            break;
          }
          case 106: {
            obstacles_.AddEntriesFrom(input, _repeated_obstacles_codec);
            break;
          }
          case 114:
          case 112: {
            activityId_.AddEntriesFrom(input, _repeated_activityId_codec);
            break;
          }
          case 120: {
            SceneTagHash = input.ReadUInt32();
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
          case 32: {
            PolygonId = input.ReadUInt32();
            break;
          }
          case 48: {
            Version = input.ReadUInt32();
            break;
          }
          case 88: {
            IsEditor = input.ReadBool();
            break;
          }
          case 96: {
            SceneId = input.ReadUInt32();
            break;
          }
          case 106: {
            obstacles_.AddEntriesFrom(ref input, _repeated_obstacles_codec);
            break;
          }
          case 114:
          case 112: {
            activityId_.AddEntriesFrom(ref input, _repeated_activityId_codec);
            break;
          }
          case 120: {
            SceneTagHash = input.ReadUInt32();
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
