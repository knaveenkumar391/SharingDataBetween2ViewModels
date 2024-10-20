using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp12ViewsInMainWindow.Commands;
using WpfApp12ViewsInMainWindow.Interfaces;

namespace WpfApp12ViewsInMainWindow.ViewModels
{
    public class LeftPageVM : INotifyPropertyChanged, IPublisher
    {
        private int myVar;

        public int Counter
        {
            get { return myVar; }
            set
            {
                myVar = value;
                OnPropertyRaised("Counter");
                Notify();
            }
        }


        public ICommand LeftPageBtnClick { get; set; }
        public LeftPageVM()
        {
            Subscribers = new List<ISubscriber>();
            LeftPageBtnClick = new RelayGenCommand(CounterMethod, CanExecuteMethod);
            Counter = 0;
        }

        public void CounterMethod(object value)
        {
            Counter = Counter + 1;
        }
        public bool CanExecuteMethod(object value)
        {
            return true;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyRaised(string propertyname)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }

        public List<ISubscriber> Subscribers { get; set; }
        public void Notify()
        {
            if (Subscribers != null && Subscribers.Count > 0)
            {
                foreach (var item in Subscribers)
                {
                    item.Listener(this);
                }
            }
        }

        public void Attach(ISubscriber subscriber)
        {
            Subscribers.Add(subscriber);
        }
    }
}
