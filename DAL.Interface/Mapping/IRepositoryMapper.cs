using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface.Mapping
{
	public interface IRepositoryMapper<TBusinessEntity, TStorageEntity>
	{
		void MapBusinessToStorage(TBusinessEntity bEntity, TStorageEntity sEntity);

		TBusinessEntity MapStorageToBusiness( TStorageEntity sEntity );
	}
}
