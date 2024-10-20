using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp12ViewsInMainWindow.ViewModels
{
    public sealed class Singleton
    {
        //private Singleton() { }
        //private static Singleton _instance;
        //public static Singleton GetInstance()
        //{
        //    if (_instance == null)
        //    {
        //        _instance = new Singleton();
        //    }
        //    return _instance;
        //}
        //public MainVM GetMainVMInstance() {
        //    if (_MainVMinstance == null)
        //    {
        //        _MainVMinstance = new MainVM();
        //    }
        //    return _MainVMinstance;

        //}

        private static LeftPageVM leftPageVMInstance = null;
        public static LeftPageVM GetLeftVMInstance()
        {
            if (leftPageVMInstance == null)
            {
                leftPageVMInstance = new LeftPageVM();
            }
            return leftPageVMInstance;

        }

        private static RightPageVM rightPageVMInstance = null;
        public static RightPageVM GetRightVMInstance()
        {
            if (rightPageVMInstance == null)
            {
                rightPageVMInstance = new RightPageVM();
            }
            return rightPageVMInstance;

        }

    }
}
