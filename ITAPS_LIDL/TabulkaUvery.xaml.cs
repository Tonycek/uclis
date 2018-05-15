using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
using Telerivet.Client;
using Newtonsoft.Json.Linq;

namespace ITAPS_LIDL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class TabulkaUvery : Window
    {
        public TabulkaUvery()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;

            datagrid.Items.Add(new ObnovaSkolenia { Termin = "1.1.2019", Email = "a.katarina@gmail.com", Hours = "18", Note = ""});
            datagrid.Items.Add(new ObnovaSkolenia { Termin = "2.2.2019", Email = "a.bednarova@gmail.com", Hours = "16", Note = "zakladny"});
            datagrid.Items.Add(new ObnovaSkolenia { Termin = "3.3.2019", Email = "k.briedova@gmail.com", Hours = "24", Note = ""});
            datagrid.Items.Add(new ObnovaSkolenia { Termin = "4.1.2019", Email = "p.budaj@gmail.com", Hours = "20", Note = "vyssi"});
            datagrid.Items.Add(new ObnovaSkolenia { Termin = "1.1.2019", Email = "a.katarina@gmail.com", Hours = "18", Note = "" });
            datagrid.Items.Add(new ObnovaSkolenia { Termin = "2.2.2019", Email = "a.bednarova@gmail.com", Hours = "16", Note = "najvyssia uroven" });
            datagrid.Items.Add(new ObnovaSkolenia { Termin = "3.3.2019", Email = "k.briedova@gmail.com", Hours = "24", Note = "" });
            datagrid.Items.Add(new ObnovaSkolenia { Termin = "4.1.2019", Email = "p.budaj@gmail.com", Hours = "20", Note = "vyssi" });

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
               
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void choosePageCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Label_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void datagrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (datagrid.SelectedItem == null) return;
                var user = datagrid.SelectedValue;
        }
    }

    public class ObnovaSkolenia
    {
        public string Termin { get; set; }
        public string Email { get; set; }
        public string Hours { get; set; }
        public string Note { get; set; }
    }
}
