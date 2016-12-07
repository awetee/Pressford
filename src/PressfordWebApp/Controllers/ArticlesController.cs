using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace PressfordWebApp.Controllers
{
    [Route("api/[controller]")]
    public class ArticlesController : Controller
    {
        // GET: api/articles
        [HttpGet]
        public IActionResult Get()
        {
            return this.Ok(new List<Article>());
        }

        // GET api/articles/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return this.Ok(new Article());
        }

        // POST api/articles
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/articles/5
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

    public class Article : IBaseEntity
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public int AuthorId { get; set; }
        public int Id { get; set; }
        public bool Removed { get; set; }
        public DateTime DateCreated { get; set; }
    }

    public interface IBaseEntity
    {
        int Id { get; set; }
        DateTime DateCreated { get; set; }
        bool Removed { get; set; }
    }
}