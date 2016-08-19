// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Cv3PKM.Protos/Settings/Master/Pokemon/StatsAttributes.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Cv3PKM.Protos.Settings.Master.Pokemon {

  /// <summary>Holder for reflection information generated from Cv3PKM.Protos/Settings/Master/Pokemon/StatsAttributes.proto</summary>
  public static partial class StatsAttributesReflection {

    #region Descriptor
    /// <summary>File descriptor for Cv3PKM.Protos/Settings/Master/Pokemon/StatsAttributes.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StatsAttributesReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjhQT0dPUHJvdG9zL1NldHRpbmdzL01hc3Rlci9Qb2tlbW9uL1N0YXRzQXR0",
            "cmlidXRlcy5wcm90bxIiUE9HT1Byb3Rvcy5TZXR0aW5ncy5NYXN0ZXIuUG9r",
            "ZW1vbiJuCg9TdGF0c0F0dHJpYnV0ZXMSFAoMYmFzZV9zdGFtaW5hGAEgASgF",
            "EhMKC2Jhc2VfYXR0YWNrGAIgASgFEhQKDGJhc2VfZGVmZW5zZRgDIAEoBRIa",
            "ChJkb2RnZV9lbmVyZ3lfZGVsdGEYCCABKAViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Cv3PKM.Protos.Settings.Master.Pokemon.StatsAttributes), global::Cv3PKM.Protos.Settings.Master.Pokemon.StatsAttributes.Parser, new[]{ "BaseStamina", "BaseAttack", "BaseDefense", "DodgeEnergyDelta" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class StatsAttributes : pb::IMessage<StatsAttributes> {
    private static readonly pb::MessageParser<StatsAttributes> _parser = new pb::MessageParser<StatsAttributes>(() => new StatsAttributes());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<StatsAttributes> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cv3PKM.Protos.Settings.Master.Pokemon.StatsAttributesReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StatsAttributes() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StatsAttributes(StatsAttributes other) : this() {
      baseStamina_ = other.baseStamina_;
      baseAttack_ = other.baseAttack_;
      baseDefense_ = other.baseDefense_;
      dodgeEnergyDelta_ = other.dodgeEnergyDelta_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StatsAttributes Clone() {
      return new StatsAttributes(this);
    }

    /// <summary>Field number for the "base_stamina" field.</summary>
    public const int BaseStaminaFieldNumber = 1;
    private int baseStamina_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int BaseStamina {
      get { return baseStamina_; }
      set {
        baseStamina_ = value;
      }
    }

    /// <summary>Field number for the "base_attack" field.</summary>
    public const int BaseAttackFieldNumber = 2;
    private int baseAttack_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int BaseAttack {
      get { return baseAttack_; }
      set {
        baseAttack_ = value;
      }
    }

    /// <summary>Field number for the "base_defense" field.</summary>
    public const int BaseDefenseFieldNumber = 3;
    private int baseDefense_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int BaseDefense {
      get { return baseDefense_; }
      set {
        baseDefense_ = value;
      }
    }

    /// <summary>Field number for the "dodge_energy_delta" field.</summary>
    public const int DodgeEnergyDeltaFieldNumber = 8;
    private int dodgeEnergyDelta_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int DodgeEnergyDelta {
      get { return dodgeEnergyDelta_; }
      set {
        dodgeEnergyDelta_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as StatsAttributes);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(StatsAttributes other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BaseStamina != other.BaseStamina) return false;
      if (BaseAttack != other.BaseAttack) return false;
      if (BaseDefense != other.BaseDefense) return false;
      if (DodgeEnergyDelta != other.DodgeEnergyDelta) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (BaseStamina != 0) hash ^= BaseStamina.GetHashCode();
      if (BaseAttack != 0) hash ^= BaseAttack.GetHashCode();
      if (BaseDefense != 0) hash ^= BaseDefense.GetHashCode();
      if (DodgeEnergyDelta != 0) hash ^= DodgeEnergyDelta.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (BaseStamina != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(BaseStamina);
      }
      if (BaseAttack != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(BaseAttack);
      }
      if (BaseDefense != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(BaseDefense);
      }
      if (DodgeEnergyDelta != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(DodgeEnergyDelta);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (BaseStamina != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(BaseStamina);
      }
      if (BaseAttack != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(BaseAttack);
      }
      if (BaseDefense != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(BaseDefense);
      }
      if (DodgeEnergyDelta != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(DodgeEnergyDelta);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(StatsAttributes other) {
      if (other == null) {
        return;
      }
      if (other.BaseStamina != 0) {
        BaseStamina = other.BaseStamina;
      }
      if (other.BaseAttack != 0) {
        BaseAttack = other.BaseAttack;
      }
      if (other.BaseDefense != 0) {
        BaseDefense = other.BaseDefense;
      }
      if (other.DodgeEnergyDelta != 0) {
        DodgeEnergyDelta = other.DodgeEnergyDelta;
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
            BaseStamina = input.ReadInt32();
            break;
          }
          case 16: {
            BaseAttack = input.ReadInt32();
            break;
          }
          case 24: {
            BaseDefense = input.ReadInt32();
            break;
          }
          case 64: {
            DodgeEnergyDelta = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
