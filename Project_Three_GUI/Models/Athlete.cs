using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Three_GUI.Models
{
    class Athlete : Resident
    {
		public Athlete(String FName, String LName, int Floor_Num, int Room_Num, int moRent)
		{
			Res_Cat = "Atlete";
			this.FName = FName;
			this.LName = LName;
			this.Floor_Num = Floor_Num;
			this.Room_Num = Room_Num;
			this.moRent = moRent;
		}
    }
}
