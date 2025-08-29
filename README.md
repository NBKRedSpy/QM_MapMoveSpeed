# Quasimorph MapMoveSpeed

![thumbnail icon](media/thumbnail.png)

Holding down the shift key while in a raid will speed up the scrolling of the map.

Key and speed can be defined in the config file.

# Configuration
This mod supports the Mod Configuration Manager mod.  Some settings can be set in the UI, while all can be set in the config file directly.

The configuration file will be created on the first game run and can be found at `%AppData%\..\LocalLow\Magnum Scriptum Ltd\Quasimorph_ModConfigs\MapMoveSpeed\config.json`.

|Name|Default|Description|
|--|--|--|
|BorderMoveSpeed|8|The speed of the map movement.  The game defaults to 4.  Higher is faster.|
|SpeedKey|LeftShift|The key used to enable the speed change|

## Key List
The list of valid keyboard keys can be found  at the bottom of https://docs.unity3d.com/ScriptReference/KeyCode.html
Beware that numbers 0-9 are Alpha0 - Alpha9.  Most of the other keys are as expected such as X for X.
Use "None" to not bind the key.

# Support
If you enjoy my mods and want to buy me a coffee, check out my [Ko-Fi](https://ko-fi.com/nbkredspy71915) page.
Thanks!

# Credits
* Special thanks to Crynano for his excellent Mod Configuration Menu. 

# Source Code
Source code is available on GitHub at https://github.com/NBKRedSpy/QM_MapMoveSpeed

# Change Log
## 1.1.1
* Fix for MCM not being bypassed due to Mono specific bug.

## 1.1.0
* MCM Integration
