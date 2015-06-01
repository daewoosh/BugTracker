using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
	public static class CommonExtentions
	{
		/// <summary>
		/// Проверка того, что объект не существует
		/// </summary>
		public static bool IsNull<T>( this T obj ) where T : class
		{
			return obj == null;
		}
	}
}
