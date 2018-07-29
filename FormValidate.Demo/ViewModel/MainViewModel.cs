using FormValidate.Demo.Models;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows;
using System.Windows.Input;

namespace FormValidate.Demo.ViewModel
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
        private UserModel _user;

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}

            _user = new UserModel();
            SubmitCommand = new RelayCommand(() =>
            {
                if (User.IsValidated)
                    MessageBox.Show("验证通过！");
                else
                    MessageBox.Show("验证失败！");
            });
        }

        /// <summary>
        /// 用户信息
        /// </summary>
        public UserModel User
        {
            get => _user;
            set => Set(() => _user, ref _user, value);
        }

        public ICommand SubmitCommand { get; set; }
    }
}