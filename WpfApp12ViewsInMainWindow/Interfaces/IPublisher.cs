using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp12ViewsInMainWindow.Interfaces
{
    public interface IPublisher
    {
         void Notify();

         void Attach(ISubscriber subscriber);
    }
}
