// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Cv3PKM.Protos/Enums/TutorialState.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Cv3PKM.Protos.Enums {

  /// <summary>Holder for reflection information generated from Cv3PKM.Protos/Enums/TutorialState.proto</summary>
  public static partial class TutorialStateReflection {

    #region Descriptor
    /// <summary>File descriptor for Cv3PKM.Protos/Enums/TutorialState.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TutorialStateReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRQT0dPUHJvdG9zL0VudW1zL1R1dG9yaWFsU3RhdGUucHJvdG8SEFBPR09Q",
            "cm90b3MuRW51bXMq5AEKDVR1dG9yaWFsU3RhdGUSEAoMTEVHQUxfU0NSRUVO",
            "EAASFAoQQVZBVEFSX1NFTEVDVElPThABEhQKEEFDQ09VTlRfQ1JFQVRJT04Q",
            "AhITCg9QT0tFTU9OX0NBUFRVUkUQAxISCg5OQU1FX1NFTEVDVElPThAEEhEK",
            "DVBPS0VNT05fQkVSUlkQBRIMCghVU0VfSVRFTRAGEiIKHkZJUlNUX1RJTUVf",
            "RVhQRVJJRU5DRV9DT01QTEVURRAHEhUKEVBPS0VTVE9QX1RVVE9SSUFMEAgS",
            "EAoMR1lNX1RVVE9SSUFMEAliBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Cv3PKM.Protos.Enums.TutorialState), }, null));
    }
    #endregion

  }
  #region Enums
  public enum TutorialState {
    [pbr::OriginalName("LEGAL_SCREEN")] LegalScreen = 0,
    [pbr::OriginalName("AVATAR_SELECTION")] AvatarSelection = 1,
    [pbr::OriginalName("ACCOUNT_CREATION")] AccountCreation = 2,
    [pbr::OriginalName("POKEMON_CAPTURE")] PokemonCapture = 3,
    [pbr::OriginalName("NAME_SELECTION")] NameSelection = 4,
    [pbr::OriginalName("POKEMON_BERRY")] PokemonBerry = 5,
    [pbr::OriginalName("USE_ITEM")] UseItem = 6,
    [pbr::OriginalName("FIRST_TIME_EXPERIENCE_COMPLETE")] FirstTimeExperienceComplete = 7,
    [pbr::OriginalName("POKESTOP_TUTORIAL")] PokestopTutorial = 8,
    [pbr::OriginalName("GYM_TUTORIAL")] GymTutorial = 9,
  }

  #endregion

}

#endregion Designer generated code
