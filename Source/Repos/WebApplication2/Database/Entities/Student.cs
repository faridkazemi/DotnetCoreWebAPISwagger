using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Database.Entities
{
 public  class Student
    {
		[Key]
		public int Id { get; set; }

		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Name { get; set; }
		public int Age { get; set; }
		public decimal GPA { get; set; }

	}
}
