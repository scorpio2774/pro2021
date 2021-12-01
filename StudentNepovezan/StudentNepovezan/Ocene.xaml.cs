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

namespace StudentNepovezan
{
    /// <summary>
    /// Interaction logic for Ocene.xaml
    /// </summary>
    public partial class Ocene : Window
    {
        ŠtudentNetDataSet študentNetDataSet;
        ŠtudentNetDataSetTableAdapters.OceneTableAdapter ota;
        CollectionViewSource oceneViewSource;
        public Ocene()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            ŠtudentNetDataSet študentNetDataSet = ((StudentNepovezan.ŠtudentNetDataSet)(this.FindResource("študentNetDataSet")));
            // Load data into the table Ocene. You can modify this code as needed.
            ŠtudentNetDataSetTableAdapters.OceneTableAdapter ota = new StudentNepovezan.ŠtudentNetDataSetTableAdapters.OceneTableAdapter();
            ota.Fill(študentNetDataSet.Ocene);
            oceneViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("oceneViewSource")));
            oceneViewSource.View.MoveCurrentToFirst();
        }
    }
}
