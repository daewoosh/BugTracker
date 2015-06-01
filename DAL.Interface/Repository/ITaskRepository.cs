using DAL.Interface.Builder;
using DAL.Interface.QueryObject;
using DomainEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface.Repository
{
	public interface ITaskRepository : IRepository<ITask, ITaskBuilder, ITaskQueryObject>
	{
	}
}
