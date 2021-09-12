using System.Collections.Generic;

namespace BL3SteamDownpatcher {
  static partial class SteamManager {
    // There's an explanation of these categories work in SwitchVersion
    private static readonly List<VersionInfo> AllVersionInfo = new List<VersionInfo>() {
      new VersionInfo() {
        Name = "Crossplay",
        ProductVersion = "OAK-PATCHWIN64-49",

        Manifests = new Dictionary<Depot, ulong>() {
          { Depot.Exe, 8851756896253257352 },
          { Depot.Content, 7703060351365742124 },
          { Depot.Dandelion, 2224808001001900276 }
        },

        FilesToAdd = new Dictionary<Depot, HashSet<string>>() {
          { Depot.Dandelion, new HashSet<string>() {
            "OakGame/AdditionalContent/Dandelion/Movies/Mini_Marcus_Intro.mp4",
            "OakGame/AdditionalContent/Dandelion/Movies/VidScreen_PB_vid1_idle.mp4",
            "OakGame/AdditionalContent/Dandelion/Movies/VidScreen_PB_vid1_part1.mp4",
            "OakGame/AdditionalContent/Dandelion/Movies/VidScreen_PB_vid1_part1b.mp4",
            "OakGame/AdditionalContent/Dandelion/Movies/VidScreen_PB_vid1_part1c.mp4",
            "OakGame/AdditionalContent/Dandelion/Movies/VidScreen_PB_vid1_part2.mp4",
            "OakGame/AdditionalContent/Dandelion/Movies/VidScreen_PB_vid1_part3.mp4",
            "OakGame/AdditionalContent/Dandelion/Movies/VidScreen_PB_vid2_deal.mp4",
            "OakGame/AdditionalContent/Dandelion/Movies/VidScreen_PB_vid3_debt.mp4",
            "OakGame/AdditionalContent/Dandelion/Movies/VidScreen_PB_vid4_elevator.mp4",
            "OakGame/AdditionalContent/Dandelion/Movies/Video_Epilogue.mp4",
            "OakGame/AdditionalContent/Dandelion/Movies/Video_HandsomeJackVideo.mp4",
            "OakGame/AdditionalContent/Dandelion/Movies/Video_ThePlan_Phase01.mp4",
            "OakGame/AdditionalContent/Dandelion/Movies/Video_ThePlan_Phase02.mp4",
            "OakGame/AdditionalContent/Dandelion/Movies/Video_ThePlan_Phase03.mp4",
            "OakGame/AdditionalContent/Dandelion/Paks/Dandelion.pak",
          } }
        },

        FilesToReplace = new Dictionary<Depot, HashSet<string>>() {
          { Depot.Exe, new HashSet<string>() {
            "OakGame/Binaries/Win64/Borderlands3.exe",
          } },
          { Depot.Content, new HashSet<string>() {
            "Engine/Binaries/ThirdParty/bifrost/x64/Release/bifrost.dll",
          } }
        }
      },

      new VersionInfo() {
        Name = "Wedding DLC",
        ProductVersion = "OAK-PATCHWIN641-32",

        Manifests = new Dictionary<Depot, ulong>() {
          { Depot.Exe, 7547000681507208489 },
          { Depot.Content, 9125602441791928810 },
          { Depot.Dandelion, 9116600370569954686 },
          { Depot.Hibiscus, 5813394832320857277 }
        },

        FilesToAdd = new Dictionary<Depot, HashSet<string>>() {
          { Depot.Content, new HashSet<string>() {
            "OakGame/Content/Movies/citizenscience/CS_Intro_Video.mp4",
            "OakGame/Content/Movies/Mini_Marcus_Intro.mp4",
            "OakGame/Content/Paks/pakchunk10-WindowsNoEditor_1_P.pak",
            "OakGame/Content/Paks/pakchunk12-WindowsNoEditor_1_P.pak",
            "OakGame/Content/Paks/pakchunk2-WindowsNoEditor_4_P.pak",
            "OakGame/Content/Paks/pakchunk7-WindowsNoEditor_3_P.pak",
            "OakGame/Content/Paks/pakchunk79-WindowsNoEditor_0_P.pak",
            "OakGame/Content/Paks/pakchunk8-WindowsNoEditor_3_P.pak",
            "OakGame/Content/Paks/pakchunk80-WindowsNoEditor_0_P.pak",
          } },
          { Depot.Hibiscus, new HashSet<string>() {
            "OakGame/AdditionalContent/Hibiscus/Movies/Video_Hib_Invitation.mp4",
            "OakGame/AdditionalContent/Hibiscus/Paks/Hibiscus.pak",
          } },
        },

        FilesToReplace = new Dictionary<Depot, HashSet<string>>() {
          { Depot.Exe, new HashSet<string>() {
            "OakGame/Binaries/Win64/Borderlands3.exe",
          } },
          { Depot.Content, new HashSet<string>() {
            "Engine/Binaries/ThirdParty/bifrost/x64/Release/bifrost.dll",
            "OakGame/Content/Paks/pakchunk0-WindowsNoEditor_5_P.pak",
            "OakGame/Content/Paks/pakchunk1-WindowsNoEditor_5_P.pak",
            "OakGame/Content/Paks/pakchunk3-WindowsNoEditor_4_P.pak",
            "OakGame/Content/Paks/pakchunk4-WindowsNoEditor_5_P.pak",
            "OakGame/Content/Paks/pakchunk5-WindowsNoEditor_5_P.pak",
            "OakGame/Content/Paks/pakchunk6-WindowsNoEditor_5_P.pak",
            "OakGame/Content/Paks/pakchunk85-WindowsNoEditor_4_P.pak",
            "OakGame/Content/Paks/pakchunk86-WindowsNoEditor_4_P.pak",
            "OakGame/Content/Paks/pakchunk87-WindowsNoEditor_4_P.pak",
            "OakGame/Content/Paks/pakchunk88-WindowsNoEditor_4_P.pak",
            "OakGame/Content/Paks/pakchunk89-WindowsNoEditor_4_P.pak",
            "OakGame/Content/Paks/pakchunk90-WindowsNoEditor_4_P.pak",
            "OakGame/Content/Paks/pakchunk91-WindowsNoEditor_4_P.pak",
          } }
        }
      },

      new VersionInfo() {
        Name = "Cartel",
        ProductVersion = "OAK-PATCHWIN64-79",

        Manifests = new Dictionary<Depot, ulong>() {
          { Depot.Exe, 265569718868113474 },
          { Depot.Content, 7876158204252981163 },
          { Depot.Dandelion, 2224808001001900276 },
          { Depot.Hibiscus, 132348831915272916 }
        },

        FilesToAdd = new Dictionary<Depot, HashSet<string>>() {
          { Depot.Content, new HashSet<string>() {
            "OakGame/Content/Paks/pakchunk0-WindowsNoEditor_6_P.pak",
            "OakGame/Content/Paks/pakchunk1-WindowsNoEditor_6_P.pak",
            "OakGame/Content/Paks/pakchunk2-WindowsNoEditor_5_P.pak",
            "OakGame/Content/Paks/pakchunk3-WindowsNoEditor_5_P.pak",
            "OakGame/Content/Paks/pakchunk4-WindowsNoEditor_6_P.pak",
            "OakGame/Content/Paks/pakchunk5-WindowsNoEditor_6_P.pak",
            "OakGame/Content/Paks/pakchunk6-WindowsNoEditor_6_P.pak",
            "OakGame/Content/Paks/pakchunk7-WindowsNoEditor_4_P.pak",
            "OakGame/Content/Paks/pakchunk8-WindowsNoEditor_4_P.pak",
            "OakGame/Content/Paks/pakchunk10-WindowsNoEditor_2_P.pak",
            "OakGame/Content/Paks/pakchunk11-WindowsNoEditor_1_P.pak",
            "OakGame/Content/Paks/pakchunk12-WindowsNoEditor_2_P.pak",
            "OakGame/Content/Paks/pakchunk15-WindowsNoEditor_1_P.pak",
            "OakGame/Content/Paks/pakchunk16-WindowsNoEditor_0_P.pak",
            "OakGame/Content/Paks/pakchunk83-WindowsNoEditor_5_P.pak",
            "OakGame/Content/Paks/pakchunk84-WindowsNoEditor_3_P.pak",
            "OakGame/Content/Paks/pakchunk85-WindowsNoEditor_5_P.pak",
            "OakGame/Content/Paks/pakchunk86-WindowsNoEditor_5_P.pak",
            "OakGame/Content/Paks/pakchunk87-WindowsNoEditor_5_P.pak",
            "OakGame/Content/Paks/pakchunk88-WindowsNoEditor_5_P.pak",
            "OakGame/Content/Paks/pakchunk89-WindowsNoEditor_5_P.pak",
            "OakGame/Content/Paks/pakchunk90-WindowsNoEditor_5_P.pak",
            "OakGame/Content/Paks/pakchunk91-WindowsNoEditor_5_P.pak",
          } },
        },

        FilesToReplace = new Dictionary<Depot, HashSet<string>>() {
          { Depot.Exe, new HashSet<string>() {
            "OakGame/Binaries/Win64/Borderlands3.exe",
          } },
          { Depot.Content, new HashSet<string>() {
            "Engine/Binaries/ThirdParty/bifrost/x64/Release/bifrost.dll",
            "OakGame/Content/Movies/Mini_Marcus_Intro.mp4",
          } },
          { Depot.Hibiscus, new HashSet<string>() {
            "OakGame/AdditionalContent/Hibiscus/Paks/Hibiscus.pak",
          } }
        }
      },

      new VersionInfo() {
        Name = "Guardian Takedown",
        ProductVersion = "OAK-PATCHWIN641-63",

        Manifests = new Dictionary<Depot, ulong>() {
          { Depot.Exe, 8658062450546276143 },
          { Depot.Content, 8532186557501406837 },
          { Depot.Dandelion, 9116600370569954686 },
          { Depot.Hibiscus, 132348831915272916 }
        },

        FilesToAdd = new Dictionary<Depot, HashSet<string>>() {
          { Depot.Content, new HashSet<string>() {
            "OakGame/Content/Paks/pakchunk0-WindowsNoEditor_7_P.pak",
            "OakGame/Content/Paks/pakchunk1-WindowsNoEditor_7_P.pak",
            "OakGame/Content/Paks/pakchunk2-WindowsNoEditor_6_P.pak",
            "OakGame/Content/Paks/pakchunk3-WindowsNoEditor_6_P.pak",
            "OakGame/Content/Paks/pakchunk4-WindowsNoEditor_7_P.pak",
            "OakGame/Content/Paks/pakchunk5-WindowsNoEditor_7_P.pak",
            "OakGame/Content/Paks/pakchunk6-WindowsNoEditor_7_P.pak",
            "OakGame/Content/Paks/pakchunk7-WindowsNoEditor_5_P.pak",
            "OakGame/Content/Paks/pakchunk8-WindowsNoEditor_5_P.pak",
            "OakGame/Content/Paks/pakchunk9-WindowsNoEditor_1_P.pak",
            "OakGame/Content/Paks/pakchunk12-WindowsNoEditor_3_P.pak",
            "OakGame/Content/Paks/pakchunk83-WindowsNoEditor_6_P.pak",
            "OakGame/Content/Paks/pakchunk84-WindowsNoEditor_4_P.pak",
            "OakGame/Content/Paks/pakchunk85-WindowsNoEditor_6_P.pak",
            "OakGame/Content/Paks/pakchunk86-WindowsNoEditor_6_P.pak",
            "OakGame/Content/Paks/pakchunk87-WindowsNoEditor_6_P.pak",
            "OakGame/Content/Paks/pakchunk88-WindowsNoEditor_6_P.pak",
            "OakGame/Content/Paks/pakchunk89-WindowsNoEditor_6_P.pak",
            "OakGame/Content/Paks/pakchunk90-WindowsNoEditor_6_P.pak",
            "OakGame/Content/Paks/pakchunk91-WindowsNoEditor_6_P.pak",
          } }
        },

        FilesToReplace = new Dictionary<Depot, HashSet<string>>() {
          { Depot.Exe, new HashSet<string>() {
            "OakGame/Binaries/Win64/Borderlands3.exe",
          } },
          { Depot.Content, new HashSet<string>() {
            "Engine/Binaries/ThirdParty/bifrost/x64/Release/bifrost.dll",
          } }
        }
      },

      new VersionInfo() {
        Name = "Bounty DLC",
        ProductVersion = "OAK-PATCHWIN640-59",

        Manifests = new Dictionary<Depot, ulong>() {
          { Depot.Exe, 6672683706528298463 },
          { Depot.Content, 2110776543785706833 },
          { Depot.Dandelion, 2224808001001900276 },
          { Depot.Hibiscus, 132348831915272916 },
          { Depot.Geranium, 2109884503557559104 }
        },

        FilesToAdd = new Dictionary<Depot, HashSet<string>>() {
          { Depot.Content, new HashSet<string>() {
            "OakGame/Content/Paks/pakchunk0-WindowsNoEditor_8_P.pak",
            "OakGame/Content/Paks/pakchunk1-WindowsNoEditor_8_P.pak",
            "OakGame/Content/Paks/pakchunk2-WindowsNoEditor_7_P.pak",
            "OakGame/Content/Paks/pakchunk3-WindowsNoEditor_7_P.pak",
            "OakGame/Content/Paks/pakchunk4-WindowsNoEditor_8_P.pak",
            "OakGame/Content/Paks/pakchunk5-WindowsNoEditor_8_P.pak",
            "OakGame/Content/Paks/pakchunk6-WindowsNoEditor_8_P.pak",
            "OakGame/Content/Paks/pakchunk7-WindowsNoEditor_6_P.pak",
            "OakGame/Content/Paks/pakchunk10-WindowsNoEditor_3_P.pak",
            "OakGame/Content/Paks/pakchunk12-WindowsNoEditor_4_P.pak",
            "OakGame/Content/Paks/pakchunk85-WindowsNoEditor_7_P.pak",
            "OakGame/Content/Paks/pakchunk86-WindowsNoEditor_7_P.pak",
            "OakGame/Content/Paks/pakchunk87-WindowsNoEditor_7_P.pak",
            "OakGame/Content/Paks/pakchunk88-WindowsNoEditor_7_P.pak",
            "OakGame/Content/Paks/pakchunk89-WindowsNoEditor_7_P.pak",
            "OakGame/Content/Paks/pakchunk90-WindowsNoEditor_7_P.pak",
            "OakGame/Content/Paks/pakchunk91-WindowsNoEditor_7_P.pak",
          } },
          { Depot.Geranium, new HashSet<string>() {
            "OakGame/AdditionalContent/Geranium/Movies/GER-Film_Reel_00.mp4",
            "OakGame/AdditionalContent/Geranium/Movies/GER-Film_Reel_01.mp4",
            "OakGame/AdditionalContent/Geranium/Movies/GER-Film_Reel_02.mp4",
            "OakGame/AdditionalContent/Geranium/Movies/GER-Film_Reel_03.mp4",
            "OakGame/AdditionalContent/Geranium/Movies/GER-Film_Reel_04.mp4",
            "OakGame/AdditionalContent/Geranium/Movies/GER-Film_Reel_05.mp4",
            "OakGame/AdditionalContent/Geranium/Movies/GER-Film_Reel_06.mp4",
            "OakGame/AdditionalContent/Geranium/Movies/GER-Film_Reel_07.mp4",
            "OakGame/AdditionalContent/Geranium/Movies/GER-Intro.mp4",
            "OakGame/AdditionalContent/Geranium/Paks/Geranium.pak",
          } }
        },

        FilesToReplace = new Dictionary<Depot, HashSet<string>>() {
          { Depot.Exe, new HashSet<string>() {
            "OakGame/Binaries/Win64/Borderlands3.exe",
          } },
          { Depot.Content, new HashSet<string>() {
            "Engine/Binaries/ThirdParty/bifrost/x64/Release/bifrost.dll",
          } }
        }
      },

      new VersionInfo() {
        Name = "Drop Changes",
        ProductVersion = "OAK-PATCHWIN64-123",

        Manifests = new Dictionary<Depot, ulong>() {
          { Depot.Exe, 5671165083609614327 },
          { Depot.Content, 3882770681936523335 },
          { Depot.Dandelion, 2224808001001900276 },
          { Depot.Hibiscus, 132348831915272916 },
          { Depot.Geranium, 158003333842542987 }
        },

        FilesToAdd = new Dictionary<Depot, HashSet<string>>() {
          { Depot.Content, new HashSet<string>() {
            "OakGame/Content/Paks/pakchunk0-WindowsNoEditor_9_P.pak",
            "OakGame/Content/Paks/pakchunk1-WindowsNoEditor_9_P.pak",
            "OakGame/Content/Paks/pakchunk2-WindowsNoEditor_8_P.pak",
            "OakGame/Content/Paks/pakchunk3-WindowsNoEditor_8_P.pak",
            "OakGame/Content/Paks/pakchunk4-WindowsNoEditor_9_P.pak",
            "OakGame/Content/Paks/pakchunk5-WindowsNoEditor_9_P.pak",
            "OakGame/Content/Paks/pakchunk7-WindowsNoEditor_7_P.pak",
            "OakGame/Content/Paks/pakchunk12-WindowsNoEditor_5_P.pak",
            "OakGame/Content/Paks/pakchunk45-WindowsNoEditor_0_P.pak",
            "OakGame/Content/Paks/pakchunk73-WindowsNoEditor_0_P.pak",
            "OakGame/Content/Paks/pakchunk74-WindowsNoEditor_0_P.pak",
            "OakGame/Content/Paks/pakchunk85-WindowsNoEditor_8_P.pak",
            "OakGame/Content/Paks/pakchunk86-WindowsNoEditor_8_P.pak",
            "OakGame/Content/Paks/pakchunk87-WindowsNoEditor_8_P.pak",
            "OakGame/Content/Paks/pakchunk88-WindowsNoEditor_8_P.pak",
            "OakGame/Content/Paks/pakchunk89-WindowsNoEditor_8_P.pak",
            "OakGame/Content/Paks/pakchunk90-WindowsNoEditor_8_P.pak",
            "OakGame/Content/Paks/pakchunk91-WindowsNoEditor_8_P.pak",
          } }
        },

        FilesToReplace = new Dictionary<Depot, HashSet<string>>() {
          { Depot.Exe, new HashSet<string>() {
            "OakGame/Binaries/Win64/Borderlands3.exe",
          } }
        },

        FilesToDelete = new Dictionary<Depot, HashSet<string>>() {
          { Depot.Content, new HashSet<string>() {
            "Engine/Programs/CrashReportClient/Content/Paks/CrashReportClient.pak",
            "Engine/Binaries/Win64/CrashReportClient.exe"
          } }
        }
      },

      new VersionInfo() {
        Name = "Krieg DLC",
        ProductVersion = "OAK-PATCHWIN641-118",

        Manifests = new Dictionary<Depot, ulong>() {
          { Depot.Exe, 565172304258303085 },
          { Depot.Content, 6377891187593103666 },
          { Depot.Dandelion, 9116600370569954686 },
          { Depot.Hibiscus, 132348831915272916 },
          { Depot.Geranium, 350750707932598048 },
          { Depot.Alisma, 5627198090468988485 }
        },

        FilesToAdd = new Dictionary<Depot, HashSet<string>>() {
          { Depot.Content, new HashSet<string>() {
            "OakGame/Content/Paks/pakchunk0-WindowsNoEditor_10_P.pak",
            "OakGame/Content/Paks/pakchunk1-WindowsNoEditor_10_P.pak",
            "OakGame/Content/Paks/pakchunk2-WindowsNoEditor_9_P.pak",
            "OakGame/Content/Paks/pakchunk3-WindowsNoEditor_9_P.pak",
            "OakGame/Content/Paks/pakchunk4-WindowsNoEditor_10_P.pak",
            "OakGame/Content/Paks/pakchunk5-WindowsNoEditor_10_P.pak",
            "OakGame/Content/Paks/pakchunk6-WindowsNoEditor_9_P.pak",
            "OakGame/Content/Paks/pakchunk7-WindowsNoEditor_8_P.pak",
            "OakGame/Content/Paks/pakchunk12-WindowsNoEditor_6_P.pak",
            "OakGame/Content/Paks/pakchunk85-WindowsNoEditor_9_P.pak",
            "OakGame/Content/Paks/pakchunk86-WindowsNoEditor_9_P.pak",
            "OakGame/Content/Paks/pakchunk87-WindowsNoEditor_9_P.pak",
            "OakGame/Content/Paks/pakchunk88-WindowsNoEditor_9_P.pak",
            "OakGame/Content/Paks/pakchunk89-WindowsNoEditor_9_P.pak",
            "OakGame/Content/Paks/pakchunk90-WindowsNoEditor_9_P.pak",
            "OakGame/Content/Paks/pakchunk91-WindowsNoEditor_9_P.pak",
          } },
          { Depot.Alisma, new HashSet<string>() {
            "OakGame/AdditionalContent/Alisma/Movies/Video_Ali_Intro.mp4",
            "OakGame/AdditionalContent/Alisma/Paks/Alisma.pak",
          } }
        },

        FilesToReplace = new Dictionary<Depot, HashSet<string>>() {
          { Depot.Exe, new HashSet<string>() {
            "OakGame/Binaries/Win64/Borderlands3.exe",
          } }
        },
      },

      new VersionInfo() {
        Name = "Arms Race P1",
        ProductVersion = "OAK-PATCHWIN640-149",

        Manifests = new Dictionary<Depot, ulong>() {
          { Depot.Exe, 4791711210192274705 },
          { Depot.Content, 9220698735985578478 },
          { Depot.Dandelion, 2224808001001900276 },
          { Depot.Hibiscus, 132348831915272916 },
          { Depot.Geranium, 2109884503557559104 },
          { Depot.Alisma, 5627198090468988485 },
          { Depot.Ixora, 5818922910671489918 }
        },

        FilesToAdd = new Dictionary<Depot, HashSet<string>>() {
          { Depot.Content, new HashSet<string>() {
            "OakGame/Content/Paks/pakchunk0-WindowsNoEditor_11_P.pak",
            "OakGame/Content/Paks/pakchunk1-WindowsNoEditor_11_P.pak",
            "OakGame/Content/Paks/pakchunk2-WindowsNoEditor_10_P.pak",
            "OakGame/Content/Paks/pakchunk3-WindowsNoEditor_10_P.pak",
            "OakGame/Content/Paks/pakchunk4-WindowsNoEditor_11_P.pak",
            "OakGame/Content/Paks/pakchunk5-WindowsNoEditor_11_P.pak",
            "OakGame/Content/Paks/pakchunk6-WindowsNoEditor_10_P.pak",
            "OakGame/Content/Paks/pakchunk7-WindowsNoEditor_9_P.pak",
            "OakGame/Content/Paks/pakchunk8-WindowsNoEditor_6_P.pak",
            "OakGame/Content/Paks/pakchunk9-WindowsNoEditor_2_P.pak",
            "OakGame/Content/Paks/pakchunk10-WindowsNoEditor_4_P.pak",
            "OakGame/Content/Paks/pakchunk12-WindowsNoEditor_7_P.pak",
            "OakGame/Content/Paks/pakchunk37-WindowsNoEditor_0_P.pak",
            "OakGame/Content/Paks/pakchunk85-WindowsNoEditor_10_P.pak",
            "OakGame/Content/Paks/pakchunk86-WindowsNoEditor_10_P.pak",
            "OakGame/Content/Paks/pakchunk87-WindowsNoEditor_10_P.pak",
            "OakGame/Content/Paks/pakchunk88-WindowsNoEditor_10_P.pak",
            "OakGame/Content/Paks/pakchunk89-WindowsNoEditor_10_P.pak",
            "OakGame/Content/Paks/pakchunk90-WindowsNoEditor_10_P.pak",
            "OakGame/Content/Paks/pakchunk91-WindowsNoEditor_10_P.pak"
          } },
          { Depot.Ixora, new HashSet<string>() {
            "OakGame/AdditionalContent/Ixora/Paks/Ixora.pak"
          } }
        },

        FilesToReplace = new Dictionary<Depot, HashSet<string>>() {
          { Depot.Exe, new HashSet<string>() {
            "OakGame/Binaries/Win64/Borderlands3.exe",
          } }
        },
      },

      new VersionInfo() {
        Name = "Arms Race P2",
        ProductVersion = "OAK-PATCHWIN64-127",

        Manifests = new Dictionary<Depot, ulong>() {
          { Depot.Exe, 5571769405703134722 },
          { Depot.Content, 7353255475058564268 },
          { Depot.Dandelion, 2224808001001900276 },
          { Depot.Hibiscus, 132348831915272916 },
          { Depot.Geranium, 158003333842542987 },
          { Depot.Alisma, 5627198090468988485 },
          { Depot.Ixora, 988244885201248028 }
        },

        FilesToAdd = new Dictionary<Depot, HashSet<string>>() {
          { Depot.Content, new HashSet<string>() {
            "OakGame/Content/Paks/pakchunk0-WindowsNoEditor_12_P.pak",
            "OakGame/Content/Paks/pakchunk1-WindowsNoEditor_12_P.pak",
            "OakGame/Content/Paks/pakchunk3-WindowsNoEditor_11_P.pak",
            "OakGame/Content/Paks/pakchunk4-WindowsNoEditor_12_P.pak",
            "OakGame/Content/Paks/pakchunk5-WindowsNoEditor_12_P.pak",
            "OakGame/Content/Paks/pakchunk17-WindowsNoEditor_0_P.pak",
            "OakGame/Content/Paks/pakchunk37-WindowsNoEditor_1_P.pak",
            "OakGame/Content/Paks/pakchunk51-WindowsNoEditor_0_P.pak",
            "OakGame/Content/Paks/pakchunk52-WindowsNoEditor_0_P.pak",
            "OakGame/Content/Paks/pakchunk85-WindowsNoEditor_11_P.pak",
            "OakGame/Content/Paks/pakchunk86-WindowsNoEditor_11_P.pak",
            "OakGame/Content/Paks/pakchunk87-WindowsNoEditor_11_P.pak",
            "OakGame/Content/Paks/pakchunk88-WindowsNoEditor_11_P.pak",
            "OakGame/Content/Paks/pakchunk89-WindowsNoEditor_11_P.pak",
            "OakGame/Content/Paks/pakchunk90-WindowsNoEditor_11_P.pak",
            "OakGame/Content/Paks/pakchunk91-WindowsNoEditor_11_P.pak"
          } }
        },

        FilesToReplace = new Dictionary<Depot, HashSet<string>>() {
          { Depot.Exe, new HashSet<string>() {
            "OakGame/Binaries/Win64/Borderlands3.exe",
          } }
        },
      },

      new VersionInfo() {
        Name = "The Big Sad Patch",
        ProductVersion = "OAK-PATCHWIN640-172",

        Manifests = new Dictionary<Depot, ulong>() {
          { Depot.Exe, 5810392720910730831 },
          { Depot.Content, 9115761061575575949 },
          { Depot.Dandelion, 9116600370569954686 },
          { Depot.Hibiscus, 132348831915272916 },
          { Depot.Geranium, 350750707932598048 },
          { Depot.Alisma, 5627198090468988485 },
          { Depot.Ixora, 988244885201248028 }
        },

        FilesToAdd = new Dictionary<Depot, HashSet<string>>() {
          { Depot.Content, new HashSet<string>() {
            "OakGame/Content/Paks/pakchunk0-WindowsNoEditor_13_P.pak",
            "OakGame/Content/Paks/pakchunk1-WindowsNoEditor_13_P.pak",
            "OakGame/Content/Paks/pakchunk3-WindowsNoEditor_12_P.pak",
            "OakGame/Content/Paks/pakchunk4-WindowsNoEditor_13_P.pak",
            "OakGame/Content/Paks/pakchunk5-WindowsNoEditor_13_P.pak",
            "OakGame/Content/Paks/pakchunk6-WindowsNoEditor_11_P.pak",
            "OakGame/Content/Paks/pakchunk7-WindowsNoEditor_10_P.pak",
            "OakGame/Content/Paks/pakchunk9-WindowsNoEditor_3_P.pak",
            "OakGame/Content/Paks/pakchunk12-WindowsNoEditor_8_P.pak",
            "OakGame/Content/Paks/pakchunk85-WindowsNoEditor_12_P.pak",
            "OakGame/Content/Paks/pakchunk86-WindowsNoEditor_12_P.pak",
            "OakGame/Content/Paks/pakchunk87-WindowsNoEditor_12_P.pak",
            "OakGame/Content/Paks/pakchunk88-WindowsNoEditor_12_P.pak",
            "OakGame/Content/Paks/pakchunk89-WindowsNoEditor_12_P.pak",
            "OakGame/Content/Paks/pakchunk90-WindowsNoEditor_12_P.pak",
            "OakGame/Content/Paks/pakchunk91-WindowsNoEditor_12_P.pak"
          } }
        },

        FilesToReplace = new Dictionary<Depot, HashSet<string>>() {
          { Depot.Exe, new HashSet<string>() {
            "OakGame/Binaries/Win64/Borderlands3.exe",
          } }
        },
      },

      new VersionInfo() {
        Name = "Raid Boss",
        ProductVersion = "OAK-PATCHWIN641-227",

        Manifests = new Dictionary<Depot, ulong>() {
          { Depot.Exe, 1716329513611496854 },
          { Depot.Content, 6971997046543778548 },
          { Depot.Dandelion, 2224808001001900276 },
          { Depot.Hibiscus, 132348831915272916 },
          { Depot.Geranium, 2109884503557559104 },
          { Depot.Alisma, 5627198090468988485 },
          { Depot.Ixora, 5818922910671489918 },
          { Depot.Ixora2, 8226097640942912719 }
        },

        FilesToAdd = new Dictionary<Depot, HashSet<string>>() {
          { Depot.Content, new HashSet<string>() {
            "OakGame/Content/Paks/pakchunk0-WindowsNoEditor_14_P.pak",
            "OakGame/Content/Paks/pakchunk1-WindowsNoEditor_14_P.pak",
            "OakGame/Content/Paks/pakchunk2-WindowsNoEditor_11_P.pak",
            "OakGame/Content/Paks/pakchunk3-WindowsNoEditor_13_P.pak",
            "OakGame/Content/Paks/pakchunk4-WindowsNoEditor_14_P.pak",
            "OakGame/Content/Paks/pakchunk5-WindowsNoEditor_14_P.pak",
            "OakGame/Content/Paks/pakchunk6-WindowsNoEditor_12_P.pak",
            "OakGame/Content/Paks/pakchunk7-WindowsNoEditor_11_P.pak",
            "OakGame/Content/Paks/pakchunk8-WindowsNoEditor_7_P.pak",
            "OakGame/Content/Paks/pakchunk12-WindowsNoEditor_9_P.pak",
            "OakGame/Content/Paks/pakchunk13-WindowsNoEditor_0_P.pak",
            "OakGame/Content/Paks/pakchunk14-WindowsNoEditor_0_P.pak",
            "OakGame/Content/Paks/pakchunk15-WindowsNoEditor_2_P.pak",
            "OakGame/Content/Paks/pakchunk16-WindowsNoEditor_1_P.pak",
            "OakGame/Content/Paks/pakchunk21-WindowsNoEditor_0_P.pak",
            "OakGame/Content/Paks/pakchunk22-WindowsNoEditor_0_P.pak",
            "OakGame/Content/Paks/pakchunk23-WindowsNoEditor_0_P.pak",
            "OakGame/Content/Paks/pakchunk24-WindowsNoEditor_0_P.pak",
            "OakGame/Content/Paks/pakchunk25-WindowsNoEditor_0_P.pak",
            "OakGame/Content/Paks/pakchunk26-WindowsNoEditor_0_P.pak",
            "OakGame/Content/Paks/pakchunk45-WindowsNoEditor_1_P.pak",
            "OakGame/Content/Paks/pakchunk46-WindowsNoEditor_0_P.pak",
            "OakGame/Content/Paks/pakchunk53-WindowsNoEditor_0_P.pak",
            "OakGame/Content/Paks/pakchunk54-WindowsNoEditor_0_P.pak",
            "OakGame/Content/Paks/pakchunk85-WindowsNoEditor_13_P.pak",
            "OakGame/Content/Paks/pakchunk86-WindowsNoEditor_13_P.pak",
            "OakGame/Content/Paks/pakchunk87-WindowsNoEditor_13_P.pak",
            "OakGame/Content/Paks/pakchunk88-WindowsNoEditor_13_P.pak",
            "OakGame/Content/Paks/pakchunk89-WindowsNoEditor_13_P.pak",
            "OakGame/Content/Paks/pakchunk90-WindowsNoEditor_13_P.pak",
            "OakGame/Content/Paks/pakchunk91-WindowsNoEditor_13_P.pak",
          } },
          { Depot.Ixora2, new HashSet<string>() {
            "OakGame/AdditionalContent/Ixora2/Movies/_MUSIC_GSQ_LD_Cycle15.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/_MUSIC_Level_Team_update_-_GSQ_Motorcade_ObjectiveBlocking_IT01.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/Art_Corner_Flythrough.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BL3_CYCLE.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_AN_Claptrap.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_AN_Cycle15RnR.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_AN_Cycle26RnR.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_AN_Gun_Ad_Jakobs_mp4.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_AN_Gun_Ad_Maliwan_Anti_COV.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_AN_Gun_Ad_Maliwan_Neutral.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_AN_Gun_Ad_Maliwan_Pro_COV.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_AN_Gun_Ad_Maliwan_Tweaks.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_AN_Gun_Ad_Torgue_Toasted_mp4.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_AN_Gun_Ad_Torgue.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_AN_Gun_Ad_Vladof.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_AN_Intro04.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_AN_IntroPreVis.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_AN_Lilith.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_AN_LineArtRevealBasic.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_AN_LineArtRevealHelios.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_AN_MarcusIntroStyle.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_AN_MarcusIntroTransition.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_AN_MarcusMocap_Test01.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_AN_Mayafuneral.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_AN_MotionAndDesign.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_AN_PainAndTerror.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_AN_Parallax.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_AN_PopUpBookStyle01.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_AN_PopUpBookStyle02.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_AN_PsychoMocap.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_AN_RnRIntroPreVis.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_AN_ShadowPuppet.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_AN_SprayPaint.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_AN_Streaming_Sample_Lilith.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_AU_Audio_Gore.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_AU_COV.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_AU_Creatures.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_AU_Explosions.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_AU_Hyperion.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_AU_IronBear.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_AU_Maliwan.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_AU_Splodeos.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_AU_Tediore.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_AU_Torgue.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_AU_Vehicles.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_AU_Vladof.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_AU_Weapon-Actions-Reloads_3.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_AU_Weapon-Firing.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_BB_BadassGrasp.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_BB_BoxBoat.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_BB_CatchARide.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_BB_Claptrap.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_BB_DoNotBugBug.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_BB_DoNotBugBug2.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_BB_DontLook.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_BB_Ellie.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_BB_ErraticGraveward.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_BB_Eyes.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_BB_FloatingGrenades.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_BB_GetThatChecked.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_BB_GettingABoost.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_BB_HappyDriver.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_BB_HighHealth.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_BB_InfiniteMeleeRewards.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_BB_KilAVolt.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_BB_LostCrazyEarl.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_BB_LyingHips.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_BB_MozeIsCold.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_BB_NoGravityBullets.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_BB_Nope.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_BB_NopeNope.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_BB_NoReward.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_BB_NormalWalking.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_BB_PerfectScale.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_BB_PsychoBug.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_BB_PsychoPush.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_BB_PsychosInTheSky.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_BB_ReadyToFly.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_BB_SeeingDouble.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_BB_StompKO.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_BB_SuperJump.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_BB_SurvivedExtinction.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_BB_TheEarlyYears.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_BB_TheresAWallThere.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_BB_Tina.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_BB_TinkDeflation.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_BB_TinkPets.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_BB_VehicleWrestling.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_BB_WhereAreYou.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_BB_WhereAreYou2.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_BB_WhereAreYou3.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_CH_BeastmasterSpiderantPet.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_CH_CharSelect.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_CH_directors.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_CH_Operative02RealityTunnel.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_CH_Operative03DigiClone.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_CH_Operative04SNTRY.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_CH_OperativeDigiClone.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_CH_Phaseblast_1.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_CH_Phaseblast_3.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_CH_Phasedash.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_CH_PhaseDashSlam.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_CH_PhaseDashSlamExit.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_CH_PhaseDashSlamWall.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_CH_PhaseDashWeb.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_CH_PhaseDashWebWall.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_CH_PhaselinkAsendout.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_CH_PhaselinkBgrab.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_CH_PhaselinkC3rd.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_CH_PhaseWeb.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_CH_PlayerCharacterCycle17Review.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_CH_PlayerCharacterCycle18Review.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_CH_PlayerCharactersUpdate.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_CH_Sprint8Review.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_CH_WhatsNew.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_EN_CityBoss.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_EN_Cycle16Review.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_EN_EnemiesCycle15.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_EN_EnemiesCycle22Review.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_EN_EnemiesReviewCycle14.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_EN_EnemyCycle13.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_EN_KillCrewMissionExample.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_EN_Ratch_Run_Test_01.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_EN_TinkOnRatch.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_EN_VaultBossUpdateCycle25.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_MS_Borderlands_Greenfields.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_MS_Borderlands3_Greenfields.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_MS_DropshipEditor.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_MS_DropshipTest.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_MS_GearboxThanksYou.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_MS_GreatVaultModern.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_MS_GreatVaultRetro.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_MS_MaliwanPartnership.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_MS_MemoriamConcept.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_MS_OfferingstotheCause.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_MS_RecruitmentConcept.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_MS_TroyVictory.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_MS_TyreenVictory.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_MS_VaultThieves_01.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_MS_VaultThieves_02.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_SU_5Gunz.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_SU_CityVault.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_SU_CombatIOVignette.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_SU_CoverPlacement.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_SU_CoverUse.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_SU_Cycle15Systems.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_SU_Cycle18Systems.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_SU_Dodging.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_SU_Echo.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_SU_GameFeel.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_SU_Guns_02_06.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_SU_Guns06.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_SU_Guns07.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_SU_GunsDecember.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_SU_GunsQuarterly.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_SU_HyperionShotgun.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_SU_IETeam.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_SU_ReviewVoG.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_SU_SprintReview.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_SU_SystemsBAR.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_SU_TechArt_Cycle30.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_SU_UI.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_SU_UIPresentation101917.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_SU_UIPresentation82517.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_SU_VehiclesCycle17.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_SU_VehiclesIT01.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_WB_Adventure.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_WB_City.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_WB_CYCLE.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_WB_Flythrough.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_WB_GSQLDCycle15.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_WB_LevelArtCycle27.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_WB_LevelDesignCycle23.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_WB_LevelDesignFlythrough.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_WB_MarshFields.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_WB_Motorcade.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_WB_PlayerQuarters.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_WB_Prison.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_WB_Prologue.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_WB_PrometheaCity1.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_WB_Sprint.mp4",
            "OakGame/AdditionalContent/Ixora2/Movies/BTS_WB_Vig_Eridian.mp4",
            "OakGame/AdditionalContent/Ixora2/Paks/Ixora2.pak",
          } }
        },

        FilesToReplace = new Dictionary<Depot, HashSet<string>>() {
          { Depot.Exe, new HashSet<string>() {
            "OakGame/Binaries/Win64/Borderlands3.exe",
          } }
        },
      },

      new VersionInfo() {
        Name = "Unlocked Events",
        ProductVersion = "OAK-PATCHWIN640-226",

        Manifests = new Dictionary<Depot, ulong>() {
          { Depot.Exe, 5244045638775298058 },
          { Depot.Content, 8428033809087859114 },
          { Depot.Dandelion, 9116600370569954686 },
          { Depot.Hibiscus, 132348831915272916 },
          { Depot.Geranium, 350750707932598048 },
          { Depot.Alisma, 5627198090468988485 },
          { Depot.Ixora, 988244885201248028 },
          { Depot.Ixora2, 8226097640942912719 },
        },

        FilesToAdd = new Dictionary<Depot, HashSet<string>>() {
          { Depot.Content, new HashSet<string>() {
            "OakGame/Content/Paks/pakchunk0-WindowsNoEditor_15_P.pak",
            "OakGame/Content/Paks/pakchunk1-WindowsNoEditor_15_P.pak",
            "OakGame/Content/Paks/pakchunk3-WindowsNoEditor_14_P.pak",
            "OakGame/Content/Paks/pakchunk4-WindowsNoEditor_15_P.pak",
            "OakGame/Content/Paks/pakchunk5-WindowsNoEditor_15_P.pak",
            "OakGame/Content/Paks/pakchunk6-WindowsNoEditor_13_P.pak",
            "OakGame/Content/Paks/pakchunk9-WindowsNoEditor_4_P.pak",
            "OakGame/Content/Paks/pakchunk85-WindowsNoEditor_14_P.pak",
            "OakGame/Content/Paks/pakchunk86-WindowsNoEditor_14_P.pak",
            "OakGame/Content/Paks/pakchunk87-WindowsNoEditor_14_P.pak",
            "OakGame/Content/Paks/pakchunk89-WindowsNoEditor_14_P.pak",
            "OakGame/Content/Paks/pakchunk90-WindowsNoEditor_14_P.pak",
            "OakGame/Content/Paks/pakchunk91-WindowsNoEditor_14_P.pak",
          } }
        },

        FilesToReplace = new Dictionary<Depot, HashSet<string>>() {
          { Depot.Exe, new HashSet<string>() {
            "OakGame/Binaries/Win64/Borderlands3.exe",
          } },
          { Depot.Content, new HashSet<string>() {
            "Engine/Binaries/ThirdParty/bifrost/x64/Release/bifrost.dll",
            "Engine/Binaries/ThirdParty/cohtml/win64/cohtml.WindowsDesktop.dll",
            "Engine/Binaries/ThirdParty/cohtml/win64/HttpServer.WindowsDesktop.dll",
            "Engine/Binaries/ThirdParty/cohtml/win64/MediaDecoders.WindowsDesktop.dll",
            "Engine/Binaries/ThirdParty/renoir/win64/RenoirCore.WindowsDesktop.dll",
            "Engine/Binaries/ThirdParty/vivox/win64/vivoxsdk.dll",
          } }
        },

        FilesToDelete = new Dictionary<Depot, HashSet<string>>() {
          { Depot.Content, new HashSet<string>() {
            "OakGame/Content/Movies/GBXLOGO.webm",
            "OakGame/Content/Movies/2KLOGO.webm",
          } }
        },
      },

      new VersionInfo() {
        Name = "Vault Card 2",
        ProductVersion = "OAK-PATCHWIN641-270",

        Manifests = new Dictionary<Depot, ulong>() {
          { Depot.Exe, 1661979099975390852 },
          { Depot.Content, 644739243505618385 },
          { Depot.Dandelion, 9116600370569954686 },
          { Depot.Hibiscus, 132348831915272916 },
          { Depot.Geranium, 350750707932598048 },
          { Depot.Alisma, 5627198090468988485 },
          { Depot.Ixora, 988244885201248028 },
          { Depot.Ixora2, 8226097640942912719 },
        },

        FilesToAdd = new Dictionary<Depot, HashSet<string>>() {
          { Depot.Content, new HashSet<string>() {
            "OakGame/Content/Paks/pakchunk0-WindowsNoEditor_16_P.pak",
            "OakGame/Content/Paks/pakchunk1-WindowsNoEditor_16_P.pak",
            "OakGame/Content/Paks/pakchunk3-WindowsNoEditor_15_P.pak",
            "OakGame/Content/Paks/pakchunk4-WindowsNoEditor_16_P.pak",
            "OakGame/Content/Paks/pakchunk5-WindowsNoEditor_16_P.pak",
            "OakGame/Content/Paks/pakchunk6-WindowsNoEditor_14_P.pak",
            "OakGame/Content/Paks/pakchunk7-WindowsNoEditor_12_P.pak",
            "OakGame/Content/Paks/pakchunk8-WindowsNoEditor_8_P.pak",
            "OakGame/Content/Paks/pakchunk83-WindowsNoEditor_7_P.pak",
            "OakGame/Content/Paks/pakchunk85-WindowsNoEditor_15_P.pak",
            "OakGame/Content/Paks/pakchunk87-WindowsNoEditor_15_P.pak",
            "OakGame/Content/Paks/pakchunk88-WindowsNoEditor_14_P.pak",
            "OakGame/Content/Paks/pakchunk89-WindowsNoEditor_15_P.pak",
            "OakGame/Content/Paks/pakchunk90-WindowsNoEditor_15_P.pak",
            "OakGame/Content/Paks/pakchunk91-WindowsNoEditor_15_P.pak",
          } }
        },

        FilesToReplace = new Dictionary<Depot, HashSet<string>>() {
          { Depot.Exe, new HashSet<string>() {
            "OakGame/Binaries/Win64/Borderlands3.exe",
          } },
          { Depot.Content, new HashSet<string>() {
            "Engine/Binaries/ThirdParty/bifrost/x64/Release/bifrost.dll",
          } }
        },
      },

      new VersionInfo() {
        Name = "Wonderlands Release",
        ProductVersion = "OAK-PATCHWIN64-177",

        Manifests = new Dictionary<Depot, ulong>() {
          { Depot.Exe, 4847692286580868665 },
          { Depot.Content, 718733740046878310 },
          { Depot.Dandelion, 9116600370569954686 },
          { Depot.Hibiscus, 132348831915272916 },
          { Depot.Geranium, 350750707932598048 },
          { Depot.Alisma, 5627198090468988485 },
          { Depot.Ixora, 988244885201248028 },
          { Depot.Ixora2, 8226097640942912719 },
        },

        FilesToAdd = new Dictionary<Depot, HashSet<string>>() {
          { Depot.Content, new HashSet<string>() {
            "OakGame/Content/Paks/pakchunk0-WindowsNoEditor_17_P.pak",
            "OakGame/Content/Paks/pakchunk1-WindowsNoEditor_17_P.pak",
            "OakGame/Content/Paks/pakchunk3-WindowsNoEditor_16_P.pak",
            "OakGame/Content/Paks/pakchunk4-WindowsNoEditor_17_P.pak",
            "OakGame/Content/Paks/pakchunk5-WindowsNoEditor_17_P.pak",
            "OakGame/Content/Paks/pakchunk85-WindowsNoEditor_16_P.pak",
            "OakGame/Content/Paks/pakchunk87-WindowsNoEditor_16_P.pak",
            "OakGame/Content/Paks/pakchunk88-WindowsNoEditor_15_P.pak",
            "OakGame/Content/Paks/pakchunk89-WindowsNoEditor_16_P.pak",
            "OakGame/Content/Paks/pakchunk90-WindowsNoEditor_16_P.pak",
            "OakGame/Content/Paks/pakchunk91-WindowsNoEditor_16_P.pak",
          } }
        },

        FilesToReplace = new Dictionary<Depot, HashSet<string>>() {
          { Depot.Exe, new HashSet<string>() {
            "OakGame/Binaries/Win64/Borderlands3.exe",
          } },
        },
      },
    };
  }
}
