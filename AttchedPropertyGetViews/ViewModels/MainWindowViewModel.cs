using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;
using PanPanMvvm.Toolkit.Wpf.Command;

namespace AttchedPropertyGetViews.ViewModels
{
    public class MainWindowViewModel : IViewModel
    {
        public MainWindowViewModel()
        {
            ClickCommand = new RelayCommand(m =>
            {
                var view = View;
            });
        }

        public Window View { get; set; }

        public ICommand ClickCommand { get; set; }
    }
}
