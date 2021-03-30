using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainBar.ViewModel
{
    class MainBarSettingsViewModel
    {
        private IModuleController host;
        private MainBar mainBar;

        public MainBarSettingsViewModel(IModuleController host, MainBar mainBar)
        {
            this.host = host;
            this.mainBar = mainBar;
        }
    }
}
