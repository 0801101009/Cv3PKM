// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Cv3PKM.Protos/Data/Player/PlayerAvatar.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Cv3PKM.Protos.Data.Player {

  /// <summary>Holder for reflection information generated from Cv3PKM.Protos/Data/Player/PlayerAvatar.proto</summary>
  public static partial class PlayerAvatarReflection {

    #region Descriptor
    /// <summary>File descriptor for Cv3PKM.Protos/Data/Player/PlayerAvatar.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerAvatarReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CilQT0dPUHJvdG9zL0RhdGEvUGxheWVyL1BsYXllckF2YXRhci5wcm90bxIW",
            "UE9HT1Byb3Rvcy5EYXRhLlBsYXllchodUE9HT1Byb3Rvcy9FbnVtcy9HZW5k",
            "ZXIucHJvdG8irgEKDFBsYXllckF2YXRhchIMCgRza2luGAIgASgFEgwKBGhh",
            "aXIYAyABKAUSDQoFc2hpcnQYBCABKAUSDQoFcGFudHMYBSABKAUSCwoDaGF0",
            "GAYgASgFEg0KBXNob2VzGAcgASgFEigKBmdlbmRlchgIIAEoDjIYLlBPR09Q",
            "cm90b3MuRW51bXMuR2VuZGVyEgwKBGV5ZXMYCSABKAUSEAoIYmFja3BhY2sY",
            "CiABKAViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Cv3PKM.Protos.Enums.GenderReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Cv3PKM.Protos.Data.Player.PlayerAvatar), global::Cv3PKM.Protos.Data.Player.PlayerAvatar.Parser, new[]{ "Skin", "Hair", "Shirt", "Pants", "Hat", "Shoes", "Gender", "Eyes", "Backpack" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PlayerAvatar : pb::IMessage<PlayerAvatar> {
    private static readonly pb::MessageParser<PlayerAvatar> _parser = new pb::MessageParser<PlayerAvatar>(() => new PlayerAvatar());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PlayerAvatar> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cv3PKM.Protos.Data.Player.PlayerAvatarReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlayerAvatar() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlayerAvatar(PlayerAvatar other) : this() {
      skin_ = other.skin_;
      hair_ = other.hair_;
      shirt_ = other.shirt_;
      pants_ = other.pants_;
      hat_ = other.hat_;
      shoes_ = other.shoes_;
      gender_ = other.gender_;
      eyes_ = other.eyes_;
      backpack_ = other.backpack_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlayerAvatar Clone() {
      return new PlayerAvatar(this);
    }

    /// <summary>Field number for the "skin" field.</summary>
    public const int SkinFieldNumber = 2;
    private int skin_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Skin {
      get { return skin_; }
      set {
        skin_ = value;
      }
    }

    /// <summary>Field number for the "hair" field.</summary>
    public const int HairFieldNumber = 3;
    private int hair_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Hair {
      get { return hair_; }
      set {
        hair_ = value;
      }
    }

    /// <summary>Field number for the "shirt" field.</summary>
    public const int ShirtFieldNumber = 4;
    private int shirt_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Shirt {
      get { return shirt_; }
      set {
        shirt_ = value;
      }
    }

    /// <summary>Field number for the "pants" field.</summary>
    public const int PantsFieldNumber = 5;
    private int pants_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Pants {
      get { return pants_; }
      set {
        pants_ = value;
      }
    }

    /// <summary>Field number for the "hat" field.</summary>
    public const int HatFieldNumber = 6;
    private int hat_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Hat {
      get { return hat_; }
      set {
        hat_ = value;
      }
    }

    /// <summary>Field number for the "shoes" field.</summary>
    public const int ShoesFieldNumber = 7;
    private int shoes_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Shoes {
      get { return shoes_; }
      set {
        shoes_ = value;
      }
    }

    /// <summary>Field number for the "gender" field.</summary>
    public const int GenderFieldNumber = 8;
    private global::Cv3PKM.Protos.Enums.Gender gender_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Cv3PKM.Protos.Enums.Gender Gender {
      get { return gender_; }
      set {
        gender_ = value;
      }
    }

    /// <summary>Field number for the "eyes" field.</summary>
    public const int EyesFieldNumber = 9;
    private int eyes_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Eyes {
      get { return eyes_; }
      set {
        eyes_ = value;
      }
    }

    /// <summary>Field number for the "backpack" field.</summary>
    public const int BackpackFieldNumber = 10;
    private int backpack_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Backpack {
      get { return backpack_; }
      set {
        backpack_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PlayerAvatar);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PlayerAvatar other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Skin != other.Skin) return false;
      if (Hair != other.Hair) return false;
      if (Shirt != other.Shirt) return false;
      if (Pants != other.Pants) return false;
      if (Hat != other.Hat) return false;
      if (Shoes != other.Shoes) return false;
      if (Gender != other.Gender) return false;
      if (Eyes != other.Eyes) return false;
      if (Backpack != other.Backpack) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Skin != 0) hash ^= Skin.GetHashCode();
      if (Hair != 0) hash ^= Hair.GetHashCode();
      if (Shirt != 0) hash ^= Shirt.GetHashCode();
      if (Pants != 0) hash ^= Pants.GetHashCode();
      if (Hat != 0) hash ^= Hat.GetHashCode();
      if (Shoes != 0) hash ^= Shoes.GetHashCode();
      if (Gender != 0) hash ^= Gender.GetHashCode();
      if (Eyes != 0) hash ^= Eyes.GetHashCode();
      if (Backpack != 0) hash ^= Backpack.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Skin != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Skin);
      }
      if (Hair != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Hair);
      }
      if (Shirt != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Shirt);
      }
      if (Pants != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(Pants);
      }
      if (Hat != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(Hat);
      }
      if (Shoes != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(Shoes);
      }
      if (Gender != 0) {
        output.WriteRawTag(64);
        output.WriteEnum((int) Gender);
      }
      if (Eyes != 0) {
        output.WriteRawTag(72);
        output.WriteInt32(Eyes);
      }
      if (Backpack != 0) {
        output.WriteRawTag(80);
        output.WriteInt32(Backpack);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Skin != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Skin);
      }
      if (Hair != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Hair);
      }
      if (Shirt != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Shirt);
      }
      if (Pants != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Pants);
      }
      if (Hat != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Hat);
      }
      if (Shoes != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Shoes);
      }
      if (Gender != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Gender);
      }
      if (Eyes != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Eyes);
      }
      if (Backpack != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Backpack);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PlayerAvatar other) {
      if (other == null) {
        return;
      }
      if (other.Skin != 0) {
        Skin = other.Skin;
      }
      if (other.Hair != 0) {
        Hair = other.Hair;
      }
      if (other.Shirt != 0) {
        Shirt = other.Shirt;
      }
      if (other.Pants != 0) {
        Pants = other.Pants;
      }
      if (other.Hat != 0) {
        Hat = other.Hat;
      }
      if (other.Shoes != 0) {
        Shoes = other.Shoes;
      }
      if (other.Gender != 0) {
        Gender = other.Gender;
      }
      if (other.Eyes != 0) {
        Eyes = other.Eyes;
      }
      if (other.Backpack != 0) {
        Backpack = other.Backpack;
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
          case 16: {
            Skin = input.ReadInt32();
            break;
          }
          case 24: {
            Hair = input.ReadInt32();
            break;
          }
          case 32: {
            Shirt = input.ReadInt32();
            break;
          }
          case 40: {
            Pants = input.ReadInt32();
            break;
          }
          case 48: {
            Hat = input.ReadInt32();
            break;
          }
          case 56: {
            Shoes = input.ReadInt32();
            break;
          }
          case 64: {
            gender_ = (global::Cv3PKM.Protos.Enums.Gender) input.ReadEnum();
            break;
          }
          case 72: {
            Eyes = input.ReadInt32();
            break;
          }
          case 80: {
            Backpack = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code