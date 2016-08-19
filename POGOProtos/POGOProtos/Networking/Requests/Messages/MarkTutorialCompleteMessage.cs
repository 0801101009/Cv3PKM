// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Cv3PKM.Protos/Networking/Requests/Messages/MarkTutorialCompleteMessage.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Cv3PKM.Protos.Networking.Requests.Messages {

  /// <summary>Holder for reflection information generated from Cv3PKM.Protos/Networking/Requests/Messages/MarkTutorialCompleteMessage.proto</summary>
  public static partial class MarkTutorialCompleteMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for Cv3PKM.Protos/Networking/Requests/Messages/MarkTutorialCompleteMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MarkTutorialCompleteMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CklQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVxdWVzdHMvTWVzc2FnZXMvTWFy",
            "a1R1dG9yaWFsQ29tcGxldGVNZXNzYWdlLnByb3RvEidQT0dPUHJvdG9zLk5l",
            "dHdvcmtpbmcuUmVxdWVzdHMuTWVzc2FnZXMaJFBPR09Qcm90b3MvRW51bXMv",
            "VHV0b3JpYWxTdGF0ZS5wcm90byKbAQobTWFya1R1dG9yaWFsQ29tcGxldGVN",
            "ZXNzYWdlEjwKE3R1dG9yaWFsc19jb21wbGV0ZWQYASADKA4yHy5QT0dPUHJv",
            "dG9zLkVudW1zLlR1dG9yaWFsU3RhdGUSHQoVc2VuZF9tYXJrZXRpbmdfZW1h",
            "aWxzGAIgASgIEh8KF3NlbmRfcHVzaF9ub3RpZmljYXRpb25zGAMgASgIYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Cv3PKM.Protos.Enums.TutorialStateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Cv3PKM.Protos.Networking.Requests.Messages.MarkTutorialCompleteMessage), global::Cv3PKM.Protos.Networking.Requests.Messages.MarkTutorialCompleteMessage.Parser, new[]{ "TutorialsCompleted", "SendMarketingEmails", "SendPushNotifications" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class MarkTutorialCompleteMessage : pb::IMessage<MarkTutorialCompleteMessage> {
    private static readonly pb::MessageParser<MarkTutorialCompleteMessage> _parser = new pb::MessageParser<MarkTutorialCompleteMessage>(() => new MarkTutorialCompleteMessage());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MarkTutorialCompleteMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cv3PKM.Protos.Networking.Requests.Messages.MarkTutorialCompleteMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MarkTutorialCompleteMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MarkTutorialCompleteMessage(MarkTutorialCompleteMessage other) : this() {
      tutorialsCompleted_ = other.tutorialsCompleted_.Clone();
      sendMarketingEmails_ = other.sendMarketingEmails_;
      sendPushNotifications_ = other.sendPushNotifications_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MarkTutorialCompleteMessage Clone() {
      return new MarkTutorialCompleteMessage(this);
    }

    /// <summary>Field number for the "tutorials_completed" field.</summary>
    public const int TutorialsCompletedFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Cv3PKM.Protos.Enums.TutorialState> _repeated_tutorialsCompleted_codec
        = pb::FieldCodec.ForEnum(10, x => (int) x, x => (global::Cv3PKM.Protos.Enums.TutorialState) x);
    private readonly pbc::RepeatedField<global::Cv3PKM.Protos.Enums.TutorialState> tutorialsCompleted_ = new pbc::RepeatedField<global::Cv3PKM.Protos.Enums.TutorialState>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Cv3PKM.Protos.Enums.TutorialState> TutorialsCompleted {
      get { return tutorialsCompleted_; }
    }

    /// <summary>Field number for the "send_marketing_emails" field.</summary>
    public const int SendMarketingEmailsFieldNumber = 2;
    private bool sendMarketingEmails_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool SendMarketingEmails {
      get { return sendMarketingEmails_; }
      set {
        sendMarketingEmails_ = value;
      }
    }

    /// <summary>Field number for the "send_push_notifications" field.</summary>
    public const int SendPushNotificationsFieldNumber = 3;
    private bool sendPushNotifications_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool SendPushNotifications {
      get { return sendPushNotifications_; }
      set {
        sendPushNotifications_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MarkTutorialCompleteMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MarkTutorialCompleteMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!tutorialsCompleted_.Equals(other.tutorialsCompleted_)) return false;
      if (SendMarketingEmails != other.SendMarketingEmails) return false;
      if (SendPushNotifications != other.SendPushNotifications) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= tutorialsCompleted_.GetHashCode();
      if (SendMarketingEmails != false) hash ^= SendMarketingEmails.GetHashCode();
      if (SendPushNotifications != false) hash ^= SendPushNotifications.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      tutorialsCompleted_.WriteTo(output, _repeated_tutorialsCompleted_codec);
      if (SendMarketingEmails != false) {
        output.WriteRawTag(16);
        output.WriteBool(SendMarketingEmails);
      }
      if (SendPushNotifications != false) {
        output.WriteRawTag(24);
        output.WriteBool(SendPushNotifications);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += tutorialsCompleted_.CalculateSize(_repeated_tutorialsCompleted_codec);
      if (SendMarketingEmails != false) {
        size += 1 + 1;
      }
      if (SendPushNotifications != false) {
        size += 1 + 1;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MarkTutorialCompleteMessage other) {
      if (other == null) {
        return;
      }
      tutorialsCompleted_.Add(other.tutorialsCompleted_);
      if (other.SendMarketingEmails != false) {
        SendMarketingEmails = other.SendMarketingEmails;
      }
      if (other.SendPushNotifications != false) {
        SendPushNotifications = other.SendPushNotifications;
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
          case 10:
          case 8: {
            tutorialsCompleted_.AddEntriesFrom(input, _repeated_tutorialsCompleted_codec);
            break;
          }
          case 16: {
            SendMarketingEmails = input.ReadBool();
            break;
          }
          case 24: {
            SendPushNotifications = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code