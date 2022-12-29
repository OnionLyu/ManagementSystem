using FontAwesome5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonFunctions
{
    public interface IWorkbenchManifest
    {
        public string WbName { get; }
        /// <summary>
        /// The display name of the workbench. This is to be used for display purposes.
        /// </summary>
        public string PrettyName { get; }
        /// <summary>
        /// The icon of the workbench. This is to be used for display purposes.
        /// </summary>
        public EFontAwesomeIcon Icon { get; }
        /// <summary>
        /// The main entrypoint of the workbench. This should be set to the typeof(T) where T is some class that implements
        /// UserControl (aka the something.xaml.cs class)
        /// </summary>
        public Type WorkbenchEntryPoint { get; }
    }
}
