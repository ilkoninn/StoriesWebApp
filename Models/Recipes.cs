namespace WebAppStories.Models
{
    public class Recipes
    {
        public int Id { get; set; }
        public string ShortTitle { get; set; }
        public string LongTitle { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string ImgUrl { get; set; }
        public DateTime CreateDate { get; set; }
        public Category Category { get; set; }
    }
}
