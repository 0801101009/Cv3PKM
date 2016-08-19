// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Cv3PKM.Protos/Networking/Responses/UpgradePokemonResponse.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Cv3PKM.Protos.Networking.Responses {

  /// <summary>Holder for reflection information generated from Cv3PKM.Protos/Networking/Responses/UpgradePokemonResponse.proto</summary>
  public static partial class UpgradePokemonResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for Cv3PKM.Protos/Networking/Responses/UpgradePokemonResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UpgradePokemonResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjxQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL1VwZ3JhZGVQb2tl",
            "bW9uUmVzcG9uc2UucHJvdG8SH1BPR09Qcm90b3MuTmV0d29ya2luZy5SZXNw",
            "b25zZXMaIVBPR09Qcm90b3MvRGF0YS9Qb2tlbW9uRGF0YS5wcm90byLCAgoW",
            "VXBncmFkZVBva2Vtb25SZXNwb25zZRJOCgZyZXN1bHQYASABKA4yPi5QT0dP",
            "UHJvdG9zLk5ldHdvcmtpbmcuUmVzcG9uc2VzLlVwZ3JhZGVQb2tlbW9uUmVz",
            "cG9uc2UuUmVzdWx0EjYKEHVwZ3JhZGVkX3Bva2Vtb24YAiABKAsyHC5QT0dP",
            "UHJvdG9zLkRhdGEuUG9rZW1vbkRhdGEinwEKBlJlc3VsdBIJCgVVTlNFVBAA",
            "EgsKB1NVQ0NFU1MQARIbChdFUlJPUl9QT0tFTU9OX05PVF9GT1VORBACEiAK",
            "HEVSUk9SX0lOU1VGRklDSUVOVF9SRVNPVVJDRVMQAxIfChtFUlJPUl9VUEdS",
            "QURFX05PVF9BVkFJTEFCTEUQBBIdChlFUlJPUl9QT0tFTU9OX0lTX0RFUExP",
            "WUVEEAViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Cv3PKM.Protos.Data.PokemonDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Cv3PKM.Protos.Networking.Responses.UpgradePokemonResponse), global::Cv3PKM.Protos.Networking.Responses.UpgradePokemonResponse.Parser, new[]{ "Result", "UpgradedPokemon" }, null, new[]{ typeof(global::Cv3PKM.Protos.Networking.Responses.UpgradePokemonResponse.Types.Result) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class UpgradePokemonResponse : pb::IMessage<UpgradePokemonResponse> {
    private static readonly pb::MessageParser<UpgradePokemonResponse> _parser = new pb::MessageParser<UpgradePokemonResponse>(() => new UpgradePokemonResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UpgradePokemonResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cv3PKM.Protos.Networking.Responses.UpgradePokemonResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UpgradePokemonResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UpgradePokemonResponse(UpgradePokemonResponse other) : this() {
      result_ = other.result_;
      UpgradedPokemon = other.upgradedPokemon_ != null ? other.UpgradedPokemon.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UpgradePokemonResponse Clone() {
      return new UpgradePokemonResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::Cv3PKM.Protos.Networking.Responses.UpgradePokemonResponse.Types.Result result_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Cv3PKM.Protos.Networking.Responses.UpgradePokemonResponse.Types.Result Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    /// <summary>Field number for the "upgraded_pokemon" field.</summary>
    public const int UpgradedPokemonFieldNumber = 2;
    private global::Cv3PKM.Protos.Data.PokemonData upgradedPokemon_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Cv3PKM.Protos.Data.PokemonData UpgradedPokemon {
      get { return upgradedPokemon_; }
      set {
        upgradedPokemon_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UpgradePokemonResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UpgradePokemonResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      if (!object.Equals(UpgradedPokemon, other.UpgradedPokemon)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Result != 0) hash ^= Result.GetHashCode();
      if (upgradedPokemon_ != null) hash ^= UpgradedPokemon.GetHashCode();
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
      if (upgradedPokemon_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(UpgradedPokemon);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Result != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Result);
      }
      if (upgradedPokemon_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UpgradedPokemon);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UpgradePokemonResponse other) {
      if (other == null) {
        return;
      }
      if (other.Result != 0) {
        Result = other.Result;
      }
      if (other.upgradedPokemon_ != null) {
        if (upgradedPokemon_ == null) {
          upgradedPokemon_ = new global::Cv3PKM.Protos.Data.PokemonData();
        }
        UpgradedPokemon.MergeFrom(other.UpgradedPokemon);
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
            result_ = (global::Cv3PKM.Protos.Networking.Responses.UpgradePokemonResponse.Types.Result) input.ReadEnum();
            break;
          }
          case 18: {
            if (upgradedPokemon_ == null) {
              upgradedPokemon_ = new global::Cv3PKM.Protos.Data.PokemonData();
            }
            input.ReadMessage(upgradedPokemon_);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the UpgradePokemonResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Result {
        [pbr::OriginalName("UNSET")] Unset = 0,
        [pbr::OriginalName("SUCCESS")] Success = 1,
        [pbr::OriginalName("ERROR_POKEMON_NOT_FOUND")] ErrorPokemonNotFound = 2,
        [pbr::OriginalName("ERROR_INSUFFICIENT_RESOURCES")] ErrorInsufficientResources = 3,
        [pbr::OriginalName("ERROR_UPGRADE_NOT_AVAILABLE")] ErrorUpgradeNotAvailable = 4,
        [pbr::OriginalName("ERROR_POKEMON_IS_DEPLOYED")] ErrorPokemonIsDeployed = 5,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
