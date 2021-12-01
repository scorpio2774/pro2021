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
    /// Interaction logic for Studenti.xaml
    /// </summary>
    public partial class Studenti : Window
    {
        public Studenti()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            StudentNepovezan.ŠtudentNetDataSet študentNetDataSet = ((StudentNepovezan.ŠtudentNetDataSet)(this.FindResource("študentNetDataSet")));
            // Load data into the table Ocene. You can modify this code as needed.
            StudentNepovezan.ŠtudentNetDataSetTableAdapters.OceneTableAdapter študentNetDataSetOceneTableAdapter = new StudentNepovezan.ŠtudentNetDataSetTableAdapters.OceneTableAdapter();
            študentNetDataSetOceneTableAdapter.Fill(študentNetDataSet.Ocene);
            System.Windows.Data.CollectionViewSource oceneViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("oceneViewSource")));
            oceneViewSource.View.MoveCurrentToFirst();
            // Load data into the table Študent. You can modify this code as needed.
            StudentNepovezan.ŠtudentNetDataSetTableAdapters.ŠtudentTableAdapter študentNetDataSetŠtudentTableAdapter = new StudentNepovezan.ŠtudentNetDataSetTableAdapters.ŠtudentTableAdapter();
            študentNetDataSetŠtudentTableAdapter.Fill(študentNetDataSet.Študent);
            System.Windows.Data.CollectionViewSource študentViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("študentViewSource")));
            študentViewSource.View.MoveCurrentToFirst();
        }
    }
}
