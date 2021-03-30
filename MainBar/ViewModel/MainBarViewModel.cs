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

        //float topPercentFilled = 0;
        //public int timeSecToFillTopBar = 0;//todo

        public void UpdateTopBar(int value)
        {
            ProgressTopBar = value;
        }

        //public void UpdateTopBar(double totalSeconds)
        //{
        //    if (timeSecToFillTopBar == 0)
        //        return;


        //    float rest = (float)(totalSeconds % (timeSecToFillTopBar));
        //    topPercentFilled = Utils.ToProcentage(rest, 0, timeSecToFillTopBar);

        //    ProgressTopBar = topPercentFilled;

        //    //progressBarTopMost.SetValueWithAnimation(topPercentFilled, true);



        //}


        public void SetBarColor(Color color)
        {
            TopBarStateColor = color;
        }


    }
}
