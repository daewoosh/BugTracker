using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
	public interface IDalFacade
	{
		/// <summary>
		/// Репозитории
		/// </summary>
		IRepositorySet Repositories { get; }

		/// <summary>
		/// Спецификации
		/// </summary>
		ISpecificationsSets Specifications { get; }

		/// <summary>
		/// загрузчики
		/// </summary>
		IIncludesSets Includes { get; }
	}
}
