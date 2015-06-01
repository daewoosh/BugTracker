using DomainEntities.Entities;
using Library.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface.QueryObject
{
	public interface ITaskQueryObject : IQueryObject
	{
		TaskStates? TaskState { get; set; }

		IUser User { get; set; }

		string Title { get; set; }

		int? Id { get; set; }
	}
}
