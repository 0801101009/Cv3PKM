// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Cv3PKM.Protos/Networking/Requests/Messages/UseIncenseMessage.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Cv3PKM.Protos.Networking.Requests.Messages {

  /// <summary>Holder for reflection information generated from Cv3PKM.Protos/Networking/Requests/Messages/UseIncenseMessage.proto</summary>
  public static partial class UseIncenseMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for Cv3PKM.Protos/Networking/Requests/Messages/UseIncenseMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UseIncenseMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj9QT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVxdWVzdHMvTWVzc2FnZXMvVXNl",
            "SW5jZW5zZU1lc3NhZ2UucHJvdG8SJ1BPR09Qcm90b3MuTmV0d29ya2luZy5S",
            "ZXF1ZXN0cy5NZXNzYWdlcxomUE9HT1Byb3Rvcy9JbnZlbnRvcnkvSXRlbS9J",
            "dGVtSWQucHJvdG8iTAoRVXNlSW5jZW5zZU1lc3NhZ2USNwoMaW5jZW5zZV90",
            "eXBlGAEgASgOMiEuUE9HT1Byb3Rvcy5JbnZlbnRvcnkuSXRlbS5JdGVtSWRi",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Cv3PKM.Protos.Inventory.Item.ItemIdReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Cv3PKM.Protos.Networking.Requests.Messages.UseIncenseMessage), global::Cv3PKM.Protos.Networking.Requests.Messages.UseIncenseMessage.Parser, new[]{ "IncenseType" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class UseIncenseMessage : pb::IMessage<UseIncenseMessage> {
    private static readonly pb::MessageParser<UseIncenseMessage> _parser = new pb::MessageParser<UseIncenseMessage>(() => new UseIncenseMessage());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UseIncenseMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cv3PKM.Protos.Networking.Requests.Messages.UseIncenseMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UseIncenseMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UseIncenseMessage(UseIncenseMessage other) : this() {
      incenseType_ = other.incenseType_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UseIncenseMessage Clone() {
      return new UseIncenseMessage(this);
    }

    /// <summary>Field number for the "incense_type" field.</summary>
    public const int IncenseTypeFieldNumber = 1;
    private global::Cv3PKM.Protos.Inventory.Item.ItemId incenseType_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Cv3PKM.Protos.Inventory.Item.ItemId IncenseType {
      get { return incenseType_; }
      set {
        incenseType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UseIncenseMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UseIncenseMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IncenseType != other.IncenseType) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (IncenseType != 0) hash ^= IncenseType.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (IncenseType != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) IncenseType);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (IncenseType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) IncenseType);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UseIncenseMessage other) {
      if (other == null) {
        return;
      }
      if (other.IncenseType != 0) {
        IncenseType = other.IncenseType;
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
            incenseType_ = (global::Cv3PKM.Protos.Inventory.Item.ItemId) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code