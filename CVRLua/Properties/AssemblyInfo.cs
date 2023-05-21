﻿using System.Reflection;

[assembly: AssemblyTitle("CVRLua")]
[assembly: AssemblyVersion("1.0.0")]
[assembly: AssemblyFileVersion("1.0.0")]

[assembly: MelonLoader.MelonInfo(typeof(CVRLua.Core), "CVRLua", "1.0.0", "SDraw", "https://github.com/SDraw/CVRLua")]
[assembly: MelonLoader.MelonGame(null, "ChilloutVR")]
[assembly: MelonLoader.MelonPlatform(MelonLoader.MelonPlatformAttribute.CompatiblePlatforms.WINDOWS_X64)]
[assembly: MelonLoader.MelonPlatformDomain(MelonLoader.MelonPlatformDomainAttribute.CompatibleDomains.MONO)]