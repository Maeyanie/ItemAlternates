# ItemAlternates
### Skyrim Synthesis patcher to semi-automatically create alternate versions of items.

Have a bunch of standalone-replacers of items, and want them to spawn as alternate items, like Book of UUNP? 
ItemAlternates was designed to make doing this at least slightly less tedious.

It will search your load order for FormIDs, EditorIDs, and regex-matched EditorIDs, and look for a specified (using patterns for regex matche) existing item.
If one is found, it will clone the basic stats (armour rating, weapon damage, weight, and value) of the item, as well as all levelled-list and container spawns, effectively adding it as an alternate model.

Some presets are provided by default, see the [Nexus page](https://www.nexusmods.com/skyrimspecialedition/mods/132099) for up-to-date information and links.
