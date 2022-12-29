using CommonFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    public class Modules
    {
        public static readonly Dictionary<EModule, IModuleMainfest> Mainfests = new Dictionary<EModule, IModuleMainfest>()
        {
            {EModule.Mod_Login, new ModLogin.Mainfest()}
        };
    }
}
