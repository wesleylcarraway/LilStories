namespace LilStoriesAPI.Models.Entities
{
    public class Story : Base
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
    }
}
