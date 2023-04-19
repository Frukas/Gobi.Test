using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gobi.Test.Jr.Domain.Interfaces
{
	public interface ITodoItemService
	{
		public IEnumerable<TodoItem> GetAll();
		public void Add(TodoItem todoItem);
		public void Update(TodoItem todoItem);
		public void Delete(int toBeDeletedId);

	}
}
