// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Cv3PKM.Protos/Enums/PokemonMovementType.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Cv3PKM.Protos.Enums {

  /// <summary>Holder for reflection information generated from Cv3PKM.Protos/Enums/PokemonMovementType.proto</summary>
  public static partial class PokemonMovementTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for Cv3PKM.Protos/Enums/PokemonMovementType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PokemonMovementTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CipQT0dPUHJvdG9zL0VudW1zL1Bva2Vtb25Nb3ZlbWVudFR5cGUucHJvdG8S",
            "EFBPR09Qcm90b3MuRW51bXMqrQEKE1Bva2Vtb25Nb3ZlbWVudFR5cGUSEwoP",
            "TU9WRU1FTlRfU1RBVElDEAASEQoNTU9WRU1FTlRfSlVNUBABEhUKEU1PVkVN",
            "RU5UX1ZFUlRJQ0FMEAISFAoQTU9WRU1FTlRfUFNZQ0hJQxADEhUKEU1PVkVN",
            "RU5UX0VMRUNUUklDEAQSEwoPTU9WRU1FTlRfRkxZSU5HEAUSFQoRTU9WRU1F",
            "TlRfSE9WRVJJTkcQBmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Cv3PKM.Protos.Enums.PokemonMovementType), }, null));
    }
    #endregion

  }
  #region Enums
  public enum PokemonMovementType {
    [pbr::OriginalName("MOVEMENT_STATIC")] MovementStatic = 0,
    [pbr::OriginalName("MOVEMENT_JUMP")] MovementJump = 1,
    [pbr::OriginalName("MOVEMENT_VERTICAL")] MovementVertical = 2,
    [pbr::OriginalName("MOVEMENT_PSYCHIC")] MovementPsychic = 3,
    [pbr::OriginalName("MOVEMENT_ELECTRIC")] MovementElectric = 4,
    [pbr::OriginalName("MOVEMENT_FLYING")] MovementFlying = 5,
    [pbr::OriginalName("MOVEMENT_HOVERING")] MovementHovering = 6,
  }

  #endregion

}

#endregion Designer generated code
