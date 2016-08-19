// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Cv3PKM.Protos/Data/Player/PlayerCurrency.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Cv3PKM.Protos.Data.Player {

  /// <summary>Holder for reflection information generated from Cv3PKM.Protos/Data/Player/PlayerCurrency.proto</summary>
  public static partial class PlayerCurrencyReflection {

    #region Descriptor
    /// <summary>File descriptor for Cv3PKM.Protos/Data/Player/PlayerCurrency.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerCurrencyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CitQT0dPUHJvdG9zL0RhdGEvUGxheWVyL1BsYXllckN1cnJlbmN5LnByb3Rv",
            "EhZQT0dPUHJvdG9zLkRhdGEuUGxheWVyIh4KDlBsYXllckN1cnJlbmN5EgwK",
            "BGdlbXMYASABKAViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Cv3PKM.Protos.Data.Player.PlayerCurrency), global::Cv3PKM.Protos.Data.Player.PlayerCurrency.Parser, new[]{ "Gems" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PlayerCurrency : pb::IMessage<PlayerCurrency> {
    private static readonly pb::MessageParser<PlayerCurrency> _parser = new pb::MessageParser<PlayerCurrency>(() => new PlayerCurrency());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PlayerCurrency> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cv3PKM.Protos.Data.Player.PlayerCurrencyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlayerCurrency() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlayerCurrency(PlayerCurrency other) : this() {
      gems_ = other.gems_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlayerCurrency Clone() {
      return new PlayerCurrency(this);
    }

    /// <summary>Field number for the "gems" field.</summary>
    public const int GemsFieldNumber = 1;
    private int gems_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Gems {
      get { return gems_; }
      set {
        gems_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PlayerCurrency);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PlayerCurrency other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Gems != other.Gems) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Gems != 0) hash ^= Gems.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Gems != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Gems);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Gems != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Gems);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PlayerCurrency other) {
      if (other == null) {
        return;
      }
      if (other.Gems != 0) {
        Gems = other.Gems;
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
            Gems = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
