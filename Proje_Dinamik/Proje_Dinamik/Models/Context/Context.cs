using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Proje_Dinamik.Models.Entity;

namespace Proje_Dinamik.Models.Context
{
	public class Context:DbContext
	{

		public DbSet<User> Users { get; set; }
		public DbSet<Customer> Customers { get; set; }
	}
}