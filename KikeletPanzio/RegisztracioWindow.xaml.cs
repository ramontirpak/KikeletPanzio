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
using System.Windows.Shapes;

namespace KikeletPanzio
{
    /// <summary>
    /// Interaction logic for RegisztracioWindow.xaml
    /// </summary>
    public partial class RegisztracioWindow : Window
    {
        public static List<Ugyfel> ugyfelList = new List<Ugyfel>();
        public RegisztracioWindow()
        {
            InitializeComponent();
        }

        private void BtnRegisztracio_Click(object sender, RoutedEventArgs e)
        {
            string nev;
            DateTime szulDatum;
            string email;
            bool vip;
            if (TbxNev.Text == String.Empty || DpSzulDatum.SelectedDate == null || TbxEmail.Text == String.Empty)
            {
                MessageBox.Show("Hibás adatok!");
                vip = false;
            }
            else
            {
                 nev = TbxNev.Text;
                 szulDatum = (DateTime)DpSzulDatum.SelectedDate;
                 email = TbxEmail.Text;
                 vip = true;
                 ugyfelList.Add(new Ugyfel(nev, szulDatum, email, vip));
                 UgyfelLista();

            }
        }

        

        private void DpSzulDatum_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void UgyfelLista()
        {
            LBxUgyfelek.Items.Clear();
            foreach (var item in ugyfelList)
            {
                LBxUgyfelek.Items.Add($"{item.Id} {item.Nev} {item.SzulDatum.ToShortDateString()} {item.Email} {item.Vip}");
            }
        }
    }
}
