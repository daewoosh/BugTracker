using DomainEntities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface.QueryObject
{
	public interface IUserQueryObject : IQueryObject
	{

		string LastName { get; set; }

		string FirstName { get; set; }

		PositionsEnum? Position { get; set; }
	}
}
