using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
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
    /// Interaction logic for ResidentEntry.xaml
    /// </summary>
    public partial class ResidentEntry : Window
	{
		List<Models.Resident> resList = new List<Models.Resident>();
		

		public ResidentEntry()
        {
            InitializeComponent();
		
			
		}




		private void Athlete_Rdio_Checked(object sender, RoutedEventArgs e)
		{
			//List< Models.Athlete > resList = new List<Models.Athlete>();
			choice_1.Content = 4;
			choice_2.Content = 5;
			choice_3.Content = 6;
		}

		private void Emp_Rdio_Checked(object sender, RoutedEventArgs e)
		{
			//List<Models.Worker> resList = new List<Models.Worker>();
			choice_1.Content = 1;
			choice_2.Content = 2;
			choice_3.Content = 3;
		}

		private void Scholar_Rdio_Checked(object sender, RoutedEventArgs e)
		{
			//List<Models.Scholar> resList = new List<Models.Scholar>();
			choice_1.Content = 7;
			choice_2.Content = 8;
			choice_3.Content = null;
		}

		private void SaveRecord_Btn_Click(object sender, RoutedEventArgs e)
		{
			if(Athlete_Rdio.IsChecked == true)
			{
				
				resList.Add(new Models.Athlete( NewFName_TBox.Text, NewFName_TBox.Text, Convert.ToInt32(RmNum_ComboBx.Text), Convert.ToInt32(NewRoom_Num_TBox.Text), 1200 ));
				SqlConnection con = new SqlConnection();
				con.ConnectionString = ConfigurationManager.ConnectionStrings[@"TableConnection"].ConnectionString;
				con.Open();
				SqlCommand cmd = new SqlCommand("insert into [Table] (Res_FName, Res_LName, Res_Cat, Room_Num, Floor_Num) values ('"+NewFName_TBox.Text+"', '"+NewLName_TBox.Text+"','"+"Athlete"+"', '"+Convert.ToInt32(RmNum_ComboBx.Text)+"', '"+Convert.ToInt32(NewRoom_Num_TBox.Text)+"')", con);
				cmd.ExecuteNonQuery();
			
				con.Close();
				NewFName_TBox.Text = String.Empty;
				NewLName_TBox.Text = String.Empty;
				Athlete_Rdio.IsChecked = false;
			
				NewRoom_Num_TBox.Text = String.Empty;
			}

			if (Emp_Rdio.IsChecked == true)
			{
				
				resList.Add(new Models.Worker(NewFName_TBox.Text, NewFName_TBox.Text, Convert.ToInt32(RmNum_ComboBx.Text), Convert.ToInt32(NewRoom_Num_TBox.Text), 1245));
				SqlConnection con = new SqlConnection();
				con.ConnectionString = ConfigurationManager.ConnectionStrings[@"TableConnection"].ConnectionString;
				con.Open();
				SqlCommand cmd = new SqlCommand("insert into [Table] (Res_FName, Res_LName, Res_Cat, Room_Num, Floor_Num) values ('" + NewFName_TBox.Text + "', '" + NewLName_TBox.Text + "','" + "Worker" + "', '" + Convert.ToInt32(RmNum_ComboBx.Text) + "', '" + Convert.ToInt32(NewRoom_Num_TBox.Text) + "')", con);
				cmd.ExecuteNonQuery();
				
				con.Close();
				NewFName_TBox.Text = String.Empty;
				NewLName_TBox.Text = String.Empty;
				Athlete_Rdio.IsChecked = false;

				NewRoom_Num_TBox.Text = String.Empty;
			}

			if (Scholar_Rdio.IsChecked == true)
			{
				
				resList.Add(new Models.Scholar(NewFName_TBox.Text, NewFName_TBox.Text, Convert.ToInt32(RmNum_ComboBx.Text), Convert.ToInt32(NewRoom_Num_TBox.Text), 1200));
				SqlConnection con = new SqlConnection();
				con.ConnectionString = ConfigurationManager.ConnectionStrings[@"TableConnection"].ConnectionString;
				con.Open();
				SqlCommand cmd = new SqlCommand("insert into [Table] (Res_FName, Res_LName, Res_Cat, Room_Num, Floor_Num) values ('" + NewFName_TBox.Text + "', '" + NewLName_TBox.Text + "','" + "Scholar" + "', '" + Convert.ToInt32(RmNum_ComboBx.Text) + "', '" + Convert.ToInt32(NewRoom_Num_TBox.Text) + "')", con);
				cmd.ExecuteNonQuery();
				
				con.Close();
				NewFName_TBox.Text = String.Empty;
				NewLName_TBox.Text = String.Empty;
				Athlete_Rdio.IsChecked = false;

				NewRoom_Num_TBox.Text = String.Empty;
			}

		}

		private void Entry_Back_btn_Click(object sender, RoutedEventArgs e)
		{
			Selection selection = new Selection();
			selection.Show();
			this.Close();
		}
	}
}
