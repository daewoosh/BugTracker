using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainEntities.Entities
{
	public abstract class Task : ITask
	{
		#region ITask

		public string Title { get; set; }

		public string Description { get; set; }

		public DateTime CreationDate { get; set; }

		public Library.Enums.TaskStates TaskState { get; set; }

		public abstract IUser User { get; set; } 
		
		#endregion


	}
}
