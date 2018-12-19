using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EscolarProject.Models;
using Microsoft.AspNetCore.Cors;

namespace EscolarProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[EnableCors("AllowSpecificOrigin")]
    public class MateriaController : ControllerBase
    {
        // GET: api/Materia
        [HttpGet]
        public List<Materia> Get()
        {
            return new Materia().select();
        }

        // GET: api/Materia/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Materia
        [HttpPost]
        public int Post(Materia item)
        {
            return new Materia().insert(item);
        }

        // PUT: api/Materia/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
