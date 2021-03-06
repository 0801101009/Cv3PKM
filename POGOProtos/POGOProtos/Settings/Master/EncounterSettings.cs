// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Cv3PKM.Protos/Settings/Master/EncounterSettings.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Cv3PKM.Protos.Settings.Master {

  /// <summary>Holder for reflection information generated from Cv3PKM.Protos/Settings/Master/EncounterSettings.proto</summary>
  public static partial class EncounterSettingsReflection {

    #region Descriptor
    /// <summary>File descriptor for Cv3PKM.Protos/Settings/Master/EncounterSettings.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EncounterSettingsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjJQT0dPUHJvdG9zL1NldHRpbmdzL01hc3Rlci9FbmNvdW50ZXJTZXR0aW5n",
            "cy5wcm90bxIaUE9HT1Byb3Rvcy5TZXR0aW5ncy5NYXN0ZXIirgEKEUVuY291",
            "bnRlclNldHRpbmdzEhwKFHNwaW5fYm9udXNfdGhyZXNob2xkGAEgASgCEiEK",
            "GWV4Y2VsbGVudF90aHJvd190aHJlc2hvbGQYAiABKAISHQoVZ3JlYXRfdGhy",
            "b3dfdGhyZXNob2xkGAMgASgCEhwKFG5pY2VfdGhyb3dfdGhyZXNob2xkGAQg",
            "ASgCEhsKE21pbGVzdG9uZV90aHJlc2hvbGQYBSABKAViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Cv3PKM.Protos.Settings.Master.EncounterSettings), global::Cv3PKM.Protos.Settings.Master.EncounterSettings.Parser, new[]{ "SpinBonusThreshold", "ExcellentThrowThreshold", "GreatThrowThreshold", "NiceThrowThreshold", "MilestoneThreshold" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EncounterSettings : pb::IMessage<EncounterSettings> {
    private static readonly pb::MessageParser<EncounterSettings> _parser = new pb::MessageParser<EncounterSettings>(() => new EncounterSettings());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<EncounterSettings> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cv3PKM.Protos.Settings.Master.EncounterSettingsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EncounterSettings() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EncounterSettings(EncounterSettings other) : this() {
      spinBonusThreshold_ = other.spinBonusThreshold_;
      excellentThrowThreshold_ = other.excellentThrowThreshold_;
      greatThrowThreshold_ = other.greatThrowThreshold_;
      niceThrowThreshold_ = other.niceThrowThreshold_;
      milestoneThreshold_ = other.milestoneThreshold_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EncounterSettings Clone() {
      return new EncounterSettings(this);
    }

    /// <summary>Field number for the "spin_bonus_threshold" field.</summary>
    public const int SpinBonusThresholdFieldNumber = 1;
    private float spinBonusThreshold_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float SpinBonusThreshold {
      get { return spinBonusThreshold_; }
      set {
        spinBonusThreshold_ = value;
      }
    }

    /// <summary>Field number for the "excellent_throw_threshold" field.</summary>
    public const int ExcellentThrowThresholdFieldNumber = 2;
    private float excellentThrowThreshold_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float ExcellentThrowThreshold {
      get { return excellentThrowThreshold_; }
      set {
        excellentThrowThreshold_ = value;
      }
    }

    /// <summary>Field number for the "great_throw_threshold" field.</summary>
    public const int GreatThrowThresholdFieldNumber = 3;
    private float greatThrowThreshold_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float GreatThrowThreshold {
      get { return greatThrowThreshold_; }
      set {
        greatThrowThreshold_ = value;
      }
    }

    /// <summary>Field number for the "nice_throw_threshold" field.</summary>
    public const int NiceThrowThresholdFieldNumber = 4;
    private float niceThrowThreshold_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float NiceThrowThreshold {
      get { return niceThrowThreshold_; }
      set {
        niceThrowThreshold_ = value;
      }
    }

    /// <summary>Field number for the "milestone_threshold" field.</summary>
    public const int MilestoneThresholdFieldNumber = 5;
    private int milestoneThreshold_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int MilestoneThreshold {
      get { return milestoneThreshold_; }
      set {
        milestoneThreshold_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as EncounterSettings);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(EncounterSettings other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SpinBonusThreshold != other.SpinBonusThreshold) return false;
      if (ExcellentThrowThreshold != other.ExcellentThrowThreshold) return false;
      if (GreatThrowThreshold != other.GreatThrowThreshold) return false;
      if (NiceThrowThreshold != other.NiceThrowThreshold) return false;
      if (MilestoneThreshold != other.MilestoneThreshold) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (SpinBonusThreshold != 0F) hash ^= SpinBonusThreshold.GetHashCode();
      if (ExcellentThrowThreshold != 0F) hash ^= ExcellentThrowThreshold.GetHashCode();
      if (GreatThrowThreshold != 0F) hash ^= GreatThrowThreshold.GetHashCode();
      if (NiceThrowThreshold != 0F) hash ^= NiceThrowThreshold.GetHashCode();
      if (MilestoneThreshold != 0) hash ^= MilestoneThreshold.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (SpinBonusThreshold != 0F) {
        output.WriteRawTag(13);
        output.WriteFloat(SpinBonusThreshold);
      }
      if (ExcellentThrowThreshold != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(ExcellentThrowThreshold);
      }
      if (GreatThrowThreshold != 0F) {
        output.WriteRawTag(29);
        output.WriteFloat(GreatThrowThreshold);
      }
      if (NiceThrowThreshold != 0F) {
        output.WriteRawTag(37);
        output.WriteFloat(NiceThrowThreshold);
      }
      if (MilestoneThreshold != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(MilestoneThreshold);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (SpinBonusThreshold != 0F) {
        size += 1 + 4;
      }
      if (ExcellentThrowThreshold != 0F) {
        size += 1 + 4;
      }
      if (GreatThrowThreshold != 0F) {
        size += 1 + 4;
      }
      if (NiceThrowThreshold != 0F) {
        size += 1 + 4;
      }
      if (MilestoneThreshold != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MilestoneThreshold);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(EncounterSettings other) {
      if (other == null) {
        return;
      }
      if (other.SpinBonusThreshold != 0F) {
        SpinBonusThreshold = other.SpinBonusThreshold;
      }
      if (other.ExcellentThrowThreshold != 0F) {
        ExcellentThrowThreshold = other.ExcellentThrowThreshold;
      }
      if (other.GreatThrowThreshold != 0F) {
        GreatThrowThreshold = other.GreatThrowThreshold;
      }
      if (other.NiceThrowThreshold != 0F) {
        NiceThrowThreshold = other.NiceThrowThreshold;
      }
      if (other.MilestoneThreshold != 0) {
        MilestoneThreshold = other.MilestoneThreshold;
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
          case 13: {
            SpinBonusThreshold = input.ReadFloat();
            break;
          }
          case 21: {
            ExcellentThrowThreshold = input.ReadFloat();
            break;
          }
          case 29: {
            GreatThrowThreshold = input.ReadFloat();
            break;
          }
          case 37: {
            NiceThrowThreshold = input.ReadFloat();
            break;
          }
          case 40: {
            MilestoneThreshold = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
