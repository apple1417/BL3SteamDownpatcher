## BL3 Steam Downpatcher

As the name might suggest, a downpatcher for Steam versions of BL3. Downloads files as required rather than pre-packaging them all. Requires you to actually own the game on Steam (obviously)

Requires [Depot Downloader](https://github.com/SteamRE/DepotDownloader/releases) be installed, which in turn also requires the [.NET Core Runtime](https://dotnet.microsoft.com/download/dotnet-core/current/runtime).

### [Usage Guide](https://youtu.be/S9GTbhWeaM0)

&nbsp;

#### Why do I need to give this my Steam login details?
The downpatcher essentially just acts as a wrapper around Depot Downloader, it will call it multiple times will all the specific arguments needed to download the relevant files. Depot Downloader can remember your password, but not your username, so the downpatcher asks for your username so that it can pass it as an argument every time, so that the process is automatic.

Depot Downloader then asks for the rest of your login details so that it can login to Steam, and start making API calls in order to download files. The BL3 files aren't public, you need to be logged in on an account that owns the game to be able to download them.

This program, Depot Downloader, and SteamKit2 (which Depot Downloader relies on) are all open source, if you're worried you can always look through them and see exactly what they're doing with your login details.
