using CommonFunctions;
using FontAwesome5;
using System;
using System.Windows.Media.Media3D;

namespace ModLogin
{
    public class Mainfest: IModuleMainfest
    {
        public string ModName => nameof(Views.UserLogin);
        public string PrettyName => "Login";
        public EFontAwesomeIcon Icon => EFontAwesomeIcon.Solid_Camera;
        public Type ModuleEntryPoint => typeof(ModUserLogin);
    }
}
