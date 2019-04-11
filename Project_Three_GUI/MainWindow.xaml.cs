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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;



namespace Project_Three_GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {	// Initialize the window
            InitializeComponent();
			Warn_Lbl.Visibility = Visibility.Hidden;
		}
		
		private void Login_Btn_Click(object sender, RoutedEventArgs e)
		{
			
			if (UserName_TBox.Text == "Home" && Password_TBox.Text == "1234")
			{
			
				Selection selection = new Selection();
				selection.Show();
				this.Close();
			}
			else
			{
				Warn_Lbl.Visibility = Visibility.Visible;
				Warn_Lbl.Foreground = Brushes.Red;
			}
			
		}
	}
}
