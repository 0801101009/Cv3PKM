// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Cv3PKM.Protos/Networking/Requests/Messages/RecycleInventoryItemMessage.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Cv3PKM.Protos.Networking.Requests.Messages {

  /// <summary>Holder for reflection information generated from Cv3PKM.Protos/Networking/Requests/Messages/RecycleInventoryItemMessage.proto</summary>
  public static partial class RecycleInventoryItemMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for Cv3PKM.Protos/Networking/Requests/Messages/RecycleInventoryItemMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RecycleInventoryItemMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CklQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVxdWVzdHMvTWVzc2FnZXMvUmVj",
            "eWNsZUludmVudG9yeUl0ZW1NZXNzYWdlLnByb3RvEidQT0dPUHJvdG9zLk5l",
            "dHdvcmtpbmcuUmVxdWVzdHMuTWVzc2FnZXMaJlBPR09Qcm90b3MvSW52ZW50",
            "b3J5L0l0ZW0vSXRlbUlkLnByb3RvImAKG1JlY3ljbGVJbnZlbnRvcnlJdGVt",
            "TWVzc2FnZRIyCgdpdGVtX2lkGAEgASgOMiEuUE9HT1Byb3Rvcy5JbnZlbnRv",
            "cnkuSXRlbS5JdGVtSWQSDQoFY291bnQYAiABKAViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Cv3PKM.Protos.Inventory.Item.ItemIdReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Cv3PKM.Protos.Networking.Requests.Messages.RecycleInventoryItemMessage), global::Cv3PKM.Protos.Networking.Requests.Messages.RecycleInventoryItemMessage.Parser, new[]{ "ItemId", "Count" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class RecycleInventoryItemMessage : pb::IMessage<RecycleInventoryItemMessage> {
    private static readonly pb::MessageParser<RecycleInventoryItemMessage> _parser = new pb::MessageParser<RecycleInventoryItemMessage>(() => new RecycleInventoryItemMessage());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RecycleInventoryItemMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cv3PKM.Protos.Networking.Requests.Messages.RecycleInventoryItemMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RecycleInventoryItemMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RecycleInventoryItemMessage(RecycleInventoryItemMessage other) : this() {
      itemId_ = other.itemId_;
      count_ = other.count_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RecycleInventoryItemMessage Clone() {
      return new RecycleInventoryItemMessage(this);
    }

    /// <summary>Field number for the "item_id" field.</summary>
    public const int ItemIdFieldNumber = 1;
    private global::Cv3PKM.Protos.Inventory.Item.ItemId itemId_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Cv3PKM.Protos.Inventory.Item.ItemId ItemId {
      get { return itemId_; }
      set {
        itemId_ = value;
      }
    }

    /// <summary>Field number for the "count" field.</summary>
    public const int CountFieldNumber = 2;
    private int count_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Count {
      get { return count_; }
      set {
        count_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RecycleInventoryItemMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RecycleInventoryItemMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ItemId != other.ItemId) return false;
      if (Count != other.Count) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ItemId != 0) hash ^= ItemId.GetHashCode();
      if (Count != 0) hash ^= Count.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ItemId != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) ItemId);
      }
      if (Count != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Count);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ItemId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ItemId);
      }
      if (Count != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Count);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RecycleInventoryItemMessage other) {
      if (other == null) {
        return;
      }
      if (other.ItemId != 0) {
        ItemId = other.ItemId;
      }
      if (other.Count != 0) {
        Count = other.Count;
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
            itemId_ = (global::Cv3PKM.Protos.Inventory.Item.ItemId) input.ReadEnum();
            break;
          }
          case 16: {
            Count = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
