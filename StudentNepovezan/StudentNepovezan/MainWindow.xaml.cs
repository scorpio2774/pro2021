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

namespace StudentNepovezan
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Ocene(object sender, RoutedEventArgs e)
        {
            Ocene o = new Ocene();
            o.Show();
        }

        private void Studenti(object sender, RoutedEventArgs e)
        {
            Studenti s = new Studenti();
            s.Show();
        }

        private void Predmeti(object sender, RoutedEventArgs e)
        {
            Predmeti p = new Predmeti();
            p.Show();
        }
    }
}
