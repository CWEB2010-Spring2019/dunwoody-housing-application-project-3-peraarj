using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Three_GUI.Models
{
    class Worker : Resident
    {
		double payRate = 14.00;
		double baseRent = 1245;
		
		double hoursWorked;
		String Res_Type;
		double moPay;

		public Worker(String FName, String LName, int Floor_Num, int Room_Num, double baseRent)
		{
			Res_Cat = "Worker";
			payRate = 14.00;
			this.FName = FName;
			this.LName = LName;
			this.Floor_Num = Floor_Num;
			this.Room_Num = Room_Num;
			moPay = (hoursWorked * payRate);
			
		}

		public int ShowRent(double payRate, double hoursworked, double baseRent)
		{
			int actualRent;
			double moPay = hoursWorked * payRate;
			actualRent = Convert.ToInt32(baseRent - (.5 * (moPay)));
			return actualRent;
		}
    }
}
