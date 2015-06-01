using DomainEntities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainEntities.Entities
{
	public interface IUser
	{
		int Id { get; }
		string LastName { get; set; }
		string FirstName { get; set; }
		PositionsEnum UsersPosition { get; set; }
		IEnumerable<ITask> RelatedTasks { get; set; }
	}
}
