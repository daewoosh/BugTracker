using DAL.Implementation.Builder;
using DAL.Implementation.Context;
using DAL.Implementation.DBEntities;
using DAL.Implementation.Mapping;
using DAL.Interface.Builder;
using DAL.Interface.QueryObject;
using DomainEntities.Entities;
using DomainEntities.Entities.Users;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementation.Repository
{
	public class UserRepository : BaseRepository<IUser, IUserBuilder, IUserQueryObject>
	{
		private DataContext _context;
		private UserMapper _mapper;
		public UserRepository( DataContext context )
		{
			_context = context;
			_mapper = new UserMapper(_context);
		}
		public override IUserBuilder CreateNew()
		{
			return new UserBuilder( );
		}

		public override void Add( IUser entity )
		{
			var newStoreEntity = new UserStoreEntity();
			_mapper.MapBusinessToStorage( entity, newStoreEntity );
			_context.Users.Add( newStoreEntity );
		}

		public override void Delete( IUser entity )
		{
			var user = _context.Users.FirstOrDefault( x => x.Id == entity.Id );
			_context.Users.Remove(user);
		}

		public override void Delete( int Id )
		{
			var user = _context.Users.FirstOrDefault( x => x.Id == Id );
			_context.Users.Remove(user);
		}

		public override IEnumerable<IUser> Query( IUserQueryObject query )
		{
			var storeObjects = ExecuteQuery( query );
			var mapper = _mapperGenerator( DataContext );
			var sss = storeObjects.ToList();

			List<TBusinesEntity> b = new List<TBusinesEntity>();

			foreach( var item in sss )
			{
				b.Add( ConfigureBeforeReturn( mapper.MapStorageToBusines( item ) ) );
			}

			//var sss111 = sss.Select( s => ConfigureBeforeReturn( ) );
			return b;
		}

		protected IQueryable<UserStoreEntity> ExecuteQuery( IUserQueryObject query )
		{
			IQueryable<UserStoreEntity> collection = _context.Users.AsQueryable();

			if( query.All )
				return collection;

			if( !String.IsNullOrEmpty( query.FirstName ) )
				collection = collection.Where( c => c.FirstName == query.FirstName );

			if( !String.IsNullOrEmpty( query.LastName ) )
				collection = collection.Where( c => c.LastName == query.LastName );

			if( query.Position.HasValue )
				collection = collection.Where( c => c.Position == (byte)query.Position.Value );

			return collection;
		}

		public override void Commit()
		{
			_context.SaveChanges();
		}
	}
}
