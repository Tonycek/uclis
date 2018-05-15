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
    public partial class MainPage : Window
    {
        public MainPage()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            //datagrid.Items.Add(new Item { });

            // create and add two lines of fake data to be displayed, here
            datagrid.Items.Add(new User { Id = "1", Company = "broker", Name = "ADAMČOVÁ KATARÍNA", Categhory = "zakladny", TypA = true, Training = "14.8.2018", TypB = false, Test = "---", Email = "blabljjggtftfa@gmail.com", Hours="8", Note="Note1"});
            datagrid.Items.Add(new User { Id = "2", Company = "broker", Name = "BEDNÁROVÁ ANNA", Categhory = "zakladny", TypA = false, Training = "---", TypB = true, Test = "14.7.2018", Email = "blabla@gmail.com", Hours = "8", Note = "Note1", State = "State2" });
            datagrid.Items.Add(new User { Id = "3", Company = "uclis", Name = "BRIEDOVÁ KATARÍNA", Categhory = "zakladny", TypA = true, Training = "14.8.2018", TypB = true, Test = "14.8.2018", Email = "blabla@gmail.com", Hours = "8", Note = "Note1" });
            datagrid.Items.Add(new User { Id = "4", Company = "jednoosobova", Name = "BUDAY PETER", Categhory = "zakladny", TypA = true, Training = "20.8.2018", TypB = false, Test = "---", Email = "blabljjggtftfa@gmail.com", Hours = "8", Note = "Note1" });
            datagrid.Items.Add(new User { Id = "5", Company = "broker", Name = "FOLTIN FILIP", Categhory = "zakladny", TypA = false, Training = "---", TypB = true, Test = "14.6.2018", Email = "blabla@gmail.com", Hours = "8", Note = "Note1", State = "State1" });
            datagrid.Items.Add(new User { Id = "6", Company = "uclis", Name = "GREČMAL BRANISLAV", Categhory = "zakladny", TypA = true, Training = "14.8.2018", TypB = false, Test = "---", Email = "blabla@gmail.com", Hours = "8", Note = "Note1" });
            datagrid.Items.Add(new User { Id = "7", Company = "broker", Name = "GRŇO MICHAL", Categhory = "zakladny", TypA = false, Training = "---", TypB = true, Test = "14.8.2018", Email = "blabljjggtftfa@gmail.com", Hours = "8", Note = "Note1" });
            datagrid.Items.Add(new User { Id = "8", Company = "broker", Name = "HAVALOVÁ ERIKA", Categhory = "zakladny", TypA = true, Training = "12.8.2018", TypB = false, Test = "---", Email = "blabla@gmail.com", Hours = "8", Note = "Note1" });
            datagrid.Items.Add(new User { Id = "9", Company = "uclis", Name = "HUĽVEJOVÁ MARCELA", Categhory = "vyssi", TypA = true, Training = "1.7.2018", TypB = true, Test = "14.8.2018", Email = "blabla@gmail.com", Hours = "8", Note = "Note1", State = "State2" });
            datagrid.DataContext = datagrid.Items;

        }

        //public async void Send()
        //{
        //    TelerivetAPI tr = new TelerivetAPI(YOUR_API_KEY);
        //    Project project = tr.InitProjectById(project_id);

        //    ScheduledMessage scheduled_msg = await project.ScheduleMessageAsync(Util.Options(
        //        "content", "Reminder!",
        //        "to_number", "+16505550234",
        //        "start_time_offset", 86400
        //    ));

        //    scheduled_msg.
        //}

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                //string připojovacíŘetězec = String.Format("Data Source=TONO_NB;Initial Catalog=LIDL;User ID=Tonycek;Password=Tonycek");
                //datovePripojenie.ConnectionString = připojovacíŘetězec;
                //datovePripojenie.Open();

                //SqlCommand datovýPříkaz = new SqlCommand();
                //datovýPříkaz.Connection = datovePripojenie;
                //datovýPříkaz.CommandType = CommandType.Text;
                //datovýPříkaz.CommandText = "select U.login, R.role, S.shop " +
                //                            "from LIDL.dbo.Users U inner join " +
                //                            "LIDL.dbo.Roles R on U.role = R.id " +
                //                            "inner join LIDL.dbo.Shops S on U.shop = S.id " +
                //                            "where U.id = 1";

                ////                        "SELECT OrderID, OrderDate, ShippedDate, ShipName, " +
                ////"ShipAddress, ShipCity, ShipCountry " +
                ////"FROM Northwind.dbo.Orders WHERE CustomerID = @IdZákazníka";
                ////SqlParameter param = new SqlParameter("@IdZákazníka", SqlDbType.Char, 5);
                ////param.Value = idZákazníka;
                ////datovýPříkaz.Parameters.Add(param);

                //SqlDataReader datovýSnímač = datovýPříkaz.ExecuteReader();
                //while (datovýSnímač.Read())
                //{
                //    string login = datovýSnímač.GetString(0);
                //    string role = datovýSnímač.GetString(1);
                //    string shop = datovýSnímač.GetString(2);
                //}
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
            string var = choosePageCombobox.SelectedValue.ToString();
        }
    }

    public class User
    {
        public string Id { get; set; }
        public string Company { get; set; }
        public string Name { get; set; }
        public string Categhory { get; set; }
        public string Training { get; set; }
        public string Test { get; set; }
        public string Email { get; set; }
        public string Hours { get; set; }
        public string Note { get; set; }
        public string State { get; set; }
        public bool TypA { get; set; }
        public bool TypB { get; set; }
        public bool TypC { get; set; }
    }
}
