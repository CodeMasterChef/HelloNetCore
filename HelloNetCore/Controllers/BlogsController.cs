using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HelloNetCore.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HelloNetCore.Controllers
{
    [Route("api/[controller]")]
    public class BlogsController : Controller
    {
        private readonly DatabaseContext _context;

        public BlogsController(DatabaseContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var blogs = _context.Blogs;
            return Ok(blogs);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody]BlogEntity blog)
        {
           await _context.AddAsync(blog);
           await  _context.SaveChangesAsync();
           return Created("" , blog.Id);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
