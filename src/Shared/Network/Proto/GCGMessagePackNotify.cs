// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCGMessagePackNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from GCGMessagePackNotify.proto</summary>
  public static partial class GCGMessagePackNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for GCGMessagePackNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GCGMessagePackNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpHQ0dNZXNzYWdlUGFja05vdGlmeS5wcm90bxoUR0NHTWVzc2FnZVBhY2su",
            "cHJvdG8iUQoUR0NHTWVzc2FnZVBhY2tOb3RpZnkSEgoKc2VydmVyX3NlcRgF",
            "IAEoDRIlCgxtZXNzYWdlX3BhY2sYCCABKAsyDy5HQ0dNZXNzYWdlUGFja0Ii",
            "qgIfV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.GCGMessagePackReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.GCGMessagePackNotify), global::Weedwacker.Shared.Network.Proto.GCGMessagePackNotify.Parser, new[]{ "ServerSeq", "MessagePack" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 7516
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// IsAllowClient: true
  /// </summary>
  public sealed partial class GCGMessagePackNotify : pb::IMessage<GCGMessagePackNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GCGMessagePackNotify> _parser = new pb::MessageParser<GCGMessagePackNotify>(() => new GCGMessagePackNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GCGMessagePackNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.GCGMessagePackNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGMessagePackNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGMessagePackNotify(GCGMessagePackNotify other) : this() {
      serverSeq_ = other.serverSeq_;
      messagePack_ = other.messagePack_ != null ? other.messagePack_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGMessagePackNotify Clone() {
      return new GCGMessagePackNotify(this);
    }

    /// <summary>Field number for the "server_seq" field.</summary>
    public const int ServerSeqFieldNumber = 5;
    private uint serverSeq_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ServerSeq {
      get { return serverSeq_; }
      set {
        serverSeq_ = value;
      }
    }

    /// <summary>Field number for the "message_pack" field.</summary>
    public const int MessagePackFieldNumber = 8;
    private global::Weedwacker.Shared.Network.Proto.GCGMessagePack messagePack_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.GCGMessagePack MessagePack {
      get { return messagePack_; }
      set {
        messagePack_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GCGMessagePackNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GCGMessagePackNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ServerSeq != other.ServerSeq) return false;
      if (!object.Equals(MessagePack, other.MessagePack)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ServerSeq != 0) hash ^= ServerSeq.GetHashCode();
      if (messagePack_ != null) hash ^= MessagePack.GetHashCode();
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
      if (ServerSeq != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(ServerSeq);
      }
      if (messagePack_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(MessagePack);
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
      if (ServerSeq != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(ServerSeq);
      }
      if (messagePack_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(MessagePack);
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
      if (ServerSeq != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ServerSeq);
      }
      if (messagePack_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MessagePack);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GCGMessagePackNotify other) {
      if (other == null) {
        return;
      }
      if (other.ServerSeq != 0) {
        ServerSeq = other.ServerSeq;
      }
      if (other.messagePack_ != null) {
        if (messagePack_ == null) {
          MessagePack = new global::Weedwacker.Shared.Network.Proto.GCGMessagePack();
        }
        MessagePack.MergeFrom(other.MessagePack);
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
            ServerSeq = input.ReadUInt32();
            break;
          }
          case 66: {
            if (messagePack_ == null) {
              MessagePack = new global::Weedwacker.Shared.Network.Proto.GCGMessagePack();
            }
            input.ReadMessage(MessagePack);
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
            ServerSeq = input.ReadUInt32();
            break;
          }
          case 66: {
            if (messagePack_ == null) {
              MessagePack = new global::Weedwacker.Shared.Network.Proto.GCGMessagePack();
            }
            input.ReadMessage(MessagePack);
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