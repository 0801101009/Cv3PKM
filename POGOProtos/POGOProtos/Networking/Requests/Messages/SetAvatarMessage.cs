// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Cv3PKM.Protos/Networking/Requests/Messages/SetAvatarMessage.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Cv3PKM.Protos.Networking.Requests.Messages {

  /// <summary>Holder for reflection information generated from Cv3PKM.Protos/Networking/Requests/Messages/SetAvatarMessage.proto</summary>
  public static partial class SetAvatarMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for Cv3PKM.Protos/Networking/Requests/Messages/SetAvatarMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SetAvatarMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj5QT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVxdWVzdHMvTWVzc2FnZXMvU2V0",
            "QXZhdGFyTWVzc2FnZS5wcm90bxInUE9HT1Byb3Rvcy5OZXR3b3JraW5nLlJl",
            "cXVlc3RzLk1lc3NhZ2VzGilQT0dPUHJvdG9zL0RhdGEvUGxheWVyL1BsYXll",
            "ckF2YXRhci5wcm90byJPChBTZXRBdmF0YXJNZXNzYWdlEjsKDXBsYXllcl9h",
            "dmF0YXIYAiABKAsyJC5QT0dPUHJvdG9zLkRhdGEuUGxheWVyLlBsYXllckF2",
            "YXRhcmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Cv3PKM.Protos.Data.Player.PlayerAvatarReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Cv3PKM.Protos.Networking.Requests.Messages.SetAvatarMessage), global::Cv3PKM.Protos.Networking.Requests.Messages.SetAvatarMessage.Parser, new[]{ "PlayerAvatar" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SetAvatarMessage : pb::IMessage<SetAvatarMessage> {
    private static readonly pb::MessageParser<SetAvatarMessage> _parser = new pb::MessageParser<SetAvatarMessage>(() => new SetAvatarMessage());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SetAvatarMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cv3PKM.Protos.Networking.Requests.Messages.SetAvatarMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetAvatarMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetAvatarMessage(SetAvatarMessage other) : this() {
      PlayerAvatar = other.playerAvatar_ != null ? other.PlayerAvatar.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetAvatarMessage Clone() {
      return new SetAvatarMessage(this);
    }

    /// <summary>Field number for the "player_avatar" field.</summary>
    public const int PlayerAvatarFieldNumber = 2;
    private global::Cv3PKM.Protos.Data.Player.PlayerAvatar playerAvatar_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Cv3PKM.Protos.Data.Player.PlayerAvatar PlayerAvatar {
      get { return playerAvatar_; }
      set {
        playerAvatar_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SetAvatarMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SetAvatarMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(PlayerAvatar, other.PlayerAvatar)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (playerAvatar_ != null) hash ^= PlayerAvatar.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (playerAvatar_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(PlayerAvatar);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (playerAvatar_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PlayerAvatar);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SetAvatarMessage other) {
      if (other == null) {
        return;
      }
      if (other.playerAvatar_ != null) {
        if (playerAvatar_ == null) {
          playerAvatar_ = new global::Cv3PKM.Protos.Data.Player.PlayerAvatar();
        }
        PlayerAvatar.MergeFrom(other.PlayerAvatar);
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
          case 18: {
            if (playerAvatar_ == null) {
              playerAvatar_ = new global::Cv3PKM.Protos.Data.Player.PlayerAvatar();
            }
            input.ReadMessage(playerAvatar_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
