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

namespace WpfApp1
{
    /// <summary>
    /// Interakční logika pro DialogEdit.xaml
    /// </summary>
    public partial class DialogEdit : Window
    {
        public Zamestnanec Z {get; set;}
        public DialogEdit(Zamestnanec z)
        {
            Z = z;
            InitializeComponent();
            DataContext = Z;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Z.Jmeno = ProJmeno.Text;
            Z.Primeni = ProPrimeni.Text;
            Z.DatumNarozeni = DateTime.Parse(ProDatum.Text);
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
