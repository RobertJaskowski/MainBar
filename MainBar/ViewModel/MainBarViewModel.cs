using System.Windows.Controls;
using System.Windows.Media;

namespace MainBar.ViewModel
{
    class MainBarViewModel : ObservableObject
    {
        #region Properties

        private Color _topBarStateColor;
        public Color TopBarStateColor
        {
            get
            {

                return _topBarStateColor;
            }
            set
            {
                _topBarStateColor = value;
                OnPropertyChanged("TopBarStateColor");
            }
        }

        private double _progressTopBar;
        public double ProgressTopBar
        {
            get
            {
                return _progressTopBar;
            }
            set
            {
                _progressTopBar = value;
                OnPropertyChanged(nameof(ProgressTopBar));
            }
        }


        #endregion

        IModuleController _host;

        public MainBarViewModel(IModuleController host, ICoreModule coreMod)
        {
            _host = host;

        }

        
        public void UpdateTopBar(int value)
        {
            ProgressTopBar = value;
        }



        public void SetBarColor(Color color)
        {
            TopBarStateColor = color;
        }


    }
}
