// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Cv3PKM.Protos/Map/Fort/FortLureInfo.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Cv3PKM.Protos.Map.Fort {

  /// <summary>Holder for reflection information generated from Cv3PKM.Protos/Map/Fort/FortLureInfo.proto</summary>
  public static partial class FortLureInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for Cv3PKM.Protos/Map/Fort/FortLureInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FortLureInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZQT0dPUHJvdG9zL01hcC9Gb3J0L0ZvcnRMdXJlSW5mby5wcm90bxITUE9H",
            "T1Byb3Rvcy5NYXAuRm9ydBogUE9HT1Byb3Rvcy9FbnVtcy9Qb2tlbW9uSWQu",
            "cHJvdG8ikAEKDEZvcnRMdXJlSW5mbxIPCgdmb3J0X2lkGAEgASgJEhQKDGVu",
            "Y291bnRlcl9pZBgCIAEoBhI2ChFhY3RpdmVfcG9rZW1vbl9pZBgDIAEoDjIb",
            "LlBPR09Qcm90b3MuRW51bXMuUG9rZW1vbklkEiEKGWx1cmVfZXhwaXJlc190",
            "aW1lc3RhbXBfbXMYBCABKANiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Cv3PKM.Protos.Enums.PokemonIdReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Cv3PKM.Protos.Map.Fort.FortLureInfo), global::Cv3PKM.Protos.Map.Fort.FortLureInfo.Parser, new[]{ "FortId", "EncounterId", "ActivePokemonId", "LureExpiresTimestampMs" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class FortLureInfo : pb::IMessage<FortLureInfo> {
    private static readonly pb::MessageParser<FortLureInfo> _parser = new pb::MessageParser<FortLureInfo>(() => new FortLureInfo());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<FortLureInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cv3PKM.Protos.Map.Fort.FortLureInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FortLureInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FortLureInfo(FortLureInfo other) : this() {
      fortId_ = other.fortId_;
      encounterId_ = other.encounterId_;
      activePokemonId_ = other.activePokemonId_;
      lureExpiresTimestampMs_ = other.lureExpiresTimestampMs_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FortLureInfo Clone() {
      return new FortLureInfo(this);
    }

    /// <summary>Field number for the "fort_id" field.</summary>
    public const int FortIdFieldNumber = 1;
    private string fortId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string FortId {
      get { return fortId_; }
      set {
        fortId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "encounter_id" field.</summary>
    public const int EncounterIdFieldNumber = 2;
    private ulong encounterId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong EncounterId {
      get { return encounterId_; }
      set {
        encounterId_ = value;
      }
    }

    /// <summary>Field number for the "active_pokemon_id" field.</summary>
    public const int ActivePokemonIdFieldNumber = 3;
    private global::Cv3PKM.Protos.Enums.PokemonId activePokemonId_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Cv3PKM.Protos.Enums.PokemonId ActivePokemonId {
      get { return activePokemonId_; }
      set {
        activePokemonId_ = value;
      }
    }

    /// <summary>Field number for the "lure_expires_timestamp_ms" field.</summary>
    public const int LureExpiresTimestampMsFieldNumber = 4;
    private long lureExpiresTimestampMs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long LureExpiresTimestampMs {
      get { return lureExpiresTimestampMs_; }
      set {
        lureExpiresTimestampMs_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as FortLureInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(FortLureInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FortId != other.FortId) return false;
      if (EncounterId != other.EncounterId) return false;
      if (ActivePokemonId != other.ActivePokemonId) return false;
      if (LureExpiresTimestampMs != other.LureExpiresTimestampMs) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (FortId.Length != 0) hash ^= FortId.GetHashCode();
      if (EncounterId != 0UL) hash ^= EncounterId.GetHashCode();
      if (ActivePokemonId != 0) hash ^= ActivePokemonId.GetHashCode();
      if (LureExpiresTimestampMs != 0L) hash ^= LureExpiresTimestampMs.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (FortId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(FortId);
      }
      if (EncounterId != 0UL) {
        output.WriteRawTag(17);
        output.WriteFixed64(EncounterId);
      }
      if (ActivePokemonId != 0) {
        output.WriteRawTag(24);
        output.WriteEnum((int) ActivePokemonId);
      }
      if (LureExpiresTimestampMs != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(LureExpiresTimestampMs);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (FortId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FortId);
      }
      if (EncounterId != 0UL) {
        size += 1 + 8;
      }
      if (ActivePokemonId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ActivePokemonId);
      }
      if (LureExpiresTimestampMs != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(LureExpiresTimestampMs);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(FortLureInfo other) {
      if (other == null) {
        return;
      }
      if (other.FortId.Length != 0) {
        FortId = other.FortId;
      }
      if (other.EncounterId != 0UL) {
        EncounterId = other.EncounterId;
      }
      if (other.ActivePokemonId != 0) {
        ActivePokemonId = other.ActivePokemonId;
      }
      if (other.LureExpiresTimestampMs != 0L) {
        LureExpiresTimestampMs = other.LureExpiresTimestampMs;
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
            FortId = input.ReadString();
            break;
          }
          case 17: {
            EncounterId = input.ReadFixed64();
            break;
          }
          case 24: {
            activePokemonId_ = (global::Cv3PKM.Protos.Enums.PokemonId) input.ReadEnum();
            break;
          }
          case 32: {
            LureExpiresTimestampMs = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code