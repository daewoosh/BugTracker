using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainEntities.Entities
{
	public class ProxyTask : Task, ITask
	{
		private IUser _user;
		Func<IUser> _setUser;

		public override IUser User
		{
			get
			{
				if ( _user.IsNull() )
					_user = _setUser();
				return _user;
			}
			set
			{
				_user = value;
			}
		}

		public ProxyTask SetUserFunc(Func<IUser> setUser)
		{
			_setUser = setUser;

			return this;
		}
	}
}
