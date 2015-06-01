using DAL.Interface.Builder;
using DomainEntities.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementation.Builder
{
	public class UserBuilder : IUserBuilder
	{
		private ProxyUser _newUser;
		public UserBuilder()
		{
			_newUser = new ProxyUser();
		}

		public IUserBuilder SetPosition( DomainEntities.Enums.PositionsEnum position )
		{
			_newUser.UsersPosition = position;
			return this;
		}

		public IUserBuilder SetFIO( string lastName, string firstName )
		{
			_newUser.LastName = lastName;
			_newUser.FirstName = firstName;
			return this;
		}

		public DomainEntities.Entities.IUser Done()
		{
			return _newUser;
		}
	}
}
