using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace modul10_1302220093.Controllers
{
    // deklarasi controller mahasiswa
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        // deklarasi array of string sebanyak 5 course
        public static List<string> course1 = ["KPL", "Basdat", "PBO", "Alpro", "STD"];

        // inisialisasi data mahasiswa berupa anggota kelompok KPL 3 anggota
        public static List<Mahasiswa> mahasiswa = new List<Mahasiswa>()
        {
            

            new Mahasiswa("Rd.M. Faisal Ramadhan Junaidi","1302220093", course1, 2023),
            new Mahasiswa("Cokorda Arturito Revan Putra Diarta","1302223057", course1, 2024),
            new Mahasiswa("Farrel Haykal Giffari","1302220064", course1, 2025),
        };

        // menggunakan IEnumerable untuk menampilkan seluruh list
        [HttpGet(Name = "GetMahasiswa")]
        public IEnumerable<Mahasiswa> Get()
        {
            return mahasiswa;
        }

        // menggunakan post untuk menambah data pada list mahasiswa
        [HttpPost]
        public void post([FromBody] Mahasiswa ListMahasiswa)
        {
            mahasiswa.Add(ListMahasiswa);
        }
        [HttpGet("{id}")]

        // menampilan data mahasiwa berdasarkan id yang diinput
        public Mahasiswa Get(int id)
        {
            return mahasiswa[id];
        }
        [HttpDelete("{id}")]


        // menggunakan delete untuk menghapus data list berdasarkan id
        public void delete(int id)
        {
            mahasiswa.RemoveAt(id);
        }
    }
}
