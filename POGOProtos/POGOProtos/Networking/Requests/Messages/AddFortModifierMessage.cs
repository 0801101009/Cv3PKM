// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Cv3PKM.Protos/Networking/Requests/Messages/AddFortModifierMessage.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Cv3PKM.Protos.Networking.Requests.Messages {

  /// <summary>Holder for reflection information generated from Cv3PKM.Protos/Networking/Requests/Messages/AddFortModifierMessage.proto</summary>
  public static partial class AddFortModifierMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for Cv3PKM.Protos/Networking/Requests/Messages/AddFortModifierMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AddFortModifierMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkRQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVxdWVzdHMvTWVzc2FnZXMvQWRk",
            "Rm9ydE1vZGlmaWVyTWVzc2FnZS5wcm90bxInUE9HT1Byb3Rvcy5OZXR3b3Jr",
            "aW5nLlJlcXVlc3RzLk1lc3NhZ2VzGiZQT0dPUHJvdG9zL0ludmVudG9yeS9J",
            "dGVtL0l0ZW1JZC5wcm90byKWAQoWQWRkRm9ydE1vZGlmaWVyTWVzc2FnZRI4",
            "Cg1tb2RpZmllcl90eXBlGAEgASgOMiEuUE9HT1Byb3Rvcy5JbnZlbnRvcnku",
            "SXRlbS5JdGVtSWQSDwoHZm9ydF9pZBgCIAEoCRIXCg9wbGF5ZXJfbGF0aXR1",
            "ZGUYAyABKAESGAoQcGxheWVyX2xvbmdpdHVkZRgEIAEoAWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Cv3PKM.Protos.Inventory.Item.ItemIdReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Cv3PKM.Protos.Networking.Requests.Messages.AddFortModifierMessage), global::Cv3PKM.Protos.Networking.Requests.Messages.AddFortModifierMessage.Parser, new[]{ "ModifierType", "FortId", "PlayerLatitude", "PlayerLongitude" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AddFortModifierMessage : pb::IMessage<AddFortModifierMessage> {
    private static readonly pb::MessageParser<AddFortModifierMessage> _parser = new pb::MessageParser<AddFortModifierMessage>(() => new AddFortModifierMessage());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AddFortModifierMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cv3PKM.Protos.Networking.Requests.Messages.AddFortModifierMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddFortModifierMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddFortModifierMessage(AddFortModifierMessage other) : this() {
      modifierType_ = other.modifierType_;
      fortId_ = other.fortId_;
      playerLatitude_ = other.playerLatitude_;
      playerLongitude_ = other.playerLongitude_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddFortModifierMessage Clone() {
      return new AddFortModifierMessage(this);
    }

    /// <summary>Field number for the "modifier_type" field.</summary>
    public const int ModifierTypeFieldNumber = 1;
    private global::Cv3PKM.Protos.Inventory.Item.ItemId modifierType_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Cv3PKM.Protos.Inventory.Item.ItemId ModifierType {
      get { return modifierType_; }
      set {
        modifierType_ = value;
      }
    }

    /// <summary>Field number for the "fort_id" field.</summary>
    public const int FortIdFieldNumber = 2;
    private string fortId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string FortId {
      get { return fortId_; }
      set {
        fortId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "player_latitude" field.</summary>
    public const int PlayerLatitudeFieldNumber = 3;
    private double playerLatitude_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double PlayerLatitude {
      get { return playerLatitude_; }
      set {
        playerLatitude_ = value;
      }
    }

    /// <summary>Field number for the "player_longitude" field.</summary>
    public const int PlayerLongitudeFieldNumber = 4;
    private double playerLongitude_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double PlayerLongitude {
      get { return playerLongitude_; }
      set {
        playerLongitude_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AddFortModifierMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AddFortModifierMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ModifierType != other.ModifierType) return false;
      if (FortId != other.FortId) return false;
      if (PlayerLatitude != other.PlayerLatitude) return false;
      if (PlayerLongitude != other.PlayerLongitude) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ModifierType != 0) hash ^= ModifierType.GetHashCode();
      if (FortId.Length != 0) hash ^= FortId.GetHashCode();
      if (PlayerLatitude != 0D) hash ^= PlayerLatitude.GetHashCode();
      if (PlayerLongitude != 0D) hash ^= PlayerLongitude.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ModifierType != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) ModifierType);
      }
      if (FortId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(FortId);
      }
      if (PlayerLatitude != 0D) {
        output.WriteRawTag(25);
        output.WriteDouble(PlayerLatitude);
      }
      if (PlayerLongitude != 0D) {
        output.WriteRawTag(33);
        output.WriteDouble(PlayerLongitude);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ModifierType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ModifierType);
      }
      if (FortId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FortId);
      }
      if (PlayerLatitude != 0D) {
        size += 1 + 8;
      }
      if (PlayerLongitude != 0D) {
        size += 1 + 8;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AddFortModifierMessage other) {
      if (other == null) {
        return;
      }
      if (other.ModifierType != 0) {
        ModifierType = other.ModifierType;
      }
      if (other.FortId.Length != 0) {
        FortId = other.FortId;
      }
      if (other.PlayerLatitude != 0D) {
        PlayerLatitude = other.PlayerLatitude;
      }
      if (other.PlayerLongitude != 0D) {
        PlayerLongitude = other.PlayerLongitude;
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
            modifierType_ = (global::Cv3PKM.Protos.Inventory.Item.ItemId) input.ReadEnum();
            break;
          }
          case 18: {
            FortId = input.ReadString();
            break;
          }
          case 25: {
            PlayerLatitude = input.ReadDouble();
            break;
          }
          case 33: {
            PlayerLongitude = input.ReadDouble();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
