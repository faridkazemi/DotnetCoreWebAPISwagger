using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Database.Entities;
using Database.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    public class StudentController : Controller
    {
		IGenericRepository<Student> _repository;
		public StudentController(IGenericRepository<Student> repository)
		{
			this._repository = repository;
		}
        // GET api/get
        [HttpGet]
        public async Task<IEnumerable<Student>> Get()
        {
			return await _repository.GetAsync();
        }

        // GET api/get/5
        [HttpGet("{id}")]
		public async Task<Student> Get(int id)
        {
			return await _repository.GetAsync(id);
        }

        // POST api/student
        [HttpPost]
        public void Post([FromBody]Student value)
        {
			_repository.Add(value);
        }

        // PUT api/student/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/student/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
