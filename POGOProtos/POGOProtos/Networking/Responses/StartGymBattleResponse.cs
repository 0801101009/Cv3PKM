// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Cv3PKM.Protos/Networking/Responses/StartGymBattleResponse.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Cv3PKM.Protos.Networking.Responses {

  /// <summary>Holder for reflection information generated from Cv3PKM.Protos/Networking/Responses/StartGymBattleResponse.proto</summary>
  public static partial class StartGymBattleResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for Cv3PKM.Protos/Networking/Responses/StartGymBattleResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StartGymBattleResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjxQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL1N0YXJ0R3ltQmF0",
            "dGxlUmVzcG9uc2UucHJvdG8SH1BPR09Qcm90b3MuTmV0d29ya2luZy5SZXNw",
            "b25zZXMaJlBPR09Qcm90b3MvRGF0YS9CYXR0bGUvQmF0dGxlTG9nLnByb3Rv",
            "Gi5QT0dPUHJvdG9zL0RhdGEvQmF0dGxlL0JhdHRsZVBhcnRpY2lwYW50LnBy",
            "b3RvIq8FChZTdGFydEd5bUJhdHRsZVJlc3BvbnNlEk4KBnJlc3VsdBgBIAEo",
            "DjI+LlBPR09Qcm90b3MuTmV0d29ya2luZy5SZXNwb25zZXMuU3RhcnRHeW1C",
            "YXR0bGVSZXNwb25zZS5SZXN1bHQSIQoZYmF0dGxlX3N0YXJ0X3RpbWVzdGFt",
            "cF9tcxgCIAEoAxIfChdiYXR0bGVfZW5kX3RpbWVzdGFtcF9tcxgDIAEoAxIR",
            "CgliYXR0bGVfaWQYBCABKAkSOwoIZGVmZW5kZXIYBSABKAsyKS5QT0dPUHJv",
            "dG9zLkRhdGEuQmF0dGxlLkJhdHRsZVBhcnRpY2lwYW50EjUKCmJhdHRsZV9s",
            "b2cYBiABKAsyIS5QT0dPUHJvdG9zLkRhdGEuQmF0dGxlLkJhdHRsZUxvZyL5",
            "AgoGUmVzdWx0EgkKBVVOU0VUEAASCwoHU1VDQ0VTUxABEhcKE0VSUk9SX0dZ",
            "TV9OT1RfRk9VTkQQAhIVChFFUlJPUl9HWU1fTkVVVFJBTBADEhgKFEVSUk9S",
            "X0dZTV9XUk9OR19URUFNEAQSEwoPRVJST1JfR1lNX0VNUFRZEAUSGgoWRVJS",
            "T1JfSU5WQUxJRF9ERUZFTkRFUhAGEikKJUVSUk9SX1RSQUlOSU5HX0lOVkFM",
            "SURfQVRUQUNLRVJfQ09VTlQQBxIdChlFUlJPUl9BTExfUE9LRU1PTl9GQUlO",
            "VEVEEAgSGgoWRVJST1JfVE9PX01BTllfQkFUVExFUxAJEhoKFkVSUk9SX1RP",
            "T19NQU5ZX1BMQVlFUlMQChIcChhFUlJPUl9HWU1fQkFUVExFX0xPQ0tPVVQQ",
            "CxIkCiBFUlJPUl9QTEFZRVJfQkVMT1dfTUlOSU1VTV9MRVZFTBAMEhYKEkVS",
            "Uk9SX05PVF9JTl9SQU5HRRANYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Cv3PKM.Protos.Data.Battle.BattleLogReflection.Descriptor, global::Cv3PKM.Protos.Data.Battle.BattleParticipantReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Cv3PKM.Protos.Networking.Responses.StartGymBattleResponse), global::Cv3PKM.Protos.Networking.Responses.StartGymBattleResponse.Parser, new[]{ "Result", "BattleStartTimestampMs", "BattleEndTimestampMs", "BattleId", "Defender", "BattleLog" }, null, new[]{ typeof(global::Cv3PKM.Protos.Networking.Responses.StartGymBattleResponse.Types.Result) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class StartGymBattleResponse : pb::IMessage<StartGymBattleResponse> {
    private static readonly pb::MessageParser<StartGymBattleResponse> _parser = new pb::MessageParser<StartGymBattleResponse>(() => new StartGymBattleResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<StartGymBattleResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cv3PKM.Protos.Networking.Responses.StartGymBattleResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StartGymBattleResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StartGymBattleResponse(StartGymBattleResponse other) : this() {
      result_ = other.result_;
      battleStartTimestampMs_ = other.battleStartTimestampMs_;
      battleEndTimestampMs_ = other.battleEndTimestampMs_;
      battleId_ = other.battleId_;
      Defender = other.defender_ != null ? other.Defender.Clone() : null;
      BattleLog = other.battleLog_ != null ? other.BattleLog.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StartGymBattleResponse Clone() {
      return new StartGymBattleResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::Cv3PKM.Protos.Networking.Responses.StartGymBattleResponse.Types.Result result_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Cv3PKM.Protos.Networking.Responses.StartGymBattleResponse.Types.Result Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    /// <summary>Field number for the "battle_start_timestamp_ms" field.</summary>
    public const int BattleStartTimestampMsFieldNumber = 2;
    private long battleStartTimestampMs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long BattleStartTimestampMs {
      get { return battleStartTimestampMs_; }
      set {
        battleStartTimestampMs_ = value;
      }
    }

    /// <summary>Field number for the "battle_end_timestamp_ms" field.</summary>
    public const int BattleEndTimestampMsFieldNumber = 3;
    private long battleEndTimestampMs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long BattleEndTimestampMs {
      get { return battleEndTimestampMs_; }
      set {
        battleEndTimestampMs_ = value;
      }
    }

    /// <summary>Field number for the "battle_id" field.</summary>
    public const int BattleIdFieldNumber = 4;
    private string battleId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string BattleId {
      get { return battleId_; }
      set {
        battleId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "defender" field.</summary>
    public const int DefenderFieldNumber = 5;
    private global::Cv3PKM.Protos.Data.Battle.BattleParticipant defender_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Cv3PKM.Protos.Data.Battle.BattleParticipant Defender {
      get { return defender_; }
      set {
        defender_ = value;
      }
    }

    /// <summary>Field number for the "battle_log" field.</summary>
    public const int BattleLogFieldNumber = 6;
    private global::Cv3PKM.Protos.Data.Battle.BattleLog battleLog_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Cv3PKM.Protos.Data.Battle.BattleLog BattleLog {
      get { return battleLog_; }
      set {
        battleLog_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as StartGymBattleResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(StartGymBattleResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      if (BattleStartTimestampMs != other.BattleStartTimestampMs) return false;
      if (BattleEndTimestampMs != other.BattleEndTimestampMs) return false;
      if (BattleId != other.BattleId) return false;
      if (!object.Equals(Defender, other.Defender)) return false;
      if (!object.Equals(BattleLog, other.BattleLog)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Result != 0) hash ^= Result.GetHashCode();
      if (BattleStartTimestampMs != 0L) hash ^= BattleStartTimestampMs.GetHashCode();
      if (BattleEndTimestampMs != 0L) hash ^= BattleEndTimestampMs.GetHashCode();
      if (BattleId.Length != 0) hash ^= BattleId.GetHashCode();
      if (defender_ != null) hash ^= Defender.GetHashCode();
      if (battleLog_ != null) hash ^= BattleLog.GetHashCode();
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
      if (BattleStartTimestampMs != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(BattleStartTimestampMs);
      }
      if (BattleEndTimestampMs != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(BattleEndTimestampMs);
      }
      if (BattleId.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(BattleId);
      }
      if (defender_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(Defender);
      }
      if (battleLog_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(BattleLog);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Result != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Result);
      }
      if (BattleStartTimestampMs != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(BattleStartTimestampMs);
      }
      if (BattleEndTimestampMs != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(BattleEndTimestampMs);
      }
      if (BattleId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(BattleId);
      }
      if (defender_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Defender);
      }
      if (battleLog_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BattleLog);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(StartGymBattleResponse other) {
      if (other == null) {
        return;
      }
      if (other.Result != 0) {
        Result = other.Result;
      }
      if (other.BattleStartTimestampMs != 0L) {
        BattleStartTimestampMs = other.BattleStartTimestampMs;
      }
      if (other.BattleEndTimestampMs != 0L) {
        BattleEndTimestampMs = other.BattleEndTimestampMs;
      }
      if (other.BattleId.Length != 0) {
        BattleId = other.BattleId;
      }
      if (other.defender_ != null) {
        if (defender_ == null) {
          defender_ = new global::Cv3PKM.Protos.Data.Battle.BattleParticipant();
        }
        Defender.MergeFrom(other.Defender);
      }
      if (other.battleLog_ != null) {
        if (battleLog_ == null) {
          battleLog_ = new global::Cv3PKM.Protos.Data.Battle.BattleLog();
        }
        BattleLog.MergeFrom(other.BattleLog);
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
            result_ = (global::Cv3PKM.Protos.Networking.Responses.StartGymBattleResponse.Types.Result) input.ReadEnum();
            break;
          }
          case 16: {
            BattleStartTimestampMs = input.ReadInt64();
            break;
          }
          case 24: {
            BattleEndTimestampMs = input.ReadInt64();
            break;
          }
          case 34: {
            BattleId = input.ReadString();
            break;
          }
          case 42: {
            if (defender_ == null) {
              defender_ = new global::Cv3PKM.Protos.Data.Battle.BattleParticipant();
            }
            input.ReadMessage(defender_);
            break;
          }
          case 50: {
            if (battleLog_ == null) {
              battleLog_ = new global::Cv3PKM.Protos.Data.Battle.BattleLog();
            }
            input.ReadMessage(battleLog_);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the StartGymBattleResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Result {
        [pbr::OriginalName("UNSET")] Unset = 0,
        [pbr::OriginalName("SUCCESS")] Success = 1,
        [pbr::OriginalName("ERROR_GYM_NOT_FOUND")] ErrorGymNotFound = 2,
        [pbr::OriginalName("ERROR_GYM_NEUTRAL")] ErrorGymNeutral = 3,
        [pbr::OriginalName("ERROR_GYM_WRONG_TEAM")] ErrorGymWrongTeam = 4,
        [pbr::OriginalName("ERROR_GYM_EMPTY")] ErrorGymEmpty = 5,
        [pbr::OriginalName("ERROR_INVALID_DEFENDER")] ErrorInvalidDefender = 6,
        [pbr::OriginalName("ERROR_TRAINING_INVALID_ATTACKER_COUNT")] ErrorTrainingInvalidAttackerCount = 7,
        [pbr::OriginalName("ERROR_ALL_POKEMON_FAINTED")] ErrorAllPokemonFainted = 8,
        [pbr::OriginalName("ERROR_TOO_MANY_BATTLES")] ErrorTooManyBattles = 9,
        [pbr::OriginalName("ERROR_TOO_MANY_PLAYERS")] ErrorTooManyPlayers = 10,
        [pbr::OriginalName("ERROR_GYM_BATTLE_LOCKOUT")] ErrorGymBattleLockout = 11,
        [pbr::OriginalName("ERROR_PLAYER_BELOW_MINIMUM_LEVEL")] ErrorPlayerBelowMinimumLevel = 12,
        [pbr::OriginalName("ERROR_NOT_IN_RANGE")] ErrorNotInRange = 13,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
