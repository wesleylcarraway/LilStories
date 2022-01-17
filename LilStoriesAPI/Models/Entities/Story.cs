namespace LilStoriesAPI.Models.Entities
{
    public class Story
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
    }
}
