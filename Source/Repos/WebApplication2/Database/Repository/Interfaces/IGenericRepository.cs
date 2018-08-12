using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Database.Repository.Interfaces
{
    public interface IGenericRepository<T> where T:class
    {
		Task<ICollection<T>> GetAsync();
		Task<T> GetAsync(int id);
		void Add(T newRecord);
		void Delete(int id);
		void Update(T newRecord);

    }
}
