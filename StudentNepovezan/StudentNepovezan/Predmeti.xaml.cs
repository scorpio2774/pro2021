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
    /// Interaction logic for Predmeti.xaml
    /// </summary>
    public partial class Predmeti : Window
    {
        ŠtudentNetDataSet študentNetDataSet;
        ŠtudentNetDataSetTableAdapters.PredmetTableAdapter pta;
        CollectionViewSource predmetViewSource;
        ŠtudentNetDataSetTableAdapters.OceneTableAdapter sta;
        public Predmeti()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

             študentNetDataSet = ((StudentNepovezan.ŠtudentNetDataSet)(this.FindResource("študentNetDataSet")));
            // Load data into the table Predmet. You can modify this code as needed.
            ŠtudentNetDataSetTableAdapters.PredmetTableAdapter pta = new StudentNepovezan.ŠtudentNetDataSetTableAdapters.PredmetTableAdapter();
            pta.Fill(študentNetDataSet.Predmet);
            CollectionViewSource predmetViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("predmetViewSource")));
            predmetViewSource.View.MoveCurrentToFirst();
            // Load data into the table Ocene. You can modify this code as needed.
            ŠtudentNetDataSetTableAdapters.OceneTableAdapter sta = new StudentNepovezan.ŠtudentNetDataSetTableAdapters.OceneTableAdapter();
            sta.Fill(študentNetDataSet.Ocene);
            CollectionViewSource predmetOceneViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("predmetOceneViewSource")));
            predmetOceneViewSource.View.MoveCurrentToFirst();
        }
    }
}
