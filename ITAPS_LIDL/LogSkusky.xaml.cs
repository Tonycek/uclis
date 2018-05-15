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
    public partial class LogSkusky : Window
    {
        public LogSkusky()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;

            datagrid.Items.Add(new TabulkaLogSkusky { PlatnyDo = "1.1.2020", DatumSkusky = "3.3.2019", Institucia = "uclis", Note = "" });
            datagrid.Items.Add(new TabulkaLogSkusky { PlatnyDo = "2.2.2020", DatumSkusky = "4.4.2019", Institucia = "ucl", Note = "" });
            datagrid.Items.Add(new TabulkaLogSkusky { PlatnyDo = "3.3.2020", DatumSkusky = "4.4.2019", Institucia = "uclis", Note = "" });
            datagrid.Items.Add(new TabulkaLogSkusky { PlatnyDo = "4.1.2020", DatumSkusky = "3.3.2019", Institucia = "ucl", Note = "" });
            datagrid.Items.Add(new TabulkaLogSkusky { PlatnyDo = "1.1.2020", DatumSkusky = "4.4.2019", Institucia = "uclis", Note = "" });
            datagrid.Items.Add(new TabulkaLogSkusky { PlatnyDo = "2.2.2020", DatumSkusky = "4.4.2019", Institucia = "uclis", Note = "" });
            datagrid.Items.Add(new TabulkaLogSkusky { PlatnyDo = "3.3.2020", DatumSkusky = "4.4.2019", Institucia = "uclis", Note = "" });
            datagrid.Items.Add(new TabulkaLogSkusky { PlatnyDo = "4.1.2020", DatumSkusky = "3.3.2019", Institucia = "ucl", Note = "" });

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

    public class TabulkaLogSkusky
    {
        public string PlatnyDo { get; set; }
        public string DatumSkusky { get; set; }
        public string Institucia { get; set; }
        public string Note { get; set; }
    }
}
