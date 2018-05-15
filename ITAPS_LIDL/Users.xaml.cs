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
    public partial class Users : Window
    {
        public Users()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            //datagrid.Items.Add(new Item { });
            datagrid.Items.Add(new AllUsers { Id = "1", Company = "broker", Name = "ADAMČOVÁ KATARÍNA", Categhory = "zakladny", TypA = true, PosledneSkolenie = "14.8.2018", TypB = false, PoslednyTest = "---", Email = "blabljjggtftfa@gmail.com", Hours = "8", Note = "Note1" });
            datagrid.Items.Add(new AllUsers { Id = "2", Company = "broker", Name = "BEDNÁROVÁ ANNA", Categhory = "zakladny", TypA = false, PosledneSkolenie = "---", TypB = true, PoslednyTest = "14.7.2018", Email = "blabla@gmail.com", Hours = "8", Note = "Note1", State = "State2" });
            datagrid.Items.Add(new AllUsers { Id = "3", Company = "uclis", Name = "BRIEDOVÁ KATARÍNA", Categhory = "zakladny", TypA = true, PosledneSkolenie = "14.8.2018", TypB = true, PoslednyTest = "14.8.2018", Email = "blabla@gmail.com", Hours = "8", Note = "Note1" });
            datagrid.Items.Add(new AllUsers { Id = "4", Company = "jednoosobova", Name = "BUDAY PETER", Categhory = "zakladny", TypA = true, PosledneSkolenie = "20.8.2018", TypB = false, PoslednyTest = "---", Email = "blabljjggtftfa@gmail.com", Hours = "8", Note = "Note1" });
            datagrid.Items.Add(new AllUsers { Id = "5", Company = "broker", Name = "FOLTIN FILIP", Categhory = "zakladny", TypA = false, PosledneSkolenie = "---", TypB = true, PoslednyTest = "14.6.2018", Email = "blabla@gmail.com", Hours = "8", Note = "Note1", State = "State1" });
            datagrid.Items.Add(new AllUsers { Id = "6", Company = "uclis", Name = "GREČMAL BRANISLAV", Categhory = "zakladny", TypA = true, PosledneSkolenie = "14.8.2018", TypB = false, PoslednyTest = "---", Email = "blabla@gmail.com", Hours = "8", Note = "Note1" });
            datagrid.Items.Add(new AllUsers { Id = "7", Company = "broker", Name = "GRŇO MICHAL", Categhory = "zakladny", TypA = false, PosledneSkolenie = "---", TypB = true, PoslednyTest = "14.8.2018", Email = "blabljjggtftfa@gmail.com", Hours = "8", Note = "Note1" });
            datagrid.Items.Add(new AllUsers { Id = "8", Company = "broker", Name = "HAVALOVÁ ERIKA", Categhory = "zakladny", TypA = true, PosledneSkolenie = "12.8.2018", TypB = false, PoslednyTest = "---", Email = "blabla@gmail.com", Hours = "8", Note = "Note1" });
            datagrid.Items.Add(new AllUsers { Id = "9", Company = "uclis", Name = "HUĽVEJOVÁ MARCELA", Categhory = "vyssi", TypA = true, PosledneSkolenie = "1.7.2018", TypB = true, PoslednyTest = "14.8.2018", Email = "blabla@gmail.com", Hours = "8", Note = "Note1", State = "State2" });
            datagrid.DataContext = datagrid.Items;

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

        

        private void Label_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            string s = "slov";
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void datagrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (datagrid.SelectedItem == null) return;
            var user = datagrid.SelectedValue;
        }
    }

    public class AllUsers
    {
        public string Id { get; set; }
        public string Company { get; set; }
        public string Name { get; set; }
        public string Categhory { get; set; }
        public string PosledneSkolenie { get; set; }
        public string PoslednyTest { get; set; }
        public string Email { get; set; }
        public string Hours { get; set; }
        public string Note { get; set; }
        public string State { get; set; }
        public bool TypA { get; set; }
        public bool TypB { get; set; }
        public bool TypC { get; set; }
    }
}
