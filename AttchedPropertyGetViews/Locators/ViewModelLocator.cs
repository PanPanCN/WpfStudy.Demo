using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AttchedPropertyGetViews.ViewModels;

namespace AttchedPropertyGetViews.Locators
{
    public class ViewModelLocator
    {
        public MainWindowViewModel MainWindowViewModel => new MainWindowViewModel();
    }
}
