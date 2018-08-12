using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Database.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Database.Repository
{
	public class GenericRepository<T> : IGenericRepository<T> where T : class
	{

		TestDbContext db;
		DbSet<T> entity;
		//public GenericRepository(IDesignTimeDbContextFactory<TestDbContext> contextFactory)
		public GenericRepository(TestDbContext context)
		{

			string[] arg = null;
			db = context;//contextFactory.CreateDbContext(arg);
		  	entity = db.Set<T>();
		}
		public virtual void Add(T newRecord)
		{
			entity.Add(newRecord);
			db.SaveChanges();

		}

		public virtual void Delete(int id)
		{
			var toBeDeleted = entity.Find(id);
			entity.Remove(toBeDeleted);
			db.SaveChanges();
		}

		public virtual async Task<ICollection<T>> GetAsync()
		{
			return await entity.ToListAsync();
		}

		public virtual async Task<T> GetAsync(int id)
		{
			throw new NotImplementedException();
		}

		public virtual void Update(T newRecord)
		{
			throw new NotImplementedException();
		}
	}
}
