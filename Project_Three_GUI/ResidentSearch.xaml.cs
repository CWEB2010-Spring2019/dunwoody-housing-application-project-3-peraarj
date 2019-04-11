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
    /// Interaction logic for ResidentSearch.xaml
    /// </summary>
    public partial class ResidentSearch : Window
    {
		

		public ResidentSearch()
        {
            InitializeComponent();
			bindDataGrid();
        }



		private void bindDataGrid()
		{
			SqlConnection con = new SqlConnection();
			con.ConnectionString = ConfigurationManager.ConnectionStrings[@"TableConnection"].ConnectionString;
			con.Open();

			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = "select * from [Table]";
			cmd.Connection = con;
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable("Table");
			da.Fill(dt);


			DataGridResident.ItemsSource = dt.DefaultView;
			con.Close();
		}

		private void Ressearch_Back_Click(object sender, RoutedEventArgs e)
		{
			Selection selection = new Selection();
			selection.Show();
			this.Close();
		}
	}
}
