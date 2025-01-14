## Meteoric Expansion (Config lib compatibility)

The skies burn with balls of fire barrelling towards the planet at cosmic speeds....Is this the apocalypse?

![Screenshot](resources/images/Meteor.png)


### Description

Hello, welcome to the mod repository for the Vintage Story mod, Meteoric Expansion!

This mod aims to bring the cosmos to Vintage Story in a very literal sense. In vanilla Vintage Story it's possible to stumble across small surface deposits of meteoric iron...but where did it come from? Meteors don't exist in vanilla!
Meteoric Expansion fills this space. This mod will spawn occasional randomized meteors that will streak through the skies, burning up or exploding like a real meteor would. There's also a small chance that they'll crash to the ground, depositing their riches into the world...!


### IMPORTANT

Meteoric Expansion ships with configurable options! 

By default meteors are NOT destructive and will NOT damage the world or player structures. With the destructive option set to false Meteoric Expansion is purely cosmetic. 
Your world and structures may be safe...but you also won't be able to gather the goodies that a meteorite would deposit. Risk vs reward...  

To change your config, load up a game with the mod installed and enabled. After the mod runs once, a MeteoricExpansionConfig.json file will be available for edit in...
'C:\Users\{Your Username}\AppData\Roaming\VintagestoryData\ModConfig'

Exit to menu, edit this file, then load your save to see the changes!

Further config details can be found by opening the mod ZIP and reading the readme in 'assets\meteoricexpansion\config\'.


### Releases

### Vintage Story 1.19.0+
[Version 1.2.5](https://github.com/TaskaRaine/Meteoric-Expansion/releases/download/1.2.5/MeteoricExpansion_v1.2.5.zip)

### Vintage Story 1.18.0+
[Version 1.2.4](https://github.com/TaskaRaine/Meteoric-Expansion/releases/download/1.2.4/MeteoricExpansion_v1.2.4.zip)

[Version 1.2.3](https://github.com/TaskaRaine/Meteoric-Expansion/releases/download/1.2.3/MeteoricExpansion_v1.2.3.zip)

### Vintage Story 1.17.0+
[Version 1.2.2](https://github.com/TaskaRaine/Meteoric-Expansion/releases/download/1.2.2/MeteoricExpansion_v1.2.2.zip)

[Version 1.2.1](https://github.com/TaskaRaine/Meteoric-Expansion/releases/download/1.2.1/MeteoricExpansion_v1.2.1.zip)

### Vintage Story 1.16.0+
[Version 1.2.0](https://github.com/TaskaRaine/Meteoric-Expansion/releases/download/1.2.0/MeteoricExpansion_v1.2.0.zip)

[Version 1.1.1](https://github.com/TaskaRaine/Meteoric-Expansion/releases/download/1.1.1/MeteoricExpansion_v1.1.1.zip)

[Version 1.1.0](https://github.com/TaskaRaine/Meteoric-Expansion/releases/download/1.1.0/MeteoricExpansion_v1.1.0.zip)

[Version 1.0.6](https://github.com/TaskaRaine/Meteoric-Expansion/releases/download/1.0.6/MeteoricExpansion_v1.0.6.zip)

### Vintage Story 1.15.0+
[Version 1.0.5](https://github.com/TaskaRaine/Meteoric-Expansion/releases/download/1.0.5/MeteoricExpansion_v1.0.5.zip)

### Vintage Story 1.14.0+
[Version 1.0.4](https://github.com/TaskaRaine/Meteoric-Expansion/releases/download/1.0.4/MeteoricExpansion_v1.0.4.zip)

[Version 1.0.3](https://github.com/TaskaRaine/Meteoric-Expansion/releases/download/1.0.3/MeteoricExpansion_v1.0.3.zip)

[Version 1.0.2](https://github.com/TaskaRaine/Meteoric-Expansion/releases/download/1.0.2/MeteoricExpansion_v1.0.2.zip)

[Version 1.0.1](https://github.com/TaskaRaine/Meteoric-Expansion/releases/download/1.0.1/MeteoricExpansion_v1.0.1.zip)

[Version 1.0.0](https://github.com/TaskaRaine/Meteoric-Expansion/releases/download/1.0.0/MeteoricExpansion_v1.0.0.zip)


### Changelog

##### Version 1.2.5
Updated Meteoric Expansion for Vintage Story 1.19.0+ compatibility.

Added some new configuration options! You can now tweak meteor sizes again. This time, hopefully, with less crashing of clients. 

FallingMeteorSize does exactly as it implies. This will set the minimum size of your meteors. Craters and meteorites will also scale up in size when this value is changed.

FallingMeteorVariance provides randomness to meteor sizes. Randomly increases FallingMeteorSize up to the value provided(ish).

CraterSizeMultiplier will make the meteor craters and meteorites larger or smaller without affecting the visual size of the falling meteor.

Added a renderer to falling meteors which allows the meteor shape to be visible at much longer ranges(up to 512 blocks)

Although it looks silly, meteors will no longer destroy fruit trees. For some reason they were causing serious crashing unrelated to Meteoric Expansion when destroyed.

##### Version 1.2.4
Rebuilt the mod using more recent Vintage Story dlls to avoid error spam due to the mod not being able to fetch the vanilla LandClaim type.

##### Version 1.2.3
Updated Meteoric Expansion for Vintage Story 1.18.0+ compatibility.

When meteors strike ground, they will now turn vanilla rock into vanilla cracked rock at the crash site.

Cuboid explosion particles now spawn on server instead of client and have had their lifespan reduced.

Modified claim protection code slightly to eliminate some redundancy.

Added a Russian translation provided by LordOri.

##### Version 1.2.2
Potentially fixed a crash with falling meteors when despawning.

##### Version 1.2.1
Meteoric Expansion compatibility for Vintage Story 1.17.0+

Added a Brazilian Portuguese translation provided by xCoiotex.

Meteoric rock now uses the cracked rock textures included in the vanilla game. Meteoric Expansion cracked textures have been removed.

Meteoric rock/meteoric metallic rock has been renamed to help differentiate Meteoric cracked rock from regular cracked rock.

Increased the drop rate of crystallized ore in meteoric metallic rock to match vanilla rates.

Explosion cube particles now only spawn on the client side. 

Made various mod particle systems asynchronous to improve game performance.

The patch to cook vanilla stone into cracked meteoric rock has been removed. Cooled meteoric rock can still be 'cooked', however.

A redundant shape file has been removed.

##### Version 1.2.0
Added a whole new spawning system for meteor showers. 

Shower meteors will all follow the same trajectory and speed of all others within the shower. Additionally, they will all share the same material composition, indicated by the colour of its trail.

Added config variables to control many aspects of the meteor shower implementation.

Added config variables that can be used to toggle both falling meteors and meteor showers on or off.

Meteors of all kinds can have their trajectories altered via config, this time with less client crashing(hopefully).

Fixed an issue where meteors would only spawn in one quadrant of the sky above a player.

##### Version 1.1.1
Removed config variables for meteor speed and scale. They were causing crashes on servers.

##### Version 1.1.0
Meteors are now made of their own unique blocks. 'Cracked Rock'.

'Cracked Rock' has multiple variants. Smouldering, and cooled. Smouldering stone produces smoke plumes and damages creatures that step on it. Smouldering stone will cool over time.

Traces of ash can be found in craters. Ash can be used as a fertilizer as it's high in phosphorus and nitrogen.

Compatibility for More Metals and Fahl Ores has been implemented.

Only useful meteors are now implemented into the vanilla version. No more overwhelming amounts of uranium.

Gold and silver now can appear in meteors.

Rock can be heated in a fire pit and 'cooked' into a cracked smouldering version.

A new config setting has been added. If 'ClaimsProtected' is set to true, this will ensure that, if the Destructive config option is true...claims will not be harmed by falling meteors. 

Four new 'Meteor Speed' config settings have been added to give you greater control over meteor angles of approach. 
Want an apocalyptic feel? Lower horizontal speed and boost vertical speed.
Want a cinematic feel? Lower vertical speed.

Meteor scale configs have been added. Be careful with this one. It can get excessively destructive as scale exponentially increases landed meteor size and crater size.

##### Version 1.0.6
Compatability patch for Vintage Story 1.16

##### Version 1.0.5
Compatability patch for Vintage Story 1.15

##### Version 1.0.4
Fixed a crash related to particles.

Made all meteor sounds be activated server-side to be heard at great distances.

Sounds are now directional and volume changes based on distance. 

New meteor streaking sound, dynamically mixed and played server-side.

Added more depth to the explosion sounds.

##### Version 1.0.3
Fixed a client crash resulting from clients trying to access config data on meteor spawn.

Increased the volume of meteor sizzles and meteor explosions.

##### Version 1.0.2
Added config options to allow configuration of meteor spawn distances from the player.

Removed unused code that caused a warning in the client error log.

##### Version 1.0.1
Removed Rhodocrosite and Pentlandite as possible meteor minerals. There's no current use for them in vanilla Vintage Story.

Gave meteors names that better describe their composition.

Fixed an issue where meteor names would appear as code strings in the handbook(thank you, lisabet, for pointing this out to me).

##### Version 1.0.0
Initial Release
