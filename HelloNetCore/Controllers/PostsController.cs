using System.Collections.Generic;
using HelloNetCore.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HelloNetCore.Controllers
{
    [Route("api/[controller]")]
    public class PostsController : Controller
    {
        private readonly DatabaseContext _context;

        public PostsController(DatabaseContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<PostEntity> Get()
        {
            return _context.Posts;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]PostEntity post)
        {
            _context.Add(post);
            _context.SaveChanges();
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
