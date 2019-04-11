using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Three_GUI.Models
{
     public abstract class Resident
	{

		
		public String FName { get; set; }
		public String LName { get; set; }
		public String Res_Cat { get; set; }
		public int Floor_Num { get; set; }
		public int Room_Num { get; set; }
		public int moRent { get; set; }
	}    
}
