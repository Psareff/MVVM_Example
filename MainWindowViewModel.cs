using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace MVVM_Example
{
    internal class MainWindowViewModel : PropertyChangedNotifier
    {
        MainWindowModel mainWindowModel;

        public MainWindowViewModel()
        {
            mainWindowModel = new MainWindowModel();
        }

        public string Title
        {
            get => mainWindowModel.Title;
            set
            {
                mainWindowModel.Title = value;
                OnPropertyChanged();
            }
        }
    }
}
