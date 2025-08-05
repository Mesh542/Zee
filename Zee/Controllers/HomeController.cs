using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Zee.Data_Context;
using Zee.Models;

namespace Zee.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly StoreDbContext _context;


        public HomeController(ILogger<HomeController> logger, StoreDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Expenses()
        {
            List<Expense> expenses = _context.Expenses.ToList();
            return View(expenses);
        }

        [HttpGet]
        public IActionResult CreateEditExpense()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateEditExpense(Expense expense)
        {
            expense.ExpenseId = Guid.NewGuid();
            _context.Expenses.Add(expense);
            _context.SaveChanges();
            return RedirectToAction(nameof(Expenses));
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
