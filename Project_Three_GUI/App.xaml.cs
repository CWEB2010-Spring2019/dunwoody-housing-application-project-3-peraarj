using System;
using System.Collections.Generic;
using System.Configuration;
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
using System.Windows.Shapes;

namespace Project_Three_GUI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

	
		public static void openConnection()
		{
			SqlConnection con = new SqlConnection();
			con.ConnectionString = ConfigurationManager.ConnectionStrings[@"TableConnection"].ConnectionString;
			con.Open();
		}

		public static void closeConnection()
		{
			SqlConnection con = new SqlConnection();
			con.ConnectionString = ConfigurationManager.ConnectionStrings[@"TableConnection"].ConnectionString;
			con.Close();
		}

	}
}
