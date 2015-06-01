using DAL.Implementation.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementation.Mapping
{
	public class UserMapper : IUserMapper
	{
		private DataContext _context;
		public UserMapper( DataContext context )
		{
			_context = context;
		}

		public void MapBusinessToStorage( DomainEntities.Entities.IUser bEntity, DBEntities.UserStoreEntity sEntity )
		{
			
		}

		public DomainEntities.Entities.IUser MapStorageToBusiness( DBEntities.UserStoreEntity sEntity )
		{
			throw new NotImplementedException();
		}
	}
}
