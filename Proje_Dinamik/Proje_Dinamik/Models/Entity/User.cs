using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proje_Dinamik.Models.Entity
{
	public class User
	{
		[Key]
		public int userID { get; set; }
		public string userName { get; set; }
		[DataType(DataType.Password)]
		public string userPass { get; set; }
	}
}