// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Cv3PKM.Protos/Enums/PokemonFamilyId.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Cv3PKM.Protos.Enums {

  /// <summary>Holder for reflection information generated from Cv3PKM.Protos/Enums/PokemonFamilyId.proto</summary>
  public static partial class PokemonFamilyIdReflection {

    #region Descriptor
    /// <summary>File descriptor for Cv3PKM.Protos/Enums/PokemonFamilyId.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PokemonFamilyIdReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZQT0dPUHJvdG9zL0VudW1zL1Bva2Vtb25GYW1pbHlJZC5wcm90bxIQUE9H",
            "T1Byb3Rvcy5FbnVtcyr6DAoPUG9rZW1vbkZhbWlseUlkEhAKDEZBTUlMWV9V",
            "TlNFVBAAEhQKEEZBTUlMWV9CVUxCQVNBVVIQARIVChFGQU1JTFlfQ0hBUk1B",
            "TkRFUhAEEhMKD0ZBTUlMWV9TUVVJUlRMRRAHEhMKD0ZBTUlMWV9DQVRFUlBJ",
            "RRAKEhEKDUZBTUlMWV9XRUVETEUQDRIRCg1GQU1JTFlfUElER0VZEBASEgoO",
            "RkFNSUxZX1JBVFRBVEEQExISCg5GQU1JTFlfU1BFQVJPVxAVEhAKDEZBTUlM",
            "WV9FS0FOUxAXEhIKDkZBTUlMWV9QSUtBQ0hVEBkSFAoQRkFNSUxZX1NBTkRT",
            "SFJFVxAbEhkKFUZBTUlMWV9OSURPUkFOX0ZFTUFMRRAdEhcKE0ZBTUlMWV9O",
            "SURPUkFOX01BTEUQIBITCg9GQU1JTFlfQ0xFRkFJUlkQIxIRCg1GQU1JTFlf",
            "VlVMUElYECUSFQoRRkFNSUxZX0pJR0dMWVBVRkYQJxIQCgxGQU1JTFlfWlVC",
            "QVQQKRIRCg1GQU1JTFlfT0RESVNIECsSEAoMRkFNSUxZX1BBUkFTEC4SEgoO",
            "RkFNSUxZX1ZFTk9OQVQQMBISCg5GQU1JTFlfRElHTEVUVBAyEhEKDUZBTUlM",
            "WV9NRU9XVEgQNBISCg5GQU1JTFlfUFNZRFVDSxA2EhEKDUZBTUlMWV9NQU5L",
            "RVkQOBIUChBGQU1JTFlfR1JPV0xJVEhFEDoSEgoORkFNSUxZX1BPTElXQUcQ",
            "PBIPCgtGQU1JTFlfQUJSQRA/EhEKDUZBTUlMWV9NQUNIT1AQQhIVChFGQU1J",
            "TFlfQkVMTFNQUk9VVBBFEhQKEEZBTUlMWV9URU5UQUNPT0wQSBISCg5GQU1J",
            "TFlfR0VPRFVERRBKEhEKDUZBTUlMWV9QT05ZVEEQTRITCg9GQU1JTFlfU0xP",
            "V1BPS0UQTxIUChBGQU1JTFlfTUFHTkVNSVRFEFESFAoQRkFNSUxZX0ZBUkZF",
            "VENIRBBTEhAKDEZBTUlMWV9ET0RVTxBUEg8KC0ZBTUlMWV9TRUVMEFYSEQoN",
            "RkFNSUxZX0dSSU1FUhBYEhMKD0ZBTUlMWV9TSEVMTERFUhBaEhEKDUZBTUlM",
            "WV9HQVNUTFkQXBIPCgtGQU1JTFlfT05JWBBfEhIKDkZBTUlMWV9EUk9XWkVF",
            "EGASEAoMRkFNSUxZX0hZUE5PEGESEQoNRkFNSUxZX0tSQUJCWRBiEhIKDkZB",
            "TUlMWV9WT0xUT1JCEGQSFAoQRkFNSUxZX0VYRUdHQ1VURRBmEhEKDUZBTUlM",
            "WV9DVUJPTkUQaBIUChBGQU1JTFlfSElUTU9OTEVFEGoSFQoRRkFNSUxZX0hJ",
            "VE1PTkNIQU4QaxIUChBGQU1JTFlfTElDS0lUVU5HEGwSEgoORkFNSUxZX0tP",
            "RkZJTkcQbRISCg5GQU1JTFlfUkhZSE9SThBvEhIKDkZBTUlMWV9DSEFOU0VZ",
            "EHESEgoORkFNSUxZX1RBTkdFTEEQchIVChFGQU1JTFlfS0FOR0FTS0hBThBz",
            "EhEKDUZBTUlMWV9IT1JTRUEQdBISCg5GQU1JTFlfR09MREVFThB2EhEKDUZB",
            "TUlMWV9TVEFSWVUQeBISCg5GQU1JTFlfTVJfTUlNRRB6EhIKDkZBTUlMWV9T",
            "Q1lUSEVSEHsSDwoLRkFNSUxZX0pZTlgQfBIVChFGQU1JTFlfRUxFQ1RBQlVa",
            "WhB9EhEKDUZBTUlMWV9NQUdNQVIQfhIRCg1GQU1JTFlfUElOU0lSEH8SEgoN",
            "RkFNSUxZX1RBVVJPUxCAARIUCg9GQU1JTFlfTUFHSUtBUlAQgQESEgoNRkFN",
            "SUxZX0xBUFJBUxCDARIRCgxGQU1JTFlfRElUVE8QhAESEQoMRkFNSUxZX0VF",
            "VkVFEIUBEhMKDkZBTUlMWV9QT1JZR09OEIkBEhMKDkZBTUlMWV9PTUFOWVRF",
            "EIoBEhIKDUZBTUlMWV9LQUJVVE8QjAESFgoRRkFNSUxZX0FFUk9EQUNUWUwQ",
            "jgESEwoORkFNSUxZX1NOT1JMQVgQjwESFAoPRkFNSUxZX0FSVElDVU5PEJAB",
            "EhIKDUZBTUlMWV9aQVBET1MQkQESEwoORkFNSUxZX01PTFRSRVMQkgESEwoO",
            "RkFNSUxZX0RSQVRJTkkQkwESEgoNRkFNSUxZX01FV1RXTxCWARIPCgpGQU1J",
            "TFlfTUVXEJcBYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Cv3PKM.Protos.Enums.PokemonFamilyId), }, null));
    }
    #endregion

  }
  #region Enums
  public enum PokemonFamilyId {
    [pbr::OriginalName("FAMILY_UNSET")] FamilyUnset = 0,
    [pbr::OriginalName("FAMILY_BULBASAUR")] FamilyBulbasaur = 1,
    [pbr::OriginalName("FAMILY_CHARMANDER")] FamilyCharmander = 4,
    [pbr::OriginalName("FAMILY_SQUIRTLE")] FamilySquirtle = 7,
    [pbr::OriginalName("FAMILY_CATERPIE")] FamilyCaterpie = 10,
    [pbr::OriginalName("FAMILY_WEEDLE")] FamilyWeedle = 13,
    [pbr::OriginalName("FAMILY_PIDGEY")] FamilyPidgey = 16,
    [pbr::OriginalName("FAMILY_RATTATA")] FamilyRattata = 19,
    [pbr::OriginalName("FAMILY_SPEAROW")] FamilySpearow = 21,
    [pbr::OriginalName("FAMILY_EKANS")] FamilyEkans = 23,
    [pbr::OriginalName("FAMILY_PIKACHU")] FamilyPikachu = 25,
    [pbr::OriginalName("FAMILY_SANDSHREW")] FamilySandshrew = 27,
    [pbr::OriginalName("FAMILY_NIDORAN_FEMALE")] FamilyNidoranFemale = 29,
    [pbr::OriginalName("FAMILY_NIDORAN_MALE")] FamilyNidoranMale = 32,
    [pbr::OriginalName("FAMILY_CLEFAIRY")] FamilyClefairy = 35,
    [pbr::OriginalName("FAMILY_VULPIX")] FamilyVulpix = 37,
    [pbr::OriginalName("FAMILY_JIGGLYPUFF")] FamilyJigglypuff = 39,
    [pbr::OriginalName("FAMILY_ZUBAT")] FamilyZubat = 41,
    [pbr::OriginalName("FAMILY_ODDISH")] FamilyOddish = 43,
    [pbr::OriginalName("FAMILY_PARAS")] FamilyParas = 46,
    [pbr::OriginalName("FAMILY_VENONAT")] FamilyVenonat = 48,
    [pbr::OriginalName("FAMILY_DIGLETT")] FamilyDiglett = 50,
    [pbr::OriginalName("FAMILY_MEOWTH")] FamilyMeowth = 52,
    [pbr::OriginalName("FAMILY_PSYDUCK")] FamilyPsyduck = 54,
    [pbr::OriginalName("FAMILY_MANKEY")] FamilyMankey = 56,
    [pbr::OriginalName("FAMILY_GROWLITHE")] FamilyGrowlithe = 58,
    [pbr::OriginalName("FAMILY_POLIWAG")] FamilyPoliwag = 60,
    [pbr::OriginalName("FAMILY_ABRA")] FamilyAbra = 63,
    [pbr::OriginalName("FAMILY_MACHOP")] FamilyMachop = 66,
    [pbr::OriginalName("FAMILY_BELLSPROUT")] FamilyBellsprout = 69,
    [pbr::OriginalName("FAMILY_TENTACOOL")] FamilyTentacool = 72,
    [pbr::OriginalName("FAMILY_GEODUDE")] FamilyGeodude = 74,
    [pbr::OriginalName("FAMILY_PONYTA")] FamilyPonyta = 77,
    [pbr::OriginalName("FAMILY_SLOWPOKE")] FamilySlowpoke = 79,
    [pbr::OriginalName("FAMILY_MAGNEMITE")] FamilyMagnemite = 81,
    [pbr::OriginalName("FAMILY_FARFETCHD")] FamilyFarfetchd = 83,
    [pbr::OriginalName("FAMILY_DODUO")] FamilyDoduo = 84,
    [pbr::OriginalName("FAMILY_SEEL")] FamilySeel = 86,
    [pbr::OriginalName("FAMILY_GRIMER")] FamilyGrimer = 88,
    [pbr::OriginalName("FAMILY_SHELLDER")] FamilyShellder = 90,
    [pbr::OriginalName("FAMILY_GASTLY")] FamilyGastly = 92,
    [pbr::OriginalName("FAMILY_ONIX")] FamilyOnix = 95,
    [pbr::OriginalName("FAMILY_DROWZEE")] FamilyDrowzee = 96,
    [pbr::OriginalName("FAMILY_HYPNO")] FamilyHypno = 97,
    [pbr::OriginalName("FAMILY_KRABBY")] FamilyKrabby = 98,
    [pbr::OriginalName("FAMILY_VOLTORB")] FamilyVoltorb = 100,
    [pbr::OriginalName("FAMILY_EXEGGCUTE")] FamilyExeggcute = 102,
    [pbr::OriginalName("FAMILY_CUBONE")] FamilyCubone = 104,
    [pbr::OriginalName("FAMILY_HITMONLEE")] FamilyHitmonlee = 106,
    [pbr::OriginalName("FAMILY_HITMONCHAN")] FamilyHitmonchan = 107,
    [pbr::OriginalName("FAMILY_LICKITUNG")] FamilyLickitung = 108,
    [pbr::OriginalName("FAMILY_KOFFING")] FamilyKoffing = 109,
    [pbr::OriginalName("FAMILY_RHYHORN")] FamilyRhyhorn = 111,
    [pbr::OriginalName("FAMILY_CHANSEY")] FamilyChansey = 113,
    [pbr::OriginalName("FAMILY_TANGELA")] FamilyTangela = 114,
    [pbr::OriginalName("FAMILY_KANGASKHAN")] FamilyKangaskhan = 115,
    [pbr::OriginalName("FAMILY_HORSEA")] FamilyHorsea = 116,
    [pbr::OriginalName("FAMILY_GOLDEEN")] FamilyGoldeen = 118,
    [pbr::OriginalName("FAMILY_STARYU")] FamilyStaryu = 120,
    [pbr::OriginalName("FAMILY_MR_MIME")] FamilyMrMime = 122,
    [pbr::OriginalName("FAMILY_SCYTHER")] FamilyScyther = 123,
    [pbr::OriginalName("FAMILY_JYNX")] FamilyJynx = 124,
    [pbr::OriginalName("FAMILY_ELECTABUZZ")] FamilyElectabuzz = 125,
    [pbr::OriginalName("FAMILY_MAGMAR")] FamilyMagmar = 126,
    [pbr::OriginalName("FAMILY_PINSIR")] FamilyPinsir = 127,
    [pbr::OriginalName("FAMILY_TAUROS")] FamilyTauros = 128,
    [pbr::OriginalName("FAMILY_MAGIKARP")] FamilyMagikarp = 129,
    [pbr::OriginalName("FAMILY_LAPRAS")] FamilyLapras = 131,
    [pbr::OriginalName("FAMILY_DITTO")] FamilyDitto = 132,
    [pbr::OriginalName("FAMILY_EEVEE")] FamilyEevee = 133,
    [pbr::OriginalName("FAMILY_PORYGON")] FamilyPorygon = 137,
    [pbr::OriginalName("FAMILY_OMANYTE")] FamilyOmanyte = 138,
    [pbr::OriginalName("FAMILY_KABUTO")] FamilyKabuto = 140,
    [pbr::OriginalName("FAMILY_AERODACTYL")] FamilyAerodactyl = 142,
    [pbr::OriginalName("FAMILY_SNORLAX")] FamilySnorlax = 143,
    [pbr::OriginalName("FAMILY_ARTICUNO")] FamilyArticuno = 144,
    [pbr::OriginalName("FAMILY_ZAPDOS")] FamilyZapdos = 145,
    [pbr::OriginalName("FAMILY_MOLTRES")] FamilyMoltres = 146,
    [pbr::OriginalName("FAMILY_DRATINI")] FamilyDratini = 147,
    [pbr::OriginalName("FAMILY_MEWTWO")] FamilyMewtwo = 150,
    [pbr::OriginalName("FAMILY_MEW")] FamilyMew = 151,
  }

  #endregion

}

#endregion Designer generated code
