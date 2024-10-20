using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp12ViewsInMainWindow.ViewModels;

namespace WpfApp12ViewsInMainWindow.Views
{
    /// <summary>
    /// Interaction logic for LeftPage.xaml
    /// </summary>
    public partial class LeftPage : UserControl
    {
        public LeftPage()
        {
            InitializeComponent();
            //The below code is PUB-Sub type
            this.DataContext = Singleton.GetLeftVMInstance();

            //below code is implimentation of Singleton type 
            //Singleton inst = Singleton.GetInstance();
            //this.DataContext = inst.GetLeftVMInstance(); 
        }
    }
}
