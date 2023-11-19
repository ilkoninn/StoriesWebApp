

namespace WebAppStories.Controllers
{
    public class HomeController : Controller
    {
        AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeVM vm = new HomeVM();
            vm.categories = _context.Categories
                .Include(x => x.Recipes)
                .Include(x => x.Stories)
                .ToList();

            return View(vm);
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Stories()
        {
            HomeVM homeVM = new HomeVM();
            homeVM.categories = _context.Categories
                .Include(x => x.Stories)
                .ToList();

            return View(homeVM);
        }
        public IActionResult Recipes()
        {
            HomeVM homeVM = new HomeVM();
            homeVM.categories = _context.Categories
                .Include(x => x.Recipes)
                .ToList();

            return View(homeVM);
        }
        public IActionResult SingleRecipe()
        {
            HomeVM homeVM = new HomeVM();
            homeVM.categories = _context.Categories
                .Include(x => x.Recipes)
                .ToList();

            return View(homeVM);
        }
        public IActionResult SingleStory()
        {
            HomeVM homeVM = new HomeVM();
            homeVM.categories = _context.Categories
                .Include(x => x.Stories)
                .ToList();

            return View(homeVM);
        }
    }
}
