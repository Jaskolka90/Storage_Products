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
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace EdycjaProduktów
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Produkt> ListaProduktow = null;
        string sciezka = "pack://application:,,,/Zdjecia/";

        public MainWindow()
        {
            InitializeComponent();
            PrzygotujWiazanie();
        }

        private void PrzygotujWiazanie()
        {
            ListaProduktow = new ObservableCollection<Produkt>();
            ListaProduktow.Add(new Produkt("O1-11", "ołówek", 8, "Katowice 1", new Uri(sciezka + "olowek.jpg"), "Ołówek z gumką HB"));
            ListaProduktow.Add(new Produkt("PW-20", "pióro wieczne", 75, "Katowice 2", new Uri(sciezka + "pioro.jpg"), "W zestawie dwa wkłady"));
            ListaProduktow.Add(new Produkt("DZ-10", "długopis żelowy", 1121, "Katowice 1", new Uri(sciezka + "zelowy_dlugopis.jpg"), "Czarny"));
            ListaProduktow.Add(new Produkt("DZ-12", "długopis kulkowy", 280, "Katowice 2", new Uri(sciezka + "kulkowy_dlugopis.jpg"), "Niebieski"));
            gridProdukty.ItemsSource = ListaProduktow;
            ObservableCollection<string> ListaMagazynow = new ObservableCollection<string>() { "Katowice 1", "Katowice 2", "Gliwice 1" };
            nazwaMagazynu.ItemsSource = ListaMagazynow;
            ICollectionView widok = CollectionViewSource.GetDefaultView(gridProdukty.ItemsSource);
            widok.GroupDescriptions.Add(new PropertyGroupDescription("Magazyn"));
        }

        private void btnZdjecie_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.Title = "Wybierz zdjęcie";
            dialog.Filter = "Image files (*.jpg,*.png;*.jpeg)|*.jpg;*.png;*.jpeg|All files (*.*)|*.*";
            dialog.InitialDirectory = dialog.FileName;
            if (dialog.ShowDialog() == true)
            {
                (gridProdukty.SelectedItem as Produkt).Zdjecie = new Uri(dialog.FileName);
                gridProdukty.CommitEdit(DataGridEditingUnit.Cell, true);
                gridProdukty.CommitEdit();
                CollectionViewSource.GetDefaultView(gridProdukty.ItemsSource).Refresh();
            }
        }
    }
}
