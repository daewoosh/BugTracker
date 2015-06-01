using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementation.DBEntities
{
	internal class TaskStoreEntity
	{
		public int Id { get; set; }

		public string Title { get; set; }

		public string Description { get; set; }

		public DateTime CreationDate { get; set; }

		public Library.Enums.TaskStates TaskState { get; set; }

		public UserStoreEntity User { get; set; } 
	}
}
