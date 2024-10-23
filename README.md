# ItemAlternates
### Skyrim Synergy patcher to semi-automatically create alternate versions of items.

Have a bunch of standalone-replacers of items, and want them to spawn as alternate items, like Book of UUNP? 
ItemAlternates was designed to make doing this at least slightly less tedious.

It will search your load order for FormIDs, EditorIDs, and regex-matched EditorIDs, and look for a specified (using patterns for regex matche) existing item.
If one is found, it will clone the basic stats (armour rating, weapon damage, weight, and value) of the item, as well as all levelled-list and container spawns, effectively adding it as an alternate model.

Matches are stored in your Settings.json file. By default this isn't included in the Git repository so it won't cause problems with customizations; however, you can download a pre-loaded one from the Nexus page.
