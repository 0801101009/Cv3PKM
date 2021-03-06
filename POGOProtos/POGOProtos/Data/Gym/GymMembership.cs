// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Cv3PKM.Protos/Data/Gym/GymMembership.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Cv3PKM.Protos.Data.Gym {

  /// <summary>Holder for reflection information generated from Cv3PKM.Protos/Data/Gym/GymMembership.proto</summary>
  public static partial class GymMembershipReflection {

    #region Descriptor
    /// <summary>File descriptor for Cv3PKM.Protos/Data/Gym/GymMembership.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GymMembershipReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CidQT0dPUHJvdG9zL0RhdGEvR3ltL0d5bU1lbWJlcnNoaXAucHJvdG8SE1BP",
            "R09Qcm90b3MuRGF0YS5HeW0aIVBPR09Qcm90b3MvRGF0YS9Qb2tlbW9uRGF0",
            "YS5wcm90bxowUE9HT1Byb3Rvcy9EYXRhL1BsYXllci9QbGF5ZXJQdWJsaWNQ",
            "cm9maWxlLnByb3RvIpABCg1HeW1NZW1iZXJzaGlwEjIKDHBva2Vtb25fZGF0",
            "YRgBIAEoCzIcLlBPR09Qcm90b3MuRGF0YS5Qb2tlbW9uRGF0YRJLChZ0cmFp",
            "bmVyX3B1YmxpY19wcm9maWxlGAIgASgLMisuUE9HT1Byb3Rvcy5EYXRhLlBs",
            "YXllci5QbGF5ZXJQdWJsaWNQcm9maWxlYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Cv3PKM.Protos.Data.PokemonDataReflection.Descriptor, global::Cv3PKM.Protos.Data.Player.PlayerPublicProfileReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Cv3PKM.Protos.Data.Gym.GymMembership), global::Cv3PKM.Protos.Data.Gym.GymMembership.Parser, new[]{ "PokemonData", "TrainerPublicProfile" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GymMembership : pb::IMessage<GymMembership> {
    private static readonly pb::MessageParser<GymMembership> _parser = new pb::MessageParser<GymMembership>(() => new GymMembership());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GymMembership> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cv3PKM.Protos.Data.Gym.GymMembershipReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GymMembership() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GymMembership(GymMembership other) : this() {
      PokemonData = other.pokemonData_ != null ? other.PokemonData.Clone() : null;
      TrainerPublicProfile = other.trainerPublicProfile_ != null ? other.TrainerPublicProfile.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GymMembership Clone() {
      return new GymMembership(this);
    }

    /// <summary>Field number for the "pokemon_data" field.</summary>
    public const int PokemonDataFieldNumber = 1;
    private global::Cv3PKM.Protos.Data.PokemonData pokemonData_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Cv3PKM.Protos.Data.PokemonData PokemonData {
      get { return pokemonData_; }
      set {
        pokemonData_ = value;
      }
    }

    /// <summary>Field number for the "trainer_public_profile" field.</summary>
    public const int TrainerPublicProfileFieldNumber = 2;
    private global::Cv3PKM.Protos.Data.Player.PlayerPublicProfile trainerPublicProfile_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Cv3PKM.Protos.Data.Player.PlayerPublicProfile TrainerPublicProfile {
      get { return trainerPublicProfile_; }
      set {
        trainerPublicProfile_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GymMembership);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GymMembership other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(PokemonData, other.PokemonData)) return false;
      if (!object.Equals(TrainerPublicProfile, other.TrainerPublicProfile)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (pokemonData_ != null) hash ^= PokemonData.GetHashCode();
      if (trainerPublicProfile_ != null) hash ^= TrainerPublicProfile.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (pokemonData_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(PokemonData);
      }
      if (trainerPublicProfile_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(TrainerPublicProfile);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (pokemonData_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PokemonData);
      }
      if (trainerPublicProfile_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TrainerPublicProfile);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GymMembership other) {
      if (other == null) {
        return;
      }
      if (other.pokemonData_ != null) {
        if (pokemonData_ == null) {
          pokemonData_ = new global::Cv3PKM.Protos.Data.PokemonData();
        }
        PokemonData.MergeFrom(other.PokemonData);
      }
      if (other.trainerPublicProfile_ != null) {
        if (trainerPublicProfile_ == null) {
          trainerPublicProfile_ = new global::Cv3PKM.Protos.Data.Player.PlayerPublicProfile();
        }
        TrainerPublicProfile.MergeFrom(other.TrainerPublicProfile);
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
            if (pokemonData_ == null) {
              pokemonData_ = new global::Cv3PKM.Protos.Data.PokemonData();
            }
            input.ReadMessage(pokemonData_);
            break;
          }
          case 18: {
            if (trainerPublicProfile_ == null) {
              trainerPublicProfile_ = new global::Cv3PKM.Protos.Data.Player.PlayerPublicProfile();
            }
            input.ReadMessage(trainerPublicProfile_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
