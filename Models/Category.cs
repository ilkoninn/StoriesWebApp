using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace WebAppStories.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImgUrl { get; set; }
        public List<Stories> Stories { get; set; }
        public List<Recipes> Recipes { get; set; }
    }
}
