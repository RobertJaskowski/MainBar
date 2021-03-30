using MainBar.View;
using MainBar.ViewModel;
using System.Windows.Controls;
using System.Windows.Media;

namespace MainBar
{
    public class MainBar : ICoreModule
    {


        public string ModuleName
        {
            get
            {
                return "ActiveTimer";
            }
        }

        private UserControl _view;
        public UserControl View
        {
            get
            {
                if (_view == null)
                {
                    _view = new MainBarView();
                    _view.DataContext = new MainBarViewModel(_host, this);
                }

                return _view;
            }
            set { _view = value; }
        }



        private UserControl _settingsView;
        public UserControl SettingsView
        {
            get
            {
                if (_settingsView == null)
                {
                    _settingsView = new MainBarSettingsView();
                    _settingsView.DataContext = new MainBarSettingsViewModel(_host, this);
                }

                return _settingsView;
            }
            set { _settingsView = value; }
        }


        private IModuleController _host;
        public void Init(IModuleController host)
        {
            _host = host;
        }

        public void Start()
        {

        }

        public void ReceiveMessage(string message)
        {


            string[] splits = message.Split("|||");
            for (int i = 0; i < splits.Length; i++)
            {
                string item = splits[i];
                splits[i] = item.Trim();
            }

            switch (splits[0].ToLower())
            {
                case "value":
                    if (int.TryParse(splits[1], out int result))
                        ((MainBarViewModel)View.DataContext).UpdateTopBar(result);
                    break;
                case "color":
                    if (int.TryParse(splits[1], out int r))
                        if (int.TryParse(splits[2], out int g))
                            if (int.TryParse(splits[3], out int b))
                                ((MainBarViewModel)View.DataContext).SetBarColor(Color.FromRgb((byte)r, (byte)g, (byte)b));

                    break;


            }
        }

        public void Stop()
        {

        }

        public void OnMinViewEntered()
        {

        }

        public void OnFullViewEntered()
        {

        }

        public ModulePosition GetModulePosition()
        {
            return ModulePosition.TOP;
        }

        public string GetModuleName()
        {
            return ModuleName;
        }

        public void OnInteractableEntered()
        {
        }

        public void OnInteractableExited()
        {
        }

        public UserControl GetModuleUserControlView()
        {
            return View;
        }

        public UserControl GetSettingsUserControlView()
        {
            return SettingsView;
        }
    }
}
