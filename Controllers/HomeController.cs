using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BookStoreApp.Models;
using BookStoreApp.Data;      
using System.Linq;            

namespace BookStoreApp.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext _context;   

    
    public HomeController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
       
        ViewBag.AuthorCount = _context.Authors.Count();
        ViewBag.BookCount = _context.Books.Count();

        return View();
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