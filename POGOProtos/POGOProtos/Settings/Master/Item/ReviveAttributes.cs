// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Cv3PKM.Protos/Settings/Master/Item/ReviveAttributes.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Cv3PKM.Protos.Settings.Master.Item {

  /// <summary>Holder for reflection information generated from Cv3PKM.Protos/Settings/Master/Item/ReviveAttributes.proto</summary>
  public static partial class ReviveAttributesReflection {

    #region Descriptor
    /// <summary>File descriptor for Cv3PKM.Protos/Settings/Master/Item/ReviveAttributes.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ReviveAttributesReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjZQT0dPUHJvdG9zL1NldHRpbmdzL01hc3Rlci9JdGVtL1Jldml2ZUF0dHJp",
            "YnV0ZXMucHJvdG8SH1BPR09Qcm90b3MuU2V0dGluZ3MuTWFzdGVyLkl0ZW0i",
            "JwoQUmV2aXZlQXR0cmlidXRlcxITCgtzdGFfcGVyY2VudBgBIAEoAmIGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Cv3PKM.Protos.Settings.Master.Item.ReviveAttributes), global::Cv3PKM.Protos.Settings.Master.Item.ReviveAttributes.Parser, new[]{ "StaPercent" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ReviveAttributes : pb::IMessage<ReviveAttributes> {
    private static readonly pb::MessageParser<ReviveAttributes> _parser = new pb::MessageParser<ReviveAttributes>(() => new ReviveAttributes());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ReviveAttributes> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cv3PKM.Protos.Settings.Master.Item.ReviveAttributesReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReviveAttributes() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReviveAttributes(ReviveAttributes other) : this() {
      staPercent_ = other.staPercent_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReviveAttributes Clone() {
      return new ReviveAttributes(this);
    }

    /// <summary>Field number for the "sta_percent" field.</summary>
    public const int StaPercentFieldNumber = 1;
    private float staPercent_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float StaPercent {
      get { return staPercent_; }
      set {
        staPercent_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ReviveAttributes);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ReviveAttributes other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (StaPercent != other.StaPercent) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (StaPercent != 0F) hash ^= StaPercent.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (StaPercent != 0F) {
        output.WriteRawTag(13);
        output.WriteFloat(StaPercent);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (StaPercent != 0F) {
        size += 1 + 4;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ReviveAttributes other) {
      if (other == null) {
        return;
      }
      if (other.StaPercent != 0F) {
        StaPercent = other.StaPercent;
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
            StaPercent = input.ReadFloat();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code