using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace KikeletPanzio
{
    /// <summary>
    /// Interaction logic for FoglalasWindow.xaml
    /// </summary>
    public partial class FoglalasWindow : Window
    {
        public FoglalasWindow()
        {
            InitializeComponent();
            foreach (var item in RegisztracioWindow.ugyfelList)
            {
                CbxUgyfelValaszt.Items.Add(item.Nev);
            }
        }

        private void TbxFoSzam_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void EjszakakSzama()
        {
            DateTime erkez = DPErkezes.SelectedDate.Value;
            DateTime tavoz = DPTavozas.SelectedDate.Value;

            if (DPErkezes.SelectedDate != null && DPTavozas.SelectedDate != null)
            {
                int ejszakak = (int)(tavoz - erkez).TotalDays;
                TbxEjszakak.Text = Convert.ToString(ejszakak);
            }
            else
            {
                TbxEjszakak.Text = "0";
            }
            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
