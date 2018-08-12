using System;
using Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace Database
{
    public class TestDbContext : DbContext
	{
		public	TestDbContext(DbContextOptions<TestDbContext> options) : base(options)
		{

		}

		public DbSet<Student> Students { get; set; }

	}
}
