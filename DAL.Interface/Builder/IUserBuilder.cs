using DomainEntities.Entities;
using DomainEntities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface.Builder
{
	public interface IUserBuilder : IEntityBuilder<IUser>
	{
		IUserBuilder SetPosition( PositionsEnum position );

		IUserBuilder SetFIO( string lastName, string firstName );
	}
}
