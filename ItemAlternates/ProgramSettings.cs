using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.WPF.Reflection.Attributes;

namespace ItemAlternates
{
    public class ProgramSettings
    {	
		[SettingName("Manual Replacements")]
		[Tooltip("Static replacements given as \"Modded Item > Copied Item\" using either FormID or EditorID.\n"
			+"For example, the entry \"G3BFarmClothes1 > FarmClothes1\" will copy the stats and LLs of FarmClothes1 to G3BFarmClothes1.")]
		public List<string> Replacements { get; set; } = [];

        [SettingName("Automatic Replacement Patterns")]
        [Tooltip("\"Search pattern > replacement pattern\" using .NET regular expression syntax.\n"
            +"For example, the entry \"$G3B(.+) > $1\" will match \"G3BFarmClothes1\" to \"FarmClothes1\"\n"
            +"Patterns are processed in order, and only the first successful match is used.\n"
			+"They are not checked if an item matches a manual replacement.")]
        public List<string> Patterns { get; set; } = [];

        [SettingName("Enable Debug Messages")]
        public bool Debug { get; set; } = false;
    }
}