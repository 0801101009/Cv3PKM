// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Cv3PKM.Protos/Networking/Responses/GetGymDetailsResponse.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Cv3PKM.Protos.Networking.Responses {

  /// <summary>Holder for reflection information generated from Cv3PKM.Protos/Networking/Responses/GetGymDetailsResponse.proto</summary>
  public static partial class GetGymDetailsResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for Cv3PKM.Protos/Networking/Responses/GetGymDetailsResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetGymDetailsResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjtQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL0dldEd5bURldGFp",
            "bHNSZXNwb25zZS5wcm90bxIfUE9HT1Byb3Rvcy5OZXR3b3JraW5nLlJlc3Bv",
            "bnNlcxoiUE9HT1Byb3Rvcy9EYXRhL0d5bS9HeW1TdGF0ZS5wcm90byKDAgoV",
            "R2V0R3ltRGV0YWlsc1Jlc3BvbnNlEjAKCWd5bV9zdGF0ZRgBIAEoCzIdLlBP",
            "R09Qcm90b3MuRGF0YS5HeW0uR3ltU3RhdGUSDAoEbmFtZRgCIAEoCRIMCgR1",
            "cmxzGAMgAygJEk0KBnJlc3VsdBgEIAEoDjI9LlBPR09Qcm90b3MuTmV0d29y",
            "a2luZy5SZXNwb25zZXMuR2V0R3ltRGV0YWlsc1Jlc3BvbnNlLlJlc3VsdBIT",
            "CgtkZXNjcmlwdGlvbhgFIAEoCSI4CgZSZXN1bHQSCQoFVU5TRVQQABILCgdT",
            "VUNDRVNTEAESFgoSRVJST1JfTk9UX0lOX1JBTkdFEAJiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Cv3PKM.Protos.Data.Gym.GymStateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Cv3PKM.Protos.Networking.Responses.GetGymDetailsResponse), global::Cv3PKM.Protos.Networking.Responses.GetGymDetailsResponse.Parser, new[]{ "GymState", "Name", "Urls", "Result", "Description" }, null, new[]{ typeof(global::Cv3PKM.Protos.Networking.Responses.GetGymDetailsResponse.Types.Result) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GetGymDetailsResponse : pb::IMessage<GetGymDetailsResponse> {
    private static readonly pb::MessageParser<GetGymDetailsResponse> _parser = new pb::MessageParser<GetGymDetailsResponse>(() => new GetGymDetailsResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetGymDetailsResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cv3PKM.Protos.Networking.Responses.GetGymDetailsResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetGymDetailsResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetGymDetailsResponse(GetGymDetailsResponse other) : this() {
      GymState = other.gymState_ != null ? other.GymState.Clone() : null;
      name_ = other.name_;
      urls_ = other.urls_.Clone();
      result_ = other.result_;
      description_ = other.description_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetGymDetailsResponse Clone() {
      return new GetGymDetailsResponse(this);
    }

    /// <summary>Field number for the "gym_state" field.</summary>
    public const int GymStateFieldNumber = 1;
    private global::Cv3PKM.Protos.Data.Gym.GymState gymState_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Cv3PKM.Protos.Data.Gym.GymState GymState {
      get { return gymState_; }
      set {
        gymState_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 2;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "urls" field.</summary>
    public const int UrlsFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _repeated_urls_codec
        = pb::FieldCodec.ForString(26);
    private readonly pbc::RepeatedField<string> urls_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> Urls {
      get { return urls_; }
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 4;
    private global::Cv3PKM.Protos.Networking.Responses.GetGymDetailsResponse.Types.Result result_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Cv3PKM.Protos.Networking.Responses.GetGymDetailsResponse.Types.Result Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    /// <summary>Field number for the "description" field.</summary>
    public const int DescriptionFieldNumber = 5;
    private string description_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Description {
      get { return description_; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetGymDetailsResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetGymDetailsResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(GymState, other.GymState)) return false;
      if (Name != other.Name) return false;
      if(!urls_.Equals(other.urls_)) return false;
      if (Result != other.Result) return false;
      if (Description != other.Description) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (gymState_ != null) hash ^= GymState.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      hash ^= urls_.GetHashCode();
      if (Result != 0) hash ^= Result.GetHashCode();
      if (Description.Length != 0) hash ^= Description.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (gymState_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(GymState);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      urls_.WriteTo(output, _repeated_urls_codec);
      if (Result != 0) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Result);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Description);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (gymState_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GymState);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      size += urls_.CalculateSize(_repeated_urls_codec);
      if (Result != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Result);
      }
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetGymDetailsResponse other) {
      if (other == null) {
        return;
      }
      if (other.gymState_ != null) {
        if (gymState_ == null) {
          gymState_ = new global::Cv3PKM.Protos.Data.Gym.GymState();
        }
        GymState.MergeFrom(other.GymState);
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      urls_.Add(other.urls_);
      if (other.Result != 0) {
        Result = other.Result;
      }
      if (other.Description.Length != 0) {
        Description = other.Description;
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
            if (gymState_ == null) {
              gymState_ = new global::Cv3PKM.Protos.Data.Gym.GymState();
            }
            input.ReadMessage(gymState_);
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 26: {
            urls_.AddEntriesFrom(input, _repeated_urls_codec);
            break;
          }
          case 32: {
            result_ = (global::Cv3PKM.Protos.Networking.Responses.GetGymDetailsResponse.Types.Result) input.ReadEnum();
            break;
          }
          case 42: {
            Description = input.ReadString();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the GetGymDetailsResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Result {
        [pbr::OriginalName("UNSET")] Unset = 0,
        [pbr::OriginalName("SUCCESS")] Success = 1,
        [pbr::OriginalName("ERROR_NOT_IN_RANGE")] ErrorNotInRange = 2,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
