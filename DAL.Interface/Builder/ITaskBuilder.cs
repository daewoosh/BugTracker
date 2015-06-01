using DomainEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface.Builder
{
	public interface ITaskBuilder : IEntityBuilder<ITask>
	{
		ITaskBuilder SetCreationDate( DateTime dateTime );

		ITaskBuilder SetTitle( string title );

		ITaskBuilder SetDescription( string description );

		ITaskBuilder SetUser( IUser user );
	}
}
