// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SceneGalleryVintageHuntingSettleNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from SceneGalleryVintageHuntingSettleNotify.proto</summary>
  public static partial class SceneGalleryVintageHuntingSettleNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for SceneGalleryVintageHuntingSettleNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SceneGalleryVintageHuntingSettleNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CixTY2VuZUdhbGxlcnlWaW50YWdlSHVudGluZ1NldHRsZU5vdGlmeS5wcm90",
            "bxooVmludGFnZUh1bnRpbmdGaXJzdFN0YWdlU2V0dGxlSW5mby5wcm90bxop",
            "VmludGFnZUh1bnRpbmdTZWNvbmRTdGFnZVNldHRsZUluZm8ucHJvdG8aKFZp",
            "bnRhZ2VIdW50aW5nVGhpcmRTdGFnZVNldHRsZUluZm8ucHJvdG8i8AIKJlNj",
            "ZW5lR2FsbGVyeVZpbnRhZ2VIdW50aW5nU2V0dGxlTm90aWZ5EhcKD2hhc19u",
            "ZXdfd2F0Y2hlchgLIAEoCBIQCghzdGFnZV9pZBgJIAEoDRIZChF0b3RhbF93",
            "YXRjaGVyX251bRgMIAEoDRIcChRmaW5pc2hlZF93YXRjaGVyX251bRgGIAEo",
            "DRIVCg1pc19uZXdfcmVjb3JkGAEgASgIEj8KEGZpcnN0X3N0YWdlX2luZm8Y",
            "BCABKAsyIy5WaW50YWdlSHVudGluZ0ZpcnN0U3RhZ2VTZXR0bGVJbmZvSAAS",
            "QQoRc2Vjb25kX3N0YWdlX2luZm8YCiABKAsyJC5WaW50YWdlSHVudGluZ1Nl",
            "Y29uZFN0YWdlU2V0dGxlSW5mb0gAEj8KEHRoaXJkX3N0YWdlX2luZm8YCCAB",
            "KAsyIy5WaW50YWdlSHVudGluZ1RoaXJkU3RhZ2VTZXR0bGVJbmZvSABCBgoE",
            "aW5mb0IiqgIfV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90b2IGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.VintageHuntingFirstStageSettleInfoReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.VintageHuntingSecondStageSettleInfoReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.VintageHuntingThirdStageSettleInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.SceneGalleryVintageHuntingSettleNotify), global::Weedwacker.Shared.Network.Proto.SceneGalleryVintageHuntingSettleNotify.Parser, new[]{ "HasNewWatcher", "StageId", "TotalWatcherNum", "FinishedWatcherNum", "IsNewRecord", "FirstStageInfo", "SecondStageInfo", "ThirdStageInfo" }, new[]{ "Info" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 20324
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class SceneGalleryVintageHuntingSettleNotify : pb::IMessage<SceneGalleryVintageHuntingSettleNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SceneGalleryVintageHuntingSettleNotify> _parser = new pb::MessageParser<SceneGalleryVintageHuntingSettleNotify>(() => new SceneGalleryVintageHuntingSettleNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SceneGalleryVintageHuntingSettleNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.SceneGalleryVintageHuntingSettleNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneGalleryVintageHuntingSettleNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneGalleryVintageHuntingSettleNotify(SceneGalleryVintageHuntingSettleNotify other) : this() {
      hasNewWatcher_ = other.hasNewWatcher_;
      stageId_ = other.stageId_;
      totalWatcherNum_ = other.totalWatcherNum_;
      finishedWatcherNum_ = other.finishedWatcherNum_;
      isNewRecord_ = other.isNewRecord_;
      switch (other.InfoCase) {
        case InfoOneofCase.FirstStageInfo:
          FirstStageInfo = other.FirstStageInfo.Clone();
          break;
        case InfoOneofCase.SecondStageInfo:
          SecondStageInfo = other.SecondStageInfo.Clone();
          break;
        case InfoOneofCase.ThirdStageInfo:
          ThirdStageInfo = other.ThirdStageInfo.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneGalleryVintageHuntingSettleNotify Clone() {
      return new SceneGalleryVintageHuntingSettleNotify(this);
    }

    /// <summary>Field number for the "has_new_watcher" field.</summary>
    public const int HasNewWatcherFieldNumber = 11;
    private bool hasNewWatcher_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasNewWatcher {
      get { return hasNewWatcher_; }
      set {
        hasNewWatcher_ = value;
      }
    }

    /// <summary>Field number for the "stage_id" field.</summary>
    public const int StageIdFieldNumber = 9;
    private uint stageId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StageId {
      get { return stageId_; }
      set {
        stageId_ = value;
      }
    }

    /// <summary>Field number for the "total_watcher_num" field.</summary>
    public const int TotalWatcherNumFieldNumber = 12;
    private uint totalWatcherNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TotalWatcherNum {
      get { return totalWatcherNum_; }
      set {
        totalWatcherNum_ = value;
      }
    }

    /// <summary>Field number for the "finished_watcher_num" field.</summary>
    public const int FinishedWatcherNumFieldNumber = 6;
    private uint finishedWatcherNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FinishedWatcherNum {
      get { return finishedWatcherNum_; }
      set {
        finishedWatcherNum_ = value;
      }
    }

    /// <summary>Field number for the "is_new_record" field.</summary>
    public const int IsNewRecordFieldNumber = 1;
    private bool isNewRecord_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsNewRecord {
      get { return isNewRecord_; }
      set {
        isNewRecord_ = value;
      }
    }

    /// <summary>Field number for the "first_stage_info" field.</summary>
    public const int FirstStageInfoFieldNumber = 4;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.VintageHuntingFirstStageSettleInfo FirstStageInfo {
      get { return infoCase_ == InfoOneofCase.FirstStageInfo ? (global::Weedwacker.Shared.Network.Proto.VintageHuntingFirstStageSettleInfo) info_ : null; }
      set {
        info_ = value;
        infoCase_ = value == null ? InfoOneofCase.None : InfoOneofCase.FirstStageInfo;
      }
    }

    /// <summary>Field number for the "second_stage_info" field.</summary>
    public const int SecondStageInfoFieldNumber = 10;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.VintageHuntingSecondStageSettleInfo SecondStageInfo {
      get { return infoCase_ == InfoOneofCase.SecondStageInfo ? (global::Weedwacker.Shared.Network.Proto.VintageHuntingSecondStageSettleInfo) info_ : null; }
      set {
        info_ = value;
        infoCase_ = value == null ? InfoOneofCase.None : InfoOneofCase.SecondStageInfo;
      }
    }

    /// <summary>Field number for the "third_stage_info" field.</summary>
    public const int ThirdStageInfoFieldNumber = 8;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.VintageHuntingThirdStageSettleInfo ThirdStageInfo {
      get { return infoCase_ == InfoOneofCase.ThirdStageInfo ? (global::Weedwacker.Shared.Network.Proto.VintageHuntingThirdStageSettleInfo) info_ : null; }
      set {
        info_ = value;
        infoCase_ = value == null ? InfoOneofCase.None : InfoOneofCase.ThirdStageInfo;
      }
    }

    private object info_;
    /// <summary>Enum of possible cases for the "info" oneof.</summary>
    public enum InfoOneofCase {
      None = 0,
      FirstStageInfo = 4,
      SecondStageInfo = 10,
      ThirdStageInfo = 8,
    }
    private InfoOneofCase infoCase_ = InfoOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public InfoOneofCase InfoCase {
      get { return infoCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearInfo() {
      infoCase_ = InfoOneofCase.None;
      info_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SceneGalleryVintageHuntingSettleNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SceneGalleryVintageHuntingSettleNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (HasNewWatcher != other.HasNewWatcher) return false;
      if (StageId != other.StageId) return false;
      if (TotalWatcherNum != other.TotalWatcherNum) return false;
      if (FinishedWatcherNum != other.FinishedWatcherNum) return false;
      if (IsNewRecord != other.IsNewRecord) return false;
      if (!object.Equals(FirstStageInfo, other.FirstStageInfo)) return false;
      if (!object.Equals(SecondStageInfo, other.SecondStageInfo)) return false;
      if (!object.Equals(ThirdStageInfo, other.ThirdStageInfo)) return false;
      if (InfoCase != other.InfoCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HasNewWatcher != false) hash ^= HasNewWatcher.GetHashCode();
      if (StageId != 0) hash ^= StageId.GetHashCode();
      if (TotalWatcherNum != 0) hash ^= TotalWatcherNum.GetHashCode();
      if (FinishedWatcherNum != 0) hash ^= FinishedWatcherNum.GetHashCode();
      if (IsNewRecord != false) hash ^= IsNewRecord.GetHashCode();
      if (infoCase_ == InfoOneofCase.FirstStageInfo) hash ^= FirstStageInfo.GetHashCode();
      if (infoCase_ == InfoOneofCase.SecondStageInfo) hash ^= SecondStageInfo.GetHashCode();
      if (infoCase_ == InfoOneofCase.ThirdStageInfo) hash ^= ThirdStageInfo.GetHashCode();
      hash ^= (int) infoCase_;
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
      if (IsNewRecord != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsNewRecord);
      }
      if (infoCase_ == InfoOneofCase.FirstStageInfo) {
        output.WriteRawTag(34);
        output.WriteMessage(FirstStageInfo);
      }
      if (FinishedWatcherNum != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(FinishedWatcherNum);
      }
      if (infoCase_ == InfoOneofCase.ThirdStageInfo) {
        output.WriteRawTag(66);
        output.WriteMessage(ThirdStageInfo);
      }
      if (StageId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(StageId);
      }
      if (infoCase_ == InfoOneofCase.SecondStageInfo) {
        output.WriteRawTag(82);
        output.WriteMessage(SecondStageInfo);
      }
      if (HasNewWatcher != false) {
        output.WriteRawTag(88);
        output.WriteBool(HasNewWatcher);
      }
      if (TotalWatcherNum != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(TotalWatcherNum);
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
      if (IsNewRecord != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsNewRecord);
      }
      if (infoCase_ == InfoOneofCase.FirstStageInfo) {
        output.WriteRawTag(34);
        output.WriteMessage(FirstStageInfo);
      }
      if (FinishedWatcherNum != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(FinishedWatcherNum);
      }
      if (infoCase_ == InfoOneofCase.ThirdStageInfo) {
        output.WriteRawTag(66);
        output.WriteMessage(ThirdStageInfo);
      }
      if (StageId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(StageId);
      }
      if (infoCase_ == InfoOneofCase.SecondStageInfo) {
        output.WriteRawTag(82);
        output.WriteMessage(SecondStageInfo);
      }
      if (HasNewWatcher != false) {
        output.WriteRawTag(88);
        output.WriteBool(HasNewWatcher);
      }
      if (TotalWatcherNum != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(TotalWatcherNum);
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
      if (HasNewWatcher != false) {
        size += 1 + 1;
      }
      if (StageId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StageId);
      }
      if (TotalWatcherNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TotalWatcherNum);
      }
      if (FinishedWatcherNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FinishedWatcherNum);
      }
      if (IsNewRecord != false) {
        size += 1 + 1;
      }
      if (infoCase_ == InfoOneofCase.FirstStageInfo) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FirstStageInfo);
      }
      if (infoCase_ == InfoOneofCase.SecondStageInfo) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SecondStageInfo);
      }
      if (infoCase_ == InfoOneofCase.ThirdStageInfo) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ThirdStageInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SceneGalleryVintageHuntingSettleNotify other) {
      if (other == null) {
        return;
      }
      if (other.HasNewWatcher != false) {
        HasNewWatcher = other.HasNewWatcher;
      }
      if (other.StageId != 0) {
        StageId = other.StageId;
      }
      if (other.TotalWatcherNum != 0) {
        TotalWatcherNum = other.TotalWatcherNum;
      }
      if (other.FinishedWatcherNum != 0) {
        FinishedWatcherNum = other.FinishedWatcherNum;
      }
      if (other.IsNewRecord != false) {
        IsNewRecord = other.IsNewRecord;
      }
      switch (other.InfoCase) {
        case InfoOneofCase.FirstStageInfo:
          if (FirstStageInfo == null) {
            FirstStageInfo = new global::Weedwacker.Shared.Network.Proto.VintageHuntingFirstStageSettleInfo();
          }
          FirstStageInfo.MergeFrom(other.FirstStageInfo);
          break;
        case InfoOneofCase.SecondStageInfo:
          if (SecondStageInfo == null) {
            SecondStageInfo = new global::Weedwacker.Shared.Network.Proto.VintageHuntingSecondStageSettleInfo();
          }
          SecondStageInfo.MergeFrom(other.SecondStageInfo);
          break;
        case InfoOneofCase.ThirdStageInfo:
          if (ThirdStageInfo == null) {
            ThirdStageInfo = new global::Weedwacker.Shared.Network.Proto.VintageHuntingThirdStageSettleInfo();
          }
          ThirdStageInfo.MergeFrom(other.ThirdStageInfo);
          break;
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
          case 8: {
            IsNewRecord = input.ReadBool();
            break;
          }
          case 34: {
            global::Weedwacker.Shared.Network.Proto.VintageHuntingFirstStageSettleInfo subBuilder = new global::Weedwacker.Shared.Network.Proto.VintageHuntingFirstStageSettleInfo();
            if (infoCase_ == InfoOneofCase.FirstStageInfo) {
              subBuilder.MergeFrom(FirstStageInfo);
            }
            input.ReadMessage(subBuilder);
            FirstStageInfo = subBuilder;
            break;
          }
          case 48: {
            FinishedWatcherNum = input.ReadUInt32();
            break;
          }
          case 66: {
            global::Weedwacker.Shared.Network.Proto.VintageHuntingThirdStageSettleInfo subBuilder = new global::Weedwacker.Shared.Network.Proto.VintageHuntingThirdStageSettleInfo();
            if (infoCase_ == InfoOneofCase.ThirdStageInfo) {
              subBuilder.MergeFrom(ThirdStageInfo);
            }
            input.ReadMessage(subBuilder);
            ThirdStageInfo = subBuilder;
            break;
          }
          case 72: {
            StageId = input.ReadUInt32();
            break;
          }
          case 82: {
            global::Weedwacker.Shared.Network.Proto.VintageHuntingSecondStageSettleInfo subBuilder = new global::Weedwacker.Shared.Network.Proto.VintageHuntingSecondStageSettleInfo();
            if (infoCase_ == InfoOneofCase.SecondStageInfo) {
              subBuilder.MergeFrom(SecondStageInfo);
            }
            input.ReadMessage(subBuilder);
            SecondStageInfo = subBuilder;
            break;
          }
          case 88: {
            HasNewWatcher = input.ReadBool();
            break;
          }
          case 96: {
            TotalWatcherNum = input.ReadUInt32();
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
          case 8: {
            IsNewRecord = input.ReadBool();
            break;
          }
          case 34: {
            global::Weedwacker.Shared.Network.Proto.VintageHuntingFirstStageSettleInfo subBuilder = new global::Weedwacker.Shared.Network.Proto.VintageHuntingFirstStageSettleInfo();
            if (infoCase_ == InfoOneofCase.FirstStageInfo) {
              subBuilder.MergeFrom(FirstStageInfo);
            }
            input.ReadMessage(subBuilder);
            FirstStageInfo = subBuilder;
            break;
          }
          case 48: {
            FinishedWatcherNum = input.ReadUInt32();
            break;
          }
          case 66: {
            global::Weedwacker.Shared.Network.Proto.VintageHuntingThirdStageSettleInfo subBuilder = new global::Weedwacker.Shared.Network.Proto.VintageHuntingThirdStageSettleInfo();
            if (infoCase_ == InfoOneofCase.ThirdStageInfo) {
              subBuilder.MergeFrom(ThirdStageInfo);
            }
            input.ReadMessage(subBuilder);
            ThirdStageInfo = subBuilder;
            break;
          }
          case 72: {
            StageId = input.ReadUInt32();
            break;
          }
          case 82: {
            global::Weedwacker.Shared.Network.Proto.VintageHuntingSecondStageSettleInfo subBuilder = new global::Weedwacker.Shared.Network.Proto.VintageHuntingSecondStageSettleInfo();
            if (infoCase_ == InfoOneofCase.SecondStageInfo) {
              subBuilder.MergeFrom(SecondStageInfo);
            }
            input.ReadMessage(subBuilder);
            SecondStageInfo = subBuilder;
            break;
          }
          case 88: {
            HasNewWatcher = input.ReadBool();
            break;
          }
          case 96: {
            TotalWatcherNum = input.ReadUInt32();
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
