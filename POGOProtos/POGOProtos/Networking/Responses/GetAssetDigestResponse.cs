// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Cv3PKM.Protos/Networking/Responses/GetAssetDigestResponse.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Cv3PKM.Protos.Networking.Responses {

  /// <summary>Holder for reflection information generated from Cv3PKM.Protos/Networking/Responses/GetAssetDigestResponse.proto</summary>
  public static partial class GetAssetDigestResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for Cv3PKM.Protos/Networking/Responses/GetAssetDigestResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetAssetDigestResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjxQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL0dldEFzc2V0RGln",
            "ZXN0UmVzcG9uc2UucHJvdG8SH1BPR09Qcm90b3MuTmV0d29ya2luZy5SZXNw",
            "b25zZXMaJlBPR09Qcm90b3MvRGF0YS9Bc3NldERpZ2VzdEVudHJ5LnByb3Rv",
            "ImEKFkdldEFzc2V0RGlnZXN0UmVzcG9uc2USMQoGZGlnZXN0GAEgAygLMiEu",
            "UE9HT1Byb3Rvcy5EYXRhLkFzc2V0RGlnZXN0RW50cnkSFAoMdGltZXN0YW1w",
            "X21zGAIgASgEYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Cv3PKM.Protos.Data.AssetDigestEntryReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Cv3PKM.Protos.Networking.Responses.GetAssetDigestResponse), global::Cv3PKM.Protos.Networking.Responses.GetAssetDigestResponse.Parser, new[]{ "Digest", "TimestampMs" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GetAssetDigestResponse : pb::IMessage<GetAssetDigestResponse> {
    private static readonly pb::MessageParser<GetAssetDigestResponse> _parser = new pb::MessageParser<GetAssetDigestResponse>(() => new GetAssetDigestResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetAssetDigestResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cv3PKM.Protos.Networking.Responses.GetAssetDigestResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetAssetDigestResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetAssetDigestResponse(GetAssetDigestResponse other) : this() {
      digest_ = other.digest_.Clone();
      timestampMs_ = other.timestampMs_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetAssetDigestResponse Clone() {
      return new GetAssetDigestResponse(this);
    }

    /// <summary>Field number for the "digest" field.</summary>
    public const int DigestFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Cv3PKM.Protos.Data.AssetDigestEntry> _repeated_digest_codec
        = pb::FieldCodec.ForMessage(10, global::Cv3PKM.Protos.Data.AssetDigestEntry.Parser);
    private readonly pbc::RepeatedField<global::Cv3PKM.Protos.Data.AssetDigestEntry> digest_ = new pbc::RepeatedField<global::Cv3PKM.Protos.Data.AssetDigestEntry>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Cv3PKM.Protos.Data.AssetDigestEntry> Digest {
      get { return digest_; }
    }

    /// <summary>Field number for the "timestamp_ms" field.</summary>
    public const int TimestampMsFieldNumber = 2;
    private ulong timestampMs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong TimestampMs {
      get { return timestampMs_; }
      set {
        timestampMs_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetAssetDigestResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetAssetDigestResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!digest_.Equals(other.digest_)) return false;
      if (TimestampMs != other.TimestampMs) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= digest_.GetHashCode();
      if (TimestampMs != 0UL) hash ^= TimestampMs.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      digest_.WriteTo(output, _repeated_digest_codec);
      if (TimestampMs != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(TimestampMs);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += digest_.CalculateSize(_repeated_digest_codec);
      if (TimestampMs != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(TimestampMs);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetAssetDigestResponse other) {
      if (other == null) {
        return;
      }
      digest_.Add(other.digest_);
      if (other.TimestampMs != 0UL) {
        TimestampMs = other.TimestampMs;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            digest_.AddEntriesFrom(input, _repeated_digest_codec);
            break;
          }
          case 16: {
            TimestampMs = input.ReadUInt64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
