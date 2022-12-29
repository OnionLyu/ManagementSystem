using FontAwesome5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonFunctions
{
    public interface IModuleMainfest
    {
        public string ModName { get; }
        /// <summary>
        /// The pretty name, to be used to display to the users.
        /// </summary>
        public string PrettyName { get; }
        /// <summary>
        /// The Icon of the module.
        /// </summary>
        public EFontAwesomeIcon Icon { get; }

        /// <summary>
        /// The main entrypoint of the module. This should be set to the typeof(T) where T is some class that implements
        /// IModule (aka the main class of the module)
        /// </summary>
        public Type ModuleEntryPoint { get; }
    }
}
