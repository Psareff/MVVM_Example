using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MVVM_Example
{
    internal class MainWindowModel : PropertyChangedNotifier
    {
        private string _Title;
        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }
    }

}
