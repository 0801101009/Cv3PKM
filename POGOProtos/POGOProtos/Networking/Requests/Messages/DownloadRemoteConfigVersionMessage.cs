// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Cv3PKM.Protos/Networking/Requests/Messages/DownloadRemoteConfigVersionMessage.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Cv3PKM.Protos.Networking.Requests.Messages {

  /// <summary>Holder for reflection information generated from Cv3PKM.Protos/Networking/Requests/Messages/DownloadRemoteConfigVersionMessage.proto</summary>
  public static partial class DownloadRemoteConfigVersionMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for Cv3PKM.Protos/Networking/Requests/Messages/DownloadRemoteConfigVersionMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DownloadRemoteConfigVersionMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ClBQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVxdWVzdHMvTWVzc2FnZXMvRG93",
            "bmxvYWRSZW1vdGVDb25maWdWZXJzaW9uTWVzc2FnZS5wcm90bxInUE9HT1By",
            "b3Rvcy5OZXR3b3JraW5nLlJlcXVlc3RzLk1lc3NhZ2VzGh9QT0dPUHJvdG9z",
            "L0VudW1zL1BsYXRmb3JtLnByb3RvIqoBCiJEb3dubG9hZFJlbW90ZUNvbmZp",
            "Z1ZlcnNpb25NZXNzYWdlEiwKCHBsYXRmb3JtGAEgASgOMhouUE9HT1Byb3Rv",
            "cy5FbnVtcy5QbGF0Zm9ybRIbChNkZXZpY2VfbWFudWZhY3R1cmVyGAIgASgJ",
            "EhQKDGRldmljZV9tb2RlbBgDIAEoCRIOCgZsb2NhbGUYBCABKAkSEwoLYXBw",
            "X3ZlcnNpb24YBSABKA1iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Cv3PKM.Protos.Enums.PlatformReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Cv3PKM.Protos.Networking.Requests.Messages.DownloadRemoteConfigVersionMessage), global::Cv3PKM.Protos.Networking.Requests.Messages.DownloadRemoteConfigVersionMessage.Parser, new[]{ "Platform", "DeviceManufacturer", "DeviceModel", "Locale", "AppVersion" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class DownloadRemoteConfigVersionMessage : pb::IMessage<DownloadRemoteConfigVersionMessage> {
    private static readonly pb::MessageParser<DownloadRemoteConfigVersionMessage> _parser = new pb::MessageParser<DownloadRemoteConfigVersionMessage>(() => new DownloadRemoteConfigVersionMessage());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DownloadRemoteConfigVersionMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cv3PKM.Protos.Networking.Requests.Messages.DownloadRemoteConfigVersionMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DownloadRemoteConfigVersionMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DownloadRemoteConfigVersionMessage(DownloadRemoteConfigVersionMessage other) : this() {
      platform_ = other.platform_;
      deviceManufacturer_ = other.deviceManufacturer_;
      deviceModel_ = other.deviceModel_;
      locale_ = other.locale_;
      appVersion_ = other.appVersion_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DownloadRemoteConfigVersionMessage Clone() {
      return new DownloadRemoteConfigVersionMessage(this);
    }

    /// <summary>Field number for the "platform" field.</summary>
    public const int PlatformFieldNumber = 1;
    private global::Cv3PKM.Protos.Enums.Platform platform_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Cv3PKM.Protos.Enums.Platform Platform {
      get { return platform_; }
      set {
        platform_ = value;
      }
    }

    /// <summary>Field number for the "device_manufacturer" field.</summary>
    public const int DeviceManufacturerFieldNumber = 2;
    private string deviceManufacturer_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DeviceManufacturer {
      get { return deviceManufacturer_; }
      set {
        deviceManufacturer_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "device_model" field.</summary>
    public const int DeviceModelFieldNumber = 3;
    private string deviceModel_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DeviceModel {
      get { return deviceModel_; }
      set {
        deviceModel_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "locale" field.</summary>
    public const int LocaleFieldNumber = 4;
    private string locale_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Locale {
      get { return locale_; }
      set {
        locale_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "app_version" field.</summary>
    public const int AppVersionFieldNumber = 5;
    private uint appVersion_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint AppVersion {
      get { return appVersion_; }
      set {
        appVersion_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DownloadRemoteConfigVersionMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DownloadRemoteConfigVersionMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Platform != other.Platform) return false;
      if (DeviceManufacturer != other.DeviceManufacturer) return false;
      if (DeviceModel != other.DeviceModel) return false;
      if (Locale != other.Locale) return false;
      if (AppVersion != other.AppVersion) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Platform != 0) hash ^= Platform.GetHashCode();
      if (DeviceManufacturer.Length != 0) hash ^= DeviceManufacturer.GetHashCode();
      if (DeviceModel.Length != 0) hash ^= DeviceModel.GetHashCode();
      if (Locale.Length != 0) hash ^= Locale.GetHashCode();
      if (AppVersion != 0) hash ^= AppVersion.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Platform != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Platform);
      }
      if (DeviceManufacturer.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DeviceManufacturer);
      }
      if (DeviceModel.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(DeviceModel);
      }
      if (Locale.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Locale);
      }
      if (AppVersion != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(AppVersion);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Platform != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Platform);
      }
      if (DeviceManufacturer.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DeviceManufacturer);
      }
      if (DeviceModel.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DeviceModel);
      }
      if (Locale.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Locale);
      }
      if (AppVersion != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AppVersion);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DownloadRemoteConfigVersionMessage other) {
      if (other == null) {
        return;
      }
      if (other.Platform != 0) {
        Platform = other.Platform;
      }
      if (other.DeviceManufacturer.Length != 0) {
        DeviceManufacturer = other.DeviceManufacturer;
      }
      if (other.DeviceModel.Length != 0) {
        DeviceModel = other.DeviceModel;
      }
      if (other.Locale.Length != 0) {
        Locale = other.Locale;
      }
      if (other.AppVersion != 0) {
        AppVersion = other.AppVersion;
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
            platform_ = (global::Cv3PKM.Protos.Enums.Platform) input.ReadEnum();
            break;
          }
          case 18: {
            DeviceManufacturer = input.ReadString();
            break;
          }
          case 26: {
            DeviceModel = input.ReadString();
            break;
          }
          case 34: {
            Locale = input.ReadString();
            break;
          }
          case 40: {
            AppVersion = input.ReadUInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code