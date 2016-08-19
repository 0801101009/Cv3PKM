// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Cv3PKM.Protos/Networking/Responses/UseItemPotionResponse.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Cv3PKM.Protos.Networking.Responses {

  /// <summary>Holder for reflection information generated from Cv3PKM.Protos/Networking/Responses/UseItemPotionResponse.proto</summary>
  public static partial class UseItemPotionResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for Cv3PKM.Protos/Networking/Responses/UseItemPotionResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UseItemPotionResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjtQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL1VzZUl0ZW1Qb3Rp",
            "b25SZXNwb25zZS5wcm90bxIfUE9HT1Byb3Rvcy5OZXR3b3JraW5nLlJlc3Bv",
            "bnNlcyLhAQoVVXNlSXRlbVBvdGlvblJlc3BvbnNlEk0KBnJlc3VsdBgBIAEo",
            "DjI9LlBPR09Qcm90b3MuTmV0d29ya2luZy5SZXNwb25zZXMuVXNlSXRlbVBv",
            "dGlvblJlc3BvbnNlLlJlc3VsdBIPCgdzdGFtaW5hGAIgASgFImgKBlJlc3Vs",
            "dBIJCgVVTlNFVBAAEgsKB1NVQ0NFU1MQARIUChBFUlJPUl9OT19QT0tFTU9O",
            "EAISFAoQRVJST1JfQ0FOTk9UX1VTRRADEhoKFkVSUk9SX0RFUExPWUVEX1RP",
            "X0ZPUlQQBGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Cv3PKM.Protos.Networking.Responses.UseItemPotionResponse), global::Cv3PKM.Protos.Networking.Responses.UseItemPotionResponse.Parser, new[]{ "Result", "Stamina" }, null, new[]{ typeof(global::Cv3PKM.Protos.Networking.Responses.UseItemPotionResponse.Types.Result) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class UseItemPotionResponse : pb::IMessage<UseItemPotionResponse> {
    private static readonly pb::MessageParser<UseItemPotionResponse> _parser = new pb::MessageParser<UseItemPotionResponse>(() => new UseItemPotionResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UseItemPotionResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cv3PKM.Protos.Networking.Responses.UseItemPotionResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UseItemPotionResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UseItemPotionResponse(UseItemPotionResponse other) : this() {
      result_ = other.result_;
      stamina_ = other.stamina_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UseItemPotionResponse Clone() {
      return new UseItemPotionResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::Cv3PKM.Protos.Networking.Responses.UseItemPotionResponse.Types.Result result_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Cv3PKM.Protos.Networking.Responses.UseItemPotionResponse.Types.Result Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    /// <summary>Field number for the "stamina" field.</summary>
    public const int StaminaFieldNumber = 2;
    private int stamina_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Stamina {
      get { return stamina_; }
      set {
        stamina_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UseItemPotionResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UseItemPotionResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      if (Stamina != other.Stamina) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Result != 0) hash ^= Result.GetHashCode();
      if (Stamina != 0) hash ^= Stamina.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Result != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Result);
      }
      if (Stamina != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Stamina);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Result != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Result);
      }
      if (Stamina != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Stamina);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UseItemPotionResponse other) {
      if (other == null) {
        return;
      }
      if (other.Result != 0) {
        Result = other.Result;
      }
      if (other.Stamina != 0) {
        Stamina = other.Stamina;
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
          case 8: {
            result_ = (global::Cv3PKM.Protos.Networking.Responses.UseItemPotionResponse.Types.Result) input.ReadEnum();
            break;
          }
          case 16: {
            Stamina = input.ReadInt32();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the UseItemPotionResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Result {
        [pbr::OriginalName("UNSET")] Unset = 0,
        [pbr::OriginalName("SUCCESS")] Success = 1,
        [pbr::OriginalName("ERROR_NO_POKEMON")] ErrorNoPokemon = 2,
        [pbr::OriginalName("ERROR_CANNOT_USE")] ErrorCannotUse = 3,
        [pbr::OriginalName("ERROR_DEPLOYED_TO_FORT")] ErrorDeployedToFort = 4,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
