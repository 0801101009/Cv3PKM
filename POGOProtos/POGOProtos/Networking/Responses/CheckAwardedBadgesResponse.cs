// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Cv3PKM.Protos/Networking/Responses/CheckAwardedBadgesResponse.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Cv3PKM.Protos.Networking.Responses {

  /// <summary>Holder for reflection information generated from Cv3PKM.Protos/Networking/Responses/CheckAwardedBadgesResponse.proto</summary>
  public static partial class CheckAwardedBadgesResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for Cv3PKM.Protos/Networking/Responses/CheckAwardedBadgesResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CheckAwardedBadgesResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkBQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL0NoZWNrQXdhcmRl",
            "ZEJhZGdlc1Jlc3BvbnNlLnByb3RvEh9QT0dPUHJvdG9zLk5ldHdvcmtpbmcu",
            "UmVzcG9uc2VzGiBQT0dPUHJvdG9zL0VudW1zL0JhZGdlVHlwZS5wcm90byKA",
            "AQoaQ2hlY2tBd2FyZGVkQmFkZ2VzUmVzcG9uc2USDwoHc3VjY2VzcxgBIAEo",
            "CBIzCg5hd2FyZGVkX2JhZGdlcxgCIAMoDjIbLlBPR09Qcm90b3MuRW51bXMu",
            "QmFkZ2VUeXBlEhwKFGF3YXJkZWRfYmFkZ2VfbGV2ZWxzGAMgAygFYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Cv3PKM.Protos.Enums.BadgeTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Cv3PKM.Protos.Networking.Responses.CheckAwardedBadgesResponse), global::Cv3PKM.Protos.Networking.Responses.CheckAwardedBadgesResponse.Parser, new[]{ "Success", "AwardedBadges", "AwardedBadgeLevels" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CheckAwardedBadgesResponse : pb::IMessage<CheckAwardedBadgesResponse> {
    private static readonly pb::MessageParser<CheckAwardedBadgesResponse> _parser = new pb::MessageParser<CheckAwardedBadgesResponse>(() => new CheckAwardedBadgesResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CheckAwardedBadgesResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cv3PKM.Protos.Networking.Responses.CheckAwardedBadgesResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CheckAwardedBadgesResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CheckAwardedBadgesResponse(CheckAwardedBadgesResponse other) : this() {
      success_ = other.success_;
      awardedBadges_ = other.awardedBadges_.Clone();
      awardedBadgeLevels_ = other.awardedBadgeLevels_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CheckAwardedBadgesResponse Clone() {
      return new CheckAwardedBadgesResponse(this);
    }

    /// <summary>Field number for the "success" field.</summary>
    public const int SuccessFieldNumber = 1;
    private bool success_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Success {
      get { return success_; }
      set {
        success_ = value;
      }
    }

    /// <summary>Field number for the "awarded_badges" field.</summary>
    public const int AwardedBadgesFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Cv3PKM.Protos.Enums.BadgeType> _repeated_awardedBadges_codec
        = pb::FieldCodec.ForEnum(18, x => (int) x, x => (global::Cv3PKM.Protos.Enums.BadgeType) x);
    private readonly pbc::RepeatedField<global::Cv3PKM.Protos.Enums.BadgeType> awardedBadges_ = new pbc::RepeatedField<global::Cv3PKM.Protos.Enums.BadgeType>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Cv3PKM.Protos.Enums.BadgeType> AwardedBadges {
      get { return awardedBadges_; }
    }

    /// <summary>Field number for the "awarded_badge_levels" field.</summary>
    public const int AwardedBadgeLevelsFieldNumber = 3;
    private static readonly pb::FieldCodec<int> _repeated_awardedBadgeLevels_codec
        = pb::FieldCodec.ForInt32(26);
    private readonly pbc::RepeatedField<int> awardedBadgeLevels_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<int> AwardedBadgeLevels {
      get { return awardedBadgeLevels_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CheckAwardedBadgesResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CheckAwardedBadgesResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Success != other.Success) return false;
      if(!awardedBadges_.Equals(other.awardedBadges_)) return false;
      if(!awardedBadgeLevels_.Equals(other.awardedBadgeLevels_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Success != false) hash ^= Success.GetHashCode();
      hash ^= awardedBadges_.GetHashCode();
      hash ^= awardedBadgeLevels_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Success != false) {
        output.WriteRawTag(8);
        output.WriteBool(Success);
      }
      awardedBadges_.WriteTo(output, _repeated_awardedBadges_codec);
      awardedBadgeLevels_.WriteTo(output, _repeated_awardedBadgeLevels_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Success != false) {
        size += 1 + 1;
      }
      size += awardedBadges_.CalculateSize(_repeated_awardedBadges_codec);
      size += awardedBadgeLevels_.CalculateSize(_repeated_awardedBadgeLevels_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CheckAwardedBadgesResponse other) {
      if (other == null) {
        return;
      }
      if (other.Success != false) {
        Success = other.Success;
      }
      awardedBadges_.Add(other.awardedBadges_);
      awardedBadgeLevels_.Add(other.awardedBadgeLevels_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Success = input.ReadBool();
            break;
          }
          case 18:
          case 16: {
            awardedBadges_.AddEntriesFrom(input, _repeated_awardedBadges_codec);
            break;
          }
          case 26:
          case 24: {
            awardedBadgeLevels_.AddEntriesFrom(input, _repeated_awardedBadgeLevels_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
