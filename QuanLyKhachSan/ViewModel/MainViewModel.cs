using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System.Windows.Input;

namespace QuanLyKhachSan.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// The current view
        /// </summary>
        private ViewModelBase _currentViewModel;

        public ViewModelBase CurrentViewModel
        {
            get
            {
                return _currentViewModel;
            }
            set
            {
                if (_currentViewModel == value)
                    return;
                _currentViewModel = value;
                RaisePropertyChanged("CurrentViewModel");
            }
        }

        readonly static DanhMucPhongViewModel _danhMucPhong = new DanhMucPhongViewModel();
        readonly static TraCuuPhongViewModel _traCuuPhong = new TraCuuPhongViewModel();


        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            CurrentViewModel = MainViewModel._traCuuPhong;

            TraCuuPhongCommand = new RelayCommand(() => { CurrentViewModel = MainViewModel._traCuuPhong; }, () => true);

            DanhMucPhongCommand = new RelayCommand(() => { CurrentViewModel = MainViewModel._danhMucPhong; }, () => true);

        }

        public ICommand TraCuuPhongCommand { get; set; }
        public ICommand DanhMucPhongCommand { get; set; }
    }
}