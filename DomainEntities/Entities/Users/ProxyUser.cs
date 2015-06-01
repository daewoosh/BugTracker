using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainEntities.Entities.Users
{
	public class ProxyUser : User, IUser
	{
		private IEnumerable<ITask> _relatedTasks;
		private Func<IEnumerable<ITask>> _setTasks;


		public override IEnumerable<ITask> RelatedTasks
		{
			get
			{
				if ( _relatedTasks.IsNull() )
					return _setTasks();
				return _relatedTasks;
			}
			set
			{
 
			}
		}


		public ProxyUser SetRelatedTasksFunc( Func<IEnumerable<ITask>> setRelatedTasks )
		{
			_setTasks = setRelatedTasks;

			return this;
		}
	}
}
