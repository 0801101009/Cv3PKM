// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Cv3PKM.Protos/Settings/FortSettings.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Cv3PKM.Protos.Settings {

  /// <summary>Holder for reflection information generated from Cv3PKM.Protos/Settings/FortSettings.proto</summary>
  public static partial class FortSettingsReflection {

    #region Descriptor
    /// <summary>File descriptor for Cv3PKM.Protos/Settings/FortSettings.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FortSettingsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZQT0dPUHJvdG9zL1NldHRpbmdzL0ZvcnRTZXR0aW5ncy5wcm90bxITUE9H",
            "T1Byb3Rvcy5TZXR0aW5ncyLkAQoMRm9ydFNldHRpbmdzEiAKGGludGVyYWN0",
            "aW9uX3JhbmdlX21ldGVycxgBIAEoARIiChptYXhfdG90YWxfZGVwbG95ZWRf",
            "cG9rZW1vbhgCIAEoBRIjChttYXhfcGxheWVyX2RlcGxveWVkX3Bva2Vtb24Y",
            "AyABKAUSIQoZZGVwbG95X3N0YW1pbmFfbXVsdGlwbGllchgEIAEoARIgChhk",
            "ZXBsb3lfYXR0YWNrX211bHRpcGxpZXIYBSABKAESJAocZmFyX2ludGVyYWN0",
            "aW9uX3JhbmdlX21ldGVycxgGIAEoAWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Cv3PKM.Protos.Settings.FortSettings), global::Cv3PKM.Protos.Settings.FortSettings.Parser, new[]{ "InteractionRangeMeters", "MaxTotalDeployedPokemon", "MaxPlayerDeployedPokemon", "DeployStaminaMultiplier", "DeployAttackMultiplier", "FarInteractionRangeMeters" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class FortSettings : pb::IMessage<FortSettings> {
    private static readonly pb::MessageParser<FortSettings> _parser = new pb::MessageParser<FortSettings>(() => new FortSettings());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<FortSettings> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cv3PKM.Protos.Settings.FortSettingsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FortSettings() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FortSettings(FortSettings other) : this() {
      interactionRangeMeters_ = other.interactionRangeMeters_;
      maxTotalDeployedPokemon_ = other.maxTotalDeployedPokemon_;
      maxPlayerDeployedPokemon_ = other.maxPlayerDeployedPokemon_;
      deployStaminaMultiplier_ = other.deployStaminaMultiplier_;
      deployAttackMultiplier_ = other.deployAttackMultiplier_;
      farInteractionRangeMeters_ = other.farInteractionRangeMeters_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FortSettings Clone() {
      return new FortSettings(this);
    }

    /// <summary>Field number for the "interaction_range_meters" field.</summary>
    public const int InteractionRangeMetersFieldNumber = 1;
    private double interactionRangeMeters_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double InteractionRangeMeters {
      get { return interactionRangeMeters_; }
      set {
        interactionRangeMeters_ = value;
      }
    }

    /// <summary>Field number for the "max_total_deployed_pokemon" field.</summary>
    public const int MaxTotalDeployedPokemonFieldNumber = 2;
    private int maxTotalDeployedPokemon_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int MaxTotalDeployedPokemon {
      get { return maxTotalDeployedPokemon_; }
      set {
        maxTotalDeployedPokemon_ = value;
      }
    }

    /// <summary>Field number for the "max_player_deployed_pokemon" field.</summary>
    public const int MaxPlayerDeployedPokemonFieldNumber = 3;
    private int maxPlayerDeployedPokemon_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int MaxPlayerDeployedPokemon {
      get { return maxPlayerDeployedPokemon_; }
      set {
        maxPlayerDeployedPokemon_ = value;
      }
    }

    /// <summary>Field number for the "deploy_stamina_multiplier" field.</summary>
    public const int DeployStaminaMultiplierFieldNumber = 4;
    private double deployStaminaMultiplier_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double DeployStaminaMultiplier {
      get { return deployStaminaMultiplier_; }
      set {
        deployStaminaMultiplier_ = value;
      }
    }

    /// <summary>Field number for the "deploy_attack_multiplier" field.</summary>
    public const int DeployAttackMultiplierFieldNumber = 5;
    private double deployAttackMultiplier_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double DeployAttackMultiplier {
      get { return deployAttackMultiplier_; }
      set {
        deployAttackMultiplier_ = value;
      }
    }

    /// <summary>Field number for the "far_interaction_range_meters" field.</summary>
    public const int FarInteractionRangeMetersFieldNumber = 6;
    private double farInteractionRangeMeters_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double FarInteractionRangeMeters {
      get { return farInteractionRangeMeters_; }
      set {
        farInteractionRangeMeters_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as FortSettings);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(FortSettings other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (InteractionRangeMeters != other.InteractionRangeMeters) return false;
      if (MaxTotalDeployedPokemon != other.MaxTotalDeployedPokemon) return false;
      if (MaxPlayerDeployedPokemon != other.MaxPlayerDeployedPokemon) return false;
      if (DeployStaminaMultiplier != other.DeployStaminaMultiplier) return false;
      if (DeployAttackMultiplier != other.DeployAttackMultiplier) return false;
      if (FarInteractionRangeMeters != other.FarInteractionRangeMeters) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (InteractionRangeMeters != 0D) hash ^= InteractionRangeMeters.GetHashCode();
      if (MaxTotalDeployedPokemon != 0) hash ^= MaxTotalDeployedPokemon.GetHashCode();
      if (MaxPlayerDeployedPokemon != 0) hash ^= MaxPlayerDeployedPokemon.GetHashCode();
      if (DeployStaminaMultiplier != 0D) hash ^= DeployStaminaMultiplier.GetHashCode();
      if (DeployAttackMultiplier != 0D) hash ^= DeployAttackMultiplier.GetHashCode();
      if (FarInteractionRangeMeters != 0D) hash ^= FarInteractionRangeMeters.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (InteractionRangeMeters != 0D) {
        output.WriteRawTag(9);
        output.WriteDouble(InteractionRangeMeters);
      }
      if (MaxTotalDeployedPokemon != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(MaxTotalDeployedPokemon);
      }
      if (MaxPlayerDeployedPokemon != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(MaxPlayerDeployedPokemon);
      }
      if (DeployStaminaMultiplier != 0D) {
        output.WriteRawTag(33);
        output.WriteDouble(DeployStaminaMultiplier);
      }
      if (DeployAttackMultiplier != 0D) {
        output.WriteRawTag(41);
        output.WriteDouble(DeployAttackMultiplier);
      }
      if (FarInteractionRangeMeters != 0D) {
        output.WriteRawTag(49);
        output.WriteDouble(FarInteractionRangeMeters);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (InteractionRangeMeters != 0D) {
        size += 1 + 8;
      }
      if (MaxTotalDeployedPokemon != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MaxTotalDeployedPokemon);
      }
      if (MaxPlayerDeployedPokemon != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MaxPlayerDeployedPokemon);
      }
      if (DeployStaminaMultiplier != 0D) {
        size += 1 + 8;
      }
      if (DeployAttackMultiplier != 0D) {
        size += 1 + 8;
      }
      if (FarInteractionRangeMeters != 0D) {
        size += 1 + 8;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(FortSettings other) {
      if (other == null) {
        return;
      }
      if (other.InteractionRangeMeters != 0D) {
        InteractionRangeMeters = other.InteractionRangeMeters;
      }
      if (other.MaxTotalDeployedPokemon != 0) {
        MaxTotalDeployedPokemon = other.MaxTotalDeployedPokemon;
      }
      if (other.MaxPlayerDeployedPokemon != 0) {
        MaxPlayerDeployedPokemon = other.MaxPlayerDeployedPokemon;
      }
      if (other.DeployStaminaMultiplier != 0D) {
        DeployStaminaMultiplier = other.DeployStaminaMultiplier;
      }
      if (other.DeployAttackMultiplier != 0D) {
        DeployAttackMultiplier = other.DeployAttackMultiplier;
      }
      if (other.FarInteractionRangeMeters != 0D) {
        FarInteractionRangeMeters = other.FarInteractionRangeMeters;
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
            InteractionRangeMeters = input.ReadDouble();
            break;
          }
          case 16: {
            MaxTotalDeployedPokemon = input.ReadInt32();
            break;
          }
          case 24: {
            MaxPlayerDeployedPokemon = input.ReadInt32();
            break;
          }
          case 33: {
            DeployStaminaMultiplier = input.ReadDouble();
            break;
          }
          case 41: {
            DeployAttackMultiplier = input.ReadDouble();
            break;
          }
          case 49: {
            FarInteractionRangeMeters = input.ReadDouble();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
