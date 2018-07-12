using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace AttchedPropertyGetViews.ViewModels
{
    public interface IViewModel
    {
        Window View { get; set; }
    }
}
