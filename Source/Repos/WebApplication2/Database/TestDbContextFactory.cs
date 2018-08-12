using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Database
{
	public class TestDbContextFactory : IDesignTimeDbContextFactory<TestDbContext>
	{

		public TestDbContext CreateDbContext(string[] args)
		{
			var builder = new DbContextOptionsBuilder<TestDbContext>();
			
			builder.UseSqlServer("data source=.;initial catalog=test;user id=sa;password=mehrfar;Connect Timeout=240");
			return new TestDbContext(builder.Options);
		}
	}
}
