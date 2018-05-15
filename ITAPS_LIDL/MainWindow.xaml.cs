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
    public partial class MainWindow : Window
    {
        private SqlConnection datovePripojenie = new SqlConnection();
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;

            
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
    }
}
