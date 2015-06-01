using Library.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainEntities.Entities
{
	public interface ITask
	{
		string Title { get; set; }
		string Description { get; set; }
		DateTime CreationDate { get; set; }
		TaskStates TaskState { get; set; }
		IUser User { get; set; }
	}
}
