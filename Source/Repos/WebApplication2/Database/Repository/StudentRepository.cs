using System;
using System.Collections.Generic;
using System.Text;
using Database.Entities;
using Database.Repository.Interfaces;
using Microsoft.EntityFrameworkCore.Design;

namespace Database.Repository
{
	public class StudentRepository : GenericRepository<Student>, IstudentRepository
	{
		//public StudentRepository(IDesignTimeDbContextFactory<TestDbContext> contextFactory) : base(contextFactory)
		public StudentRepository(TestDbContext context) : base(context)
		{
		}
	}
}
