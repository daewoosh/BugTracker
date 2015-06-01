using DAL.Implementation.DBEntities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementation.Context
{
	internal class DataContext : DbContext
	{
		public DataContext()
			:base("DbConnectionString")
		{
			
		}

		public DbSet<UserStoreEntity> Users { get; set; }
		public DbSet<TaskStoreEntity> Tasks { get; set; }
	}
}
