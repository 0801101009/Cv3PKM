// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Cv3PKM.Protos/Enums/IapItemCategory.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Cv3PKM.Protos.Enums {

  /// <summary>Holder for reflection information generated from Cv3PKM.Protos/Enums/IapItemCategory.proto</summary>
  public static partial class IapItemCategoryReflection {

    #region Descriptor
    /// <summary>File descriptor for Cv3PKM.Protos/Enums/IapItemCategory.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static IapItemCategoryReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZQT0dPUHJvdG9zL0VudW1zL0lhcEl0ZW1DYXRlZ29yeS5wcm90bxIQUE9H",
            "T1Byb3Rvcy5FbnVtcyqUAQoTSG9sb0lhcEl0ZW1DYXRlZ29yeRIVChFJQVBf",
            "Q0FURUdPUllfTk9ORRAAEhcKE0lBUF9DQVRFR09SWV9CVU5ETEUQARIWChJJ",
            "QVBfQ0FURUdPUllfSVRFTVMQAhIZChVJQVBfQ0FURUdPUllfVVBHUkFERVMQ",
            "AxIaChZJQVBfQ0FURUdPUllfUE9LRUNPSU5TEARiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Cv3PKM.Protos.Enums.HoloIapItemCategory), }, null));
    }
    #endregion

  }
  #region Enums
  public enum HoloIapItemCategory {
    [pbr::OriginalName("IAP_CATEGORY_NONE")] IapCategoryNone = 0,
    [pbr::OriginalName("IAP_CATEGORY_BUNDLE")] IapCategoryBundle = 1,
    [pbr::OriginalName("IAP_CATEGORY_ITEMS")] IapCategoryItems = 2,
    [pbr::OriginalName("IAP_CATEGORY_UPGRADES")] IapCategoryUpgrades = 3,
    [pbr::OriginalName("IAP_CATEGORY_POKECOINS")] IapCategoryPokecoins = 4,
  }

  #endregion

}

#endregion Designer generated code
