using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementation.DBEntities
{
	internal class UserStoreEntity
	{
		public int Id { get; set; }
		public string LastName { get; set; }
		public string FirstName { get; set; }
		public byte Position { get; set; }
		public virtual ICollection<TaskStoreEntity> RelatedTasks { get; set; }
	}
}
