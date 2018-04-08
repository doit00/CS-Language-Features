using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CSLangFeatures.CS5
{
    class Product : INotifyPropertyChanged
    {
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                 name = value;
                InvokePropertyChanged(this);
            }
        }
        private int category;
        public int Category
        {
            get { return category; }
            set { category = value;
                   InvokePropertyChanged(this);
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void InvokePropertyChanged(object sender, [CallerMemberName] string memberName = null)
        {
            PropertyChanged?.Invoke(sender, new PropertyChangedEventArgs(memberName));
            Console.WriteLine("Property changed {0}", memberName);
        }



    }

}