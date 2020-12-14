using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Web;

namespace Proje_Dinamik.Models.Entity
{
	public class Customer
	{
		[Key]
		public int customerID { get; set; }
		public string customerName { get; set; }
		public string customerSurname { get; set; }
		public Int64 customTelephone { get; set; }
		public byte customerAge { get; set; }
		public string customerGender { get; set; }
		public string customerAdress { get; set; }

	}
}