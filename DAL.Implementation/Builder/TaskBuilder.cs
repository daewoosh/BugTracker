using DAL.Interface.Builder;
using DomainEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementation.Builder
{
	public class TaskBuilder : ITaskBuilder
	{
		private ProxyTask _newTask;
		public TaskBuilder()
		{
			_newTask = new ProxyTask();
		}
		public ITaskBuilder SetCreationDate( DateTime dateTime )
		{
			_newTask.CreationDate = dateTime;
			return this;
		}

		public ITaskBuilder SetTitle( string title )
		{
			_newTask.Title = title;
			return this;
		}

		public ITaskBuilder SetDescription( string description )
		{
			_newTask.Description = description;
			return this;
		}

		public ITaskBuilder SetUser( IUser user )
		{
			_newTask.User = user;
			return this;
		}
		public DomainEntities.Entities.ITask Done()
		{
			return _newTask;
		}
	}
}
