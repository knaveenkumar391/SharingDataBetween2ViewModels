using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp12ViewsInMainWindow.Commands;
using WpfApp12ViewsInMainWindow.Interfaces;

namespace WpfApp12ViewsInMainWindow.ViewModels
{
    public class RightPageVM:INotifyPropertyChanged,ISubscriber
    {
		private int myVar;

		public int CounterDisplay
		{
			get { return myVar; }
			set { myVar = value;
                OnPropertyRaised("CounterDisplay");
            }
		}
        public event PropertyChangedEventHandler PropertyChanged;

        public void Listener(IPublisher publisher)
        {
            if(publisher is LeftPageVM)
            {
                LeftPageVM lftvm =publisher as LeftPageVM;
                CounterDisplay = lftvm.Counter;
            }

        }

        private void OnPropertyRaised(string propertyname)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}
