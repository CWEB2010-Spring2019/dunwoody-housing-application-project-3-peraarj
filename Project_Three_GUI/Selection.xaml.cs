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

namespace Project_Three_GUI
{
    /// <summary>
    /// Interaction logic for Selection.xaml
    /// </summary>
    public partial class Selection : Window
    {
        public Selection()
        {
            InitializeComponent();
        }

		private void NewRecord_Btn_Click(object sender, RoutedEventArgs e)
		{
			ResidentEntry entry = new ResidentEntry();
			entry.Show();
			this.Close();
		}

	

		private void Search_All_Btn_Click(object sender, RoutedEventArgs e)
		{
			ResidentSearch search = new ResidentSearch();
			search.Show();
			this.Close();
		}
	}
}
