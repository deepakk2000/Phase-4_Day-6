using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppMovies.Models;

namespace WebAppMovies.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesCotroller : ControllerBase
    {
        private static readonly List<Movie> movies = new List<Movie>()
        {
            new() {Id=1,MName="Caption Miller",Gen="Action"},
            new() {Id=2,MName="Ayalan",Gen="Si-Fi"},
            new() {Id=3,MName="Docker",Gen="Horror"}

        };
        [HttpGet(Name = "GetMovies")]
        public IEnumerable<Movie> Get()
        {
            return movies;
        }
    }
}
