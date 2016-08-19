// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Cv3PKM.Protos/Networking/Responses/SetContactSettingsResponse.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Cv3PKM.Protos.Networking.Responses {

  /// <summary>Holder for reflection information generated from Cv3PKM.Protos/Networking/Responses/SetContactSettingsResponse.proto</summary>
  public static partial class SetContactSettingsResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for Cv3PKM.Protos/Networking/Responses/SetContactSettingsResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SetContactSettingsResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkBQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL1NldENvbnRhY3RT",
            "ZXR0aW5nc1Jlc3BvbnNlLnByb3RvEh9QT0dPUHJvdG9zLk5ldHdvcmtpbmcu",
            "UmVzcG9uc2VzGiBQT0dPUHJvdG9zL0RhdGEvUGxheWVyRGF0YS5wcm90byLR",
            "AQoaU2V0Q29udGFjdFNldHRpbmdzUmVzcG9uc2USUgoGc3RhdHVzGAEgASgO",
            "MkIuUE9HT1Byb3Rvcy5OZXR3b3JraW5nLlJlc3BvbnNlcy5TZXRDb250YWN0",
            "U2V0dGluZ3NSZXNwb25zZS5TdGF0dXMSMAoLcGxheWVyX2RhdGEYAiABKAsy",
            "Gy5QT0dPUHJvdG9zLkRhdGEuUGxheWVyRGF0YSItCgZTdGF0dXMSCQoFVU5T",
            "RVQQABILCgdTVUNDRVNTEAESCwoHRkFJTFVSRRACYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Cv3PKM.Protos.Data.PlayerDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Cv3PKM.Protos.Networking.Responses.SetContactSettingsResponse), global::Cv3PKM.Protos.Networking.Responses.SetContactSettingsResponse.Parser, new[]{ "Status", "PlayerData" }, null, new[]{ typeof(global::Cv3PKM.Protos.Networking.Responses.SetContactSettingsResponse.Types.Status) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SetContactSettingsResponse : pb::IMessage<SetContactSettingsResponse> {
    private static readonly pb::MessageParser<SetContactSettingsResponse> _parser = new pb::MessageParser<SetContactSettingsResponse>(() => new SetContactSettingsResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SetContactSettingsResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cv3PKM.Protos.Networking.Responses.SetContactSettingsResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetContactSettingsResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetContactSettingsResponse(SetContactSettingsResponse other) : this() {
      status_ = other.status_;
      PlayerData = other.playerData_ != null ? other.PlayerData.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetContactSettingsResponse Clone() {
      return new SetContactSettingsResponse(this);
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 1;
    private global::Cv3PKM.Protos.Networking.Responses.SetContactSettingsResponse.Types.Status status_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Cv3PKM.Protos.Networking.Responses.SetContactSettingsResponse.Types.Status Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "player_data" field.</summary>
    public const int PlayerDataFieldNumber = 2;
    private global::Cv3PKM.Protos.Data.PlayerData playerData_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Cv3PKM.Protos.Data.PlayerData PlayerData {
      get { return playerData_; }
      set {
        playerData_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SetContactSettingsResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SetContactSettingsResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Status != other.Status) return false;
      if (!object.Equals(PlayerData, other.PlayerData)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Status != 0) hash ^= Status.GetHashCode();
      if (playerData_ != null) hash ^= PlayerData.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Status != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Status);
      }
      if (playerData_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(PlayerData);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Status != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (playerData_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PlayerData);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SetContactSettingsResponse other) {
      if (other == null) {
        return;
      }
      if (other.Status != 0) {
        Status = other.Status;
      }
      if (other.playerData_ != null) {
        if (playerData_ == null) {
          playerData_ = new global::Cv3PKM.Protos.Data.PlayerData();
        }
        PlayerData.MergeFrom(other.PlayerData);
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
            status_ = (global::Cv3PKM.Protos.Networking.Responses.SetContactSettingsResponse.Types.Status) input.ReadEnum();
            break;
          }
          case 18: {
            if (playerData_ == null) {
              playerData_ = new global::Cv3PKM.Protos.Data.PlayerData();
            }
            input.ReadMessage(playerData_);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the SetContactSettingsResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Status {
        [pbr::OriginalName("UNSET")] Unset = 0,
        [pbr::OriginalName("SUCCESS")] Success = 1,
        [pbr::OriginalName("FAILURE")] Failure = 2,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code