using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
	public interface IRepository<TBusinesEntity, TEntityBuilder, TQueryObject> 
	{
		/// <summary>
		/// Возвращает объект, ответственный за формирование сущности
		/// </summary>
		TEntityBuilder CreateNew();

		/// <summary>
		/// Сохранить сущность
		/// </summary>
		/// <param name="entity"></param>
		void Add( TBusinesEntity entity );

		/// <summary>
		/// Удалить сущность
		/// </summary>
		/// <param name="entity"></param>
		void Delete( TBusinesEntity entity );
		/// <summary>
		/// Удалить сущность по id
		/// </summary>
		/// <param name="entity"></param>
		void Delete( int Id );

		/// <summary>
		/// подгрузка сущности
		/// </summary>
		//TBusinesEntity Include( TBusinesEntity entity, IInclude<TBusinesEntity> include );

		// Получить сучность по спецификации
		IEnumerable<TBusinesEntity> Query( TQueryObject query );


		void Commit();

	}
}
