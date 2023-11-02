using Microsoft.AspNetCore.Mvc;
using PS.All_Films.Web.BusinessLogic.Interfaces;
using PS.All_Films.Web.Models;

namespace PS.All_Films.Web.Controllers
{
    public class MovieController : Controller
    {

        private readonly IMovie _context;

        public MovieController(IMovie context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(string sortExpression = "", string searchText = "", int currentPage = 1, int pageSize = 5)
        {
            SortModel sortModel = new SortModel();
            sortModel.AddColumn("name");
            sortModel.AddColumn("description");
            sortModel.AddColumn("rating");
            sortModel.ApplySort(sortExpression);

            var movies = await _context.GetItemsAsync(sortModel.SortedProperty, sortModel.SortedOrder, searchText, currentPage, pageSize);

            var pager = new PagerModel(movies.TotalRecords, currentPage, pageSize);
            pager.SortExpression = sortExpression;


            ViewData["sortModel"] = sortModel;
            ViewBag.SearchText = searchText;
            ViewBag.Pager = pager;

            return View(movies);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var movie = new Movie();
            return View(movie);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Movie movie)
        {
            try
            {
                movie = await _context.GreateAsync(movie);
            }
            catch { }

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Details(Guid id)
        {
            var movie = await _context.GetItemAsync(id);

            if (movie != null)
            {
                return View(movie);
            }

            return NotFound();
        }


        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var movie = await _context.GetItemAsync(id);

            if (movie != null)
            {
                return View(movie);
            }

            return NotFound();
        }


        [HttpPost]
        public async Task<IActionResult> Edit(Movie movie)
        {
            try
            {
                movie = await _context.EditAsync(movie);
            }
            catch { }

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            var movie = await _context.GetItemAsync(id);

            if (movie != null)
            {
                return View(movie);
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Movie movie)
        {
            try
            {
                movie = await _context.DeleteAsync(movie);
            }
            catch { }

            return RedirectToAction(nameof(Index));
        }
    }
}
