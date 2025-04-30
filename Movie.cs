namespace MOD10_103022300125;

public class Movie //mendeklarasikan kelas movie
{
    public string Title { get; set; }
    public string Director { get; set; }
    public List<string> Stars { get; set; }
    public string Description { get; set; }

    //kontruktor untuk menginisialisasi objek movie dengan title, director, strars dan description
    public Movie (string Title, string Director, List<string> Stars, string Description)
    {
        this.Title = Title;
        this.Director = Director;
        this.Stars = Stars;
        this.Description = Description;
    }
}
