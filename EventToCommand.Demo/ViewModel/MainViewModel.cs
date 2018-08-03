using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace EventToCommand.Demo.ViewModel
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
        private string _filePath;
        private string _textChangedValue;

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

            DropCommand = new RelayCommand<DragEventArgs>(e =>
             {
                 FilePath = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
             });

            TextChangedCommand = new RelayCommand<TextChangedEventArgs>(e =>
            {
                MessageBox.Show(nameof(TextChangedCommand));
            });
        }

        public string FilePath
        {
            get => _filePath;
            set => Set(() => FilePath, ref _filePath, value);
        }

        public string TextChangedValue
        {
            get => _textChangedValue;
            set => Set(() => TextChangedValue, ref _textChangedValue, value);
        }

        public ICommand DropCommand { get; set; }

        public ICommand TextChangedCommand { get; set; }

    }
}