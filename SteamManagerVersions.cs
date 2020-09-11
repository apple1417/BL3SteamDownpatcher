using System.Collections.Generic;
using System.Security.Policy;

namespace BL3SteamDownpatcher {
  static partial class SteamManager {
    // There's an explanation of these categories work in SwitchVersion

    private static Dictionary<Depot, HashSet<string>> FilesToAlwaysReplace = new Dictionary<Depot, HashSet<string>>() {
      { Depot.Exe, new HashSet<string>() {
        "OakGame/Binaries/Win64/Borderlands3.exe",
      } },
      { Depot.Content, new HashSet<string>() {
        "Engine/Binaries/ThirdParty/bifrost/x64/Release/bifrost.dll",
      } }
    };

    private static List<VersionInfo> AllVersionInfo = new List<VersionInfo>() {
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
          { Depot.Content, new HashSet<string>() {
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
          { Depot.Content, new HashSet<string>() {
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
        }
      }
    };
  }
}
