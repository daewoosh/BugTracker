using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainEntities.Entities
{
	public abstract class User : IUser
	{
		public string LastName { get; set; }

		public string FirstName { get; set; }

		public Enums.PositionsEnum UsersPosition { get; set; }

		public abstract IEnumerable<ITask> RelatedTasks { get; set; }
	}
}
