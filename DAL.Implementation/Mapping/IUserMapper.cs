using DAL.Implementation.DBEntities;
using DAL.Interface.Mapping;
using DomainEntities.Entities;

namespace DAL.Implementation.Mapping
{
	public interface IUserMapper : IRepositoryMapper<IUser, UserStoreEntity>
	{
	}
}
