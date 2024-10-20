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
    /// Interaction logic for RightPage.xaml
    /// </summary>
    public partial class RightPage : UserControl
    {
        public RightPage()
        {
            InitializeComponent();

            //The below code is PUB-Sub type

            this.DataContext = Singleton.GetRightVMInstance();

            //below code is implimentation of Singleton type 
            //Singleton vari = Singleton.GetInstance();
            //this.DataContext = vari.GetLeftVMInstance(); 
        }
    }
}
