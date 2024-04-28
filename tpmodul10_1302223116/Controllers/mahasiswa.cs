using Microsoft.AspNetCore.Mvc;

namespace tpmodul10_1302223116.Controllers
{ 
    [Route("api/[controller]")]
    [ApiController]
    public class mahasiswa : ControllerBase
    {
        public static List<Mahasiswa> dataMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa("Matthew Theodore Lempas", "1302223116"),
            new Mahasiswa("Marjauza Naswansyah", "1302220009"),
            new Mahasiswa("Nizar Rasyiid", "1302220037"),
            new Mahasiswa("Hasan Nurrahman Pane", "1302220031"),
            new Mahasiswa("Mattew Richard", "0000000000")
        };

        // GET: api/<mahasiswaController>
        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return dataMahasiswa;
        }

        // GET api/<mahasiswaController>/5
        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return dataMahasiswa[id];
        }

        // POST api/<mahasiswaController>
        [HttpPost]
        public void Post([FromBody] Mahasiswa value)
        {
            dataMahasiswa.Add(value);
        }

        // PUT api/<mahasiswaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Mahasiswa value)
        {
            dataMahasiswa[id] = value;
        }

        // DELETE api/<mahasiswaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            dataMahasiswa.RemoveAt(id);
        }
    }
}
