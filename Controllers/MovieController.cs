using Microsoft.AspNetCore.Mvc;

namespace MOD10_103022300125.Controllers;
[ApiController]
[Route("api/[controller]")]
public class MovieController : ControllerBase
{
    //mendeklarasikan list statis untuk menyimpan data mahasiswa
    private static List<Movie> movieList = new List<Movie>
    {
        new Movie("The Shawshank Redemption", "Frank Darabont", ["Tim Robbins","Morgan Freeman","Bob Gunton"], "A banker convicted of uxoricide forms a friendship over a quarter century with a hardened convict, while maintaining his innocence and trying to remain hopeful through simple compassion."),
        new Movie("The Godfather", "Francis Ford Coppola", ["Marlon Brando","Al Pacino","James Caan"], "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son."),
        new Movie("The Dark Knight", "Christopher Nolan", ["Christian Bale","Heath Ledger","Aaron Eckhart"], "When a menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman, James Gordon and Harvey Dent must work together to put an end to the madness.")
    };

    //GET: api/movie
    [HttpGet]
    public ActionResult<IEnumerable<Movie>> Get()
    {
        return movieList;
    }

    //GET:api/mahasiswa/{id}
    [HttpGet("{id}")]
    public ActionResult<Movie> Get(int id)
    {
        if (id < 0 || id >= movieList.Count)
        {
            return NotFound();
        }
        return movieList[id];
    }

    //POST:api/movie
    [HttpPost]
    public ActionResult<IEnumerable<Movie>> Post([FromBody] Movie movie)
    {
        movieList.Add(movie);
        return movieList;
    }

    //DELETE:api/mahasiswa/{id}
    [HttpDelete("{id}")]
    public ActionResult<IEnumerable<Movie>> Delete(int id)
    {
        if(id < 0 || id >= movieList.Count)
        {
            return NotFound();
        }
        movieList.RemoveAt(id);
        return movieList;
    }
}
