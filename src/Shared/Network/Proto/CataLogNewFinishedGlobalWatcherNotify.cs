// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CataLogNewFinishedGlobalWatcherNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from CataLogNewFinishedGlobalWatcherNotify.proto</summary>
  public static partial class CataLogNewFinishedGlobalWatcherNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for CataLogNewFinishedGlobalWatcherNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CataLogNewFinishedGlobalWatcherNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CitDYXRhTG9nTmV3RmluaXNoZWRHbG9iYWxXYXRjaGVyTm90aWZ5LnByb3Rv",
            "GiZDYXRhTG9nR2xvYmFsV2F0Y2hlckZpbmlzaGVkRGF0YS5wcm90byJ5CiVD",
            "YXRhTG9nTmV3RmluaXNoZWRHbG9iYWxXYXRjaGVyTm90aWZ5ElAKJW5ld19m",
            "aW5pc2hlZF9nbG9iYWxfd2F0Y2hlcl9kYXRhX2xpc3QYAiADKAsyIS5DYXRh",
            "TG9nR2xvYmFsV2F0Y2hlckZpbmlzaGVkRGF0YUIiqgIfV2VlZHdhY2tlci5T",
            "aGFyZWQuTmV0d29yay5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.CataLogGlobalWatcherFinishedDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.CataLogNewFinishedGlobalWatcherNotify), global::Weedwacker.Shared.Network.Proto.CataLogNewFinishedGlobalWatcherNotify.Parser, new[]{ "NewFinishedGlobalWatcherDataList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 6395
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class CataLogNewFinishedGlobalWatcherNotify : pb::IMessage<CataLogNewFinishedGlobalWatcherNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CataLogNewFinishedGlobalWatcherNotify> _parser = new pb::MessageParser<CataLogNewFinishedGlobalWatcherNotify>(() => new CataLogNewFinishedGlobalWatcherNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CataLogNewFinishedGlobalWatcherNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.CataLogNewFinishedGlobalWatcherNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CataLogNewFinishedGlobalWatcherNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CataLogNewFinishedGlobalWatcherNotify(CataLogNewFinishedGlobalWatcherNotify other) : this() {
      newFinishedGlobalWatcherDataList_ = other.newFinishedGlobalWatcherDataList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CataLogNewFinishedGlobalWatcherNotify Clone() {
      return new CataLogNewFinishedGlobalWatcherNotify(this);
    }

    /// <summary>Field number for the "new_finished_global_watcher_data_list" field.</summary>
    public const int NewFinishedGlobalWatcherDataListFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.CataLogGlobalWatcherFinishedData> _repeated_newFinishedGlobalWatcherDataList_codec
        = pb::FieldCodec.ForMessage(18, global::Weedwacker.Shared.Network.Proto.CataLogGlobalWatcherFinishedData.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.CataLogGlobalWatcherFinishedData> newFinishedGlobalWatcherDataList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.CataLogGlobalWatcherFinishedData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.CataLogGlobalWatcherFinishedData> NewFinishedGlobalWatcherDataList {
      get { return newFinishedGlobalWatcherDataList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CataLogNewFinishedGlobalWatcherNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CataLogNewFinishedGlobalWatcherNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!newFinishedGlobalWatcherDataList_.Equals(other.newFinishedGlobalWatcherDataList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= newFinishedGlobalWatcherDataList_.GetHashCode();
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
      newFinishedGlobalWatcherDataList_.WriteTo(output, _repeated_newFinishedGlobalWatcherDataList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      newFinishedGlobalWatcherDataList_.WriteTo(ref output, _repeated_newFinishedGlobalWatcherDataList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += newFinishedGlobalWatcherDataList_.CalculateSize(_repeated_newFinishedGlobalWatcherDataList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CataLogNewFinishedGlobalWatcherNotify other) {
      if (other == null) {
        return;
      }
      newFinishedGlobalWatcherDataList_.Add(other.newFinishedGlobalWatcherDataList_);
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
          case 18: {
            newFinishedGlobalWatcherDataList_.AddEntriesFrom(input, _repeated_newFinishedGlobalWatcherDataList_codec);
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
          case 18: {
            newFinishedGlobalWatcherDataList_.AddEntriesFrom(ref input, _repeated_newFinishedGlobalWatcherDataList_codec);
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
