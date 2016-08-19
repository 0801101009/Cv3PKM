// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Cv3PKM.Protos/Networking/Requests/Messages/EncounterMessage.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Cv3PKM.Protos.Networking.Requests.Messages {

  /// <summary>Holder for reflection information generated from Cv3PKM.Protos/Networking/Requests/Messages/EncounterMessage.proto</summary>
  public static partial class EncounterMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for Cv3PKM.Protos/Networking/Requests/Messages/EncounterMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EncounterMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj5QT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVxdWVzdHMvTWVzc2FnZXMvRW5j",
            "b3VudGVyTWVzc2FnZS5wcm90bxInUE9HT1Byb3Rvcy5OZXR3b3JraW5nLlJl",
            "cXVlc3RzLk1lc3NhZ2VzInMKEEVuY291bnRlck1lc3NhZ2USFAoMZW5jb3Vu",
            "dGVyX2lkGAEgASgGEhYKDnNwYXduX3BvaW50X2lkGAIgASgJEhcKD3BsYXll",
            "cl9sYXRpdHVkZRgDIAEoARIYChBwbGF5ZXJfbG9uZ2l0dWRlGAQgASgBYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Cv3PKM.Protos.Networking.Requests.Messages.EncounterMessage), global::Cv3PKM.Protos.Networking.Requests.Messages.EncounterMessage.Parser, new[]{ "EncounterId", "SpawnPointId", "PlayerLatitude", "PlayerLongitude" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EncounterMessage : pb::IMessage<EncounterMessage> {
    private static readonly pb::MessageParser<EncounterMessage> _parser = new pb::MessageParser<EncounterMessage>(() => new EncounterMessage());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<EncounterMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cv3PKM.Protos.Networking.Requests.Messages.EncounterMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EncounterMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EncounterMessage(EncounterMessage other) : this() {
      encounterId_ = other.encounterId_;
      spawnPointId_ = other.spawnPointId_;
      playerLatitude_ = other.playerLatitude_;
      playerLongitude_ = other.playerLongitude_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EncounterMessage Clone() {
      return new EncounterMessage(this);
    }

    /// <summary>Field number for the "encounter_id" field.</summary>
    public const int EncounterIdFieldNumber = 1;
    private ulong encounterId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong EncounterId {
      get { return encounterId_; }
      set {
        encounterId_ = value;
      }
    }

    /// <summary>Field number for the "spawn_point_id" field.</summary>
    public const int SpawnPointIdFieldNumber = 2;
    private string spawnPointId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SpawnPointId {
      get { return spawnPointId_; }
      set {
        spawnPointId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "player_latitude" field.</summary>
    public const int PlayerLatitudeFieldNumber = 3;
    private double playerLatitude_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double PlayerLatitude {
      get { return playerLatitude_; }
      set {
        playerLatitude_ = value;
      }
    }

    /// <summary>Field number for the "player_longitude" field.</summary>
    public const int PlayerLongitudeFieldNumber = 4;
    private double playerLongitude_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double PlayerLongitude {
      get { return playerLongitude_; }
      set {
        playerLongitude_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as EncounterMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(EncounterMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EncounterId != other.EncounterId) return false;
      if (SpawnPointId != other.SpawnPointId) return false;
      if (PlayerLatitude != other.PlayerLatitude) return false;
      if (PlayerLongitude != other.PlayerLongitude) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (EncounterId != 0UL) hash ^= EncounterId.GetHashCode();
      if (SpawnPointId.Length != 0) hash ^= SpawnPointId.GetHashCode();
      if (PlayerLatitude != 0D) hash ^= PlayerLatitude.GetHashCode();
      if (PlayerLongitude != 0D) hash ^= PlayerLongitude.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (EncounterId != 0UL) {
        output.WriteRawTag(9);
        output.WriteFixed64(EncounterId);
      }
      if (SpawnPointId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(SpawnPointId);
      }
      if (PlayerLatitude != 0D) {
        output.WriteRawTag(25);
        output.WriteDouble(PlayerLatitude);
      }
      if (PlayerLongitude != 0D) {
        output.WriteRawTag(33);
        output.WriteDouble(PlayerLongitude);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (EncounterId != 0UL) {
        size += 1 + 8;
      }
      if (SpawnPointId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SpawnPointId);
      }
      if (PlayerLatitude != 0D) {
        size += 1 + 8;
      }
      if (PlayerLongitude != 0D) {
        size += 1 + 8;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(EncounterMessage other) {
      if (other == null) {
        return;
      }
      if (other.EncounterId != 0UL) {
        EncounterId = other.EncounterId;
      }
      if (other.SpawnPointId.Length != 0) {
        SpawnPointId = other.SpawnPointId;
      }
      if (other.PlayerLatitude != 0D) {
        PlayerLatitude = other.PlayerLatitude;
      }
      if (other.PlayerLongitude != 0D) {
        PlayerLongitude = other.PlayerLongitude;
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
          case 9: {
            EncounterId = input.ReadFixed64();
            break;
          }
          case 18: {
            SpawnPointId = input.ReadString();
            break;
          }
          case 25: {
            PlayerLatitude = input.ReadDouble();
            break;
          }
          case 33: {
            PlayerLongitude = input.ReadDouble();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
