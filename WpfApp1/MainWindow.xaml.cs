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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Zamestnanec> Zamestnanci { get; set; }
        public MainWindow()
        {
            Zamestnanci = new();
            InitializeComponent();
            Seznam.ItemsSource = Zamestnanci;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DialogPridat dialog = new(Zamestnanci);
            dialog.Closing += Dialog_Closing;
            dialog.ShowDialog();
        }

        private void Dialog_Closing(object? sender, EventArgs e)
        {
            Seznam.ItemsSource = null;
            Seznam.ItemsSource = Zamestnanci;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Zamestnanec info = Seznam.SelectedItem as Zamestnanec ?? new Zamestnanec(-1, "Neznámý", "Nenalezen", DateTime.Now);
            MessageBox.Show($"{info.ID}{info.Jmeno}{info.Primeni}{info.DatumNarozeni.ToShortDateString()}");


        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Zamestnanec? Hledany = Seznam?.SelectedItem as Zamestnanec;
            if (Hledany != null) 
            {
                DialogEdit edit = new DialogEdit(Hledany);
                edit.Closing += Dialog_Closing;
                edit.ShowDialog();

            }



           
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Zamestnanec? Hledany = Seznam?.SelectedItem as Zamestnanec;
            var volba = MessageBox.Show($"Odebrat{Hledany.Jmeno}?", "Odebrat", MessageBoxButton.YesNo);
            if(volba == MessageBoxResult.Yes) 
            {
                Zamestnanci.Remove(Hledany);
                Seznam.ItemsSource = null;
                Seznam.ItemsSource = Zamestnanci;
            }
        }
    }
}
