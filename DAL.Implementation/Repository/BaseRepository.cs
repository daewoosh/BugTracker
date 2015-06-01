using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementation.Repository
{
	public abstract class BaseRepository<TBusinesEntity, TEntityBuilder, TQueryObject> : IRepository<TBusinesEntity, TEntityBuilder, TQueryObject>
	{
		public abstract TEntityBuilder CreateNew();

		public abstract void Add( TBusinesEntity entity );

		public abstract void Delete( TBusinesEntity entity );

		public abstract void Delete( int Id );

		public abstract IEnumerable<TBusinesEntity> Query( TQueryObject query );

		public abstract void Commit();
	}
}
