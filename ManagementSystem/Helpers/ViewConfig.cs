using FontAwesome5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp.Helpers
{
    public class ViewConfig
    {
        public string ModName { get; }
        public string PrettyName { get; }
        public EFontAwesomeIcon ModIcon { get; }

        public ViewConfig(string modName, string prettyName, EFontAwesomeIcon icon)
        {
            ModName = modName;
            PrettyName = prettyName;
            ModIcon = icon;
        }
    }
}
