using DAL.Interface.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
	public interface IRepositorySet
	{
		IUserRepository UserRepository { get; }
		ITaskRepository TaskRepository { get; }
	}
}
