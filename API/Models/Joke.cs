namespace API.Models
{
    public class Joke
    {
        public required int Id { get; set; }
        public required string Type { get; set; }
        public required string Setup { get; set; }
        public required string Punchline { get; set; }
    }
}
