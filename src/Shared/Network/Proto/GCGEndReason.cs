// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCGEndReason.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from GCGEndReason.proto</summary>
  public static partial class GCGEndReasonReflection {

    #region Descriptor
    /// <summary>File descriptor for GCGEndReason.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GCGEndReasonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJHQ0dFbmRSZWFzb24ucHJvdG8qoQEKDEdDR0VuZFJlYXNvbhIaChZHQ0df",
            "RU5EX1JFQVNPTl9ERUZBVUxUEAASFgoSR0NHX0VORF9SRUFTT05fRElFEAES",
            "HAoYR0NHX0VORF9SRUFTT05fU1VSUkVOREVSEAISHwobR0NHX0VORF9SRUFT",
            "T05fRElTQ09OTkVDVEVEEAMSHgoaR0NHX0VORF9SRUFTT05fUk9VTkRfTElN",
            "SVQQBEIiqgIfV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90b2IGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Weedwacker.Shared.Network.Proto.GCGEndReason), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum GCGEndReason {
    [pbr::OriginalName("GCG_END_REASON_DEFAULT")] Default = 0,
    [pbr::OriginalName("GCG_END_REASON_DIE")] Die = 1,
    [pbr::OriginalName("GCG_END_REASON_SURRENDER")] Surrender = 2,
    [pbr::OriginalName("GCG_END_REASON_DISCONNECTED")] Disconnected = 3,
    [pbr::OriginalName("GCG_END_REASON_ROUND_LIMIT")] RoundLimit = 4,
  }

  #endregion

}

#endregion Designer generated code
