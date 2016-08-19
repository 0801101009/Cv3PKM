// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Cv3PKM.Protos/Networking/Responses/PlayerUpdateResponse.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Cv3PKM.Protos.Networking.Responses {

  /// <summary>Holder for reflection information generated from Cv3PKM.Protos/Networking/Responses/PlayerUpdateResponse.proto</summary>
  public static partial class PlayerUpdateResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for Cv3PKM.Protos/Networking/Responses/PlayerUpdateResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerUpdateResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjpQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL1BsYXllclVwZGF0",
            "ZVJlc3BvbnNlLnByb3RvEh9QT0dPUHJvdG9zLk5ldHdvcmtpbmcuUmVzcG9u",
            "c2VzGiJQT0dPUHJvdG9zL01hcC9Gb3J0L0ZvcnREYXRhLnByb3RvGihQT0dP",
            "UHJvdG9zL01hcC9Qb2tlbW9uL1dpbGRQb2tlbW9uLnByb3RvIpYBChRQbGF5",
            "ZXJVcGRhdGVSZXNwb25zZRI6Cg13aWxkX3Bva2Vtb25zGAEgAygLMiMuUE9H",
            "T1Byb3Rvcy5NYXAuUG9rZW1vbi5XaWxkUG9rZW1vbhIsCgVmb3J0cxgCIAMo",
            "CzIdLlBPR09Qcm90b3MuTWFwLkZvcnQuRm9ydERhdGESFAoMZm9ydHNfbmVh",
            "cmJ5GAMgASgFYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Cv3PKM.Protos.Map.Fort.FortDataReflection.Descriptor, global::Cv3PKM.Protos.Map.Pokemon.WildPokemonReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Cv3PKM.Protos.Networking.Responses.PlayerUpdateResponse), global::Cv3PKM.Protos.Networking.Responses.PlayerUpdateResponse.Parser, new[]{ "WildPokemons", "Forts", "FortsNearby" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PlayerUpdateResponse : pb::IMessage<PlayerUpdateResponse> {
    private static readonly pb::MessageParser<PlayerUpdateResponse> _parser = new pb::MessageParser<PlayerUpdateResponse>(() => new PlayerUpdateResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PlayerUpdateResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cv3PKM.Protos.Networking.Responses.PlayerUpdateResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlayerUpdateResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlayerUpdateResponse(PlayerUpdateResponse other) : this() {
      wildPokemons_ = other.wildPokemons_.Clone();
      forts_ = other.forts_.Clone();
      fortsNearby_ = other.fortsNearby_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlayerUpdateResponse Clone() {
      return new PlayerUpdateResponse(this);
    }

    /// <summary>Field number for the "wild_pokemons" field.</summary>
    public const int WildPokemonsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Cv3PKM.Protos.Map.Pokemon.WildPokemon> _repeated_wildPokemons_codec
        = pb::FieldCodec.ForMessage(10, global::Cv3PKM.Protos.Map.Pokemon.WildPokemon.Parser);
    private readonly pbc::RepeatedField<global::Cv3PKM.Protos.Map.Pokemon.WildPokemon> wildPokemons_ = new pbc::RepeatedField<global::Cv3PKM.Protos.Map.Pokemon.WildPokemon>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Cv3PKM.Protos.Map.Pokemon.WildPokemon> WildPokemons {
      get { return wildPokemons_; }
    }

    /// <summary>Field number for the "forts" field.</summary>
    public const int FortsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Cv3PKM.Protos.Map.Fort.FortData> _repeated_forts_codec
        = pb::FieldCodec.ForMessage(18, global::Cv3PKM.Protos.Map.Fort.FortData.Parser);
    private readonly pbc::RepeatedField<global::Cv3PKM.Protos.Map.Fort.FortData> forts_ = new pbc::RepeatedField<global::Cv3PKM.Protos.Map.Fort.FortData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Cv3PKM.Protos.Map.Fort.FortData> Forts {
      get { return forts_; }
    }

    /// <summary>Field number for the "forts_nearby" field.</summary>
    public const int FortsNearbyFieldNumber = 3;
    private int fortsNearby_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int FortsNearby {
      get { return fortsNearby_; }
      set {
        fortsNearby_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PlayerUpdateResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PlayerUpdateResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!wildPokemons_.Equals(other.wildPokemons_)) return false;
      if(!forts_.Equals(other.forts_)) return false;
      if (FortsNearby != other.FortsNearby) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= wildPokemons_.GetHashCode();
      hash ^= forts_.GetHashCode();
      if (FortsNearby != 0) hash ^= FortsNearby.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      wildPokemons_.WriteTo(output, _repeated_wildPokemons_codec);
      forts_.WriteTo(output, _repeated_forts_codec);
      if (FortsNearby != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(FortsNearby);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += wildPokemons_.CalculateSize(_repeated_wildPokemons_codec);
      size += forts_.CalculateSize(_repeated_forts_codec);
      if (FortsNearby != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(FortsNearby);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PlayerUpdateResponse other) {
      if (other == null) {
        return;
      }
      wildPokemons_.Add(other.wildPokemons_);
      forts_.Add(other.forts_);
      if (other.FortsNearby != 0) {
        FortsNearby = other.FortsNearby;
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
            wildPokemons_.AddEntriesFrom(input, _repeated_wildPokemons_codec);
            break;
          }
          case 18: {
            forts_.AddEntriesFrom(input, _repeated_forts_codec);
            break;
          }
          case 24: {
            FortsNearby = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
