using Microsoft.AspNetCore.Mvc;
using MuziekAPI.Data;
using MuziekAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MuziekAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtiestenContoller : ControllerBase
    {
        // GET: api/<ArtiestenContoller>
        [HttpGet]
        public IEnumerable<Artiest> Get()
        {
            return InMemoryMusicRepository.Artiesten;
        }

        // GET api/<ArtiestenContoller>/5
        [HttpGet("{id}")]
        public Artiest Get(int id)
        {
            return InMemoryMusicRepository.Artiesten.Where(artiest=>artiest.Id==id).FirstOrDefault();
        }

        // POST api/<ArtiestenContoller>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ArtiestenContoller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ArtiestenContoller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
