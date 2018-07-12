using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using AttchedPropertyGetViews.ViewModels;

namespace AttchedPropertyGetViews
{
    public class AttchedPropertys
    {
        public static bool GetGetView(DependencyObject obj)
        {
            return (bool)obj.GetValue(GetViewProperty);
        }

        public static void SetGetView(DependencyObject obj, bool value)
        {
            obj.SetValue(GetViewProperty, value);
        }

        // Using a DependencyProperty as the backing store for IsAutoBindEvent.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty GetViewProperty =
            DependencyProperty.RegisterAttached("GetView", typeof(bool), typeof(AttchedPropertys), new PropertyMetadata(false, OnPropertyChanged));

        private static void OnPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Window view)
            {
                view.DataContextChanged += (s, en) =>
                {
                    var vm = (IViewModel)view.DataContext;
                    vm.View = view;
                };
            }
        }
    }
}
