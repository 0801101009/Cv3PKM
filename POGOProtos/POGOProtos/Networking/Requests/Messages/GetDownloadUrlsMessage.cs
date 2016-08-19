// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Cv3PKM.Protos/Networking/Requests/Messages/GetDownloadUrlsMessage.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Cv3PKM.Protos.Networking.Requests.Messages {

  /// <summary>Holder for reflection information generated from Cv3PKM.Protos/Networking/Requests/Messages/GetDownloadUrlsMessage.proto</summary>
  public static partial class GetDownloadUrlsMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for Cv3PKM.Protos/Networking/Requests/Messages/GetDownloadUrlsMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetDownloadUrlsMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkRQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVxdWVzdHMvTWVzc2FnZXMvR2V0",
            "RG93bmxvYWRVcmxzTWVzc2FnZS5wcm90bxInUE9HT1Byb3Rvcy5OZXR3b3Jr",
            "aW5nLlJlcXVlc3RzLk1lc3NhZ2VzIioKFkdldERvd25sb2FkVXJsc01lc3Nh",
            "Z2USEAoIYXNzZXRfaWQYASADKAliBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Cv3PKM.Protos.Networking.Requests.Messages.GetDownloadUrlsMessage), global::Cv3PKM.Protos.Networking.Requests.Messages.GetDownloadUrlsMessage.Parser, new[]{ "AssetId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///  UNTESTED
  /// </summary>
  public sealed partial class GetDownloadUrlsMessage : pb::IMessage<GetDownloadUrlsMessage> {
    private static readonly pb::MessageParser<GetDownloadUrlsMessage> _parser = new pb::MessageParser<GetDownloadUrlsMessage>(() => new GetDownloadUrlsMessage());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetDownloadUrlsMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cv3PKM.Protos.Networking.Requests.Messages.GetDownloadUrlsMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetDownloadUrlsMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetDownloadUrlsMessage(GetDownloadUrlsMessage other) : this() {
      assetId_ = other.assetId_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetDownloadUrlsMessage Clone() {
      return new GetDownloadUrlsMessage(this);
    }

    /// <summary>Field number for the "asset_id" field.</summary>
    public const int AssetIdFieldNumber = 1;
    private static readonly pb::FieldCodec<string> _repeated_assetId_codec
        = pb::FieldCodec.ForString(10);
    private readonly pbc::RepeatedField<string> assetId_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> AssetId {
      get { return assetId_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetDownloadUrlsMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetDownloadUrlsMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!assetId_.Equals(other.assetId_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= assetId_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      assetId_.WriteTo(output, _repeated_assetId_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += assetId_.CalculateSize(_repeated_assetId_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetDownloadUrlsMessage other) {
      if (other == null) {
        return;
      }
      assetId_.Add(other.assetId_);
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
            assetId_.AddEntriesFrom(input, _repeated_assetId_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
