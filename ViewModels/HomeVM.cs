using WebAppStories.Models;

namespace WebAppStories.ViewModels
{
    public class HomeVM
    {
        public List<Category> categories { get; set; }
        public List<Recipes> recipes { get; set; }
        public List<Stories> stories { get; set; }
    }
}
