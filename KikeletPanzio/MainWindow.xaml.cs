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

namespace KikeletPanzio
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static List<Szoba> szobaList = new List<Szoba>();

        public MainWindow()
        {
            InitializeComponent();
            szobaList.Add(new Szoba(1,2,6000));
            szobaList.Add(new Szoba(2,1,9000));
            szobaList.Add(new Szoba(3,4,10000));
            szobaList.Add(new Szoba(4,4,12000));
            szobaList.Add(new Szoba(5,2,8000));
            szobaList.Add(new Szoba(6,3,7000));

        }

        private void BtnRegisztracio_Click(object sender, RoutedEventArgs e)
        {
            RegisztracioWindow regisztracioWindow = new RegisztracioWindow();
            regisztracioWindow.ShowDialog();
        }

        private void BtnFoglalas_Click(object sender, RoutedEventArgs e)
        {
            FoglalasWindow foglalasWindow = new FoglalasWindow();
            foglalasWindow.ShowDialog();
        }

        private void BtnStatisztika_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
