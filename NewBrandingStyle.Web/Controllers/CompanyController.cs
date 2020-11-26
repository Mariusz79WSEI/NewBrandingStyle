using Microsoft.AspNetCore.Mvc;
using NewBrandingStyle.Web.Database;
using NewBrandingStyle.Web.Entities;
using NewBrandingStyle.Web.Models;
using System.Linq;

namespace NewBrandingStyle.Web.Controllers
{
   public class CompanyController : Controller
   {
      private readonly ExchangesDbContext _dbContext;

      public CompanyController(ExchangesDbContext dbContext)
      {
         _dbContext = dbContext;
      }

      [HttpGet]
      public IActionResult Index()
      {
         return View();
      }

      [HttpGet]
      public IActionResult Show()
      {
         var items = from e in _dbContext.Items select e;

         return Ok(items.ToList());
      }
      [HttpGet("{id}")]
      public IActionResult ShowOne(int id)
      {
         var item = (from e in _dbContext.Items where e.Id == id select e).FirstOrDefault();

         return Ok(item);
      }

      [HttpPost]
      public IActionResult Index(CompanyModel company)
      {
         var viewModel = new CompanyAddedViewModel
         {
            NumberOfCharsInName = company.Name.Length,
            NumberOfCharsInDescription = company.Name.Length,
            IsHidden = !company.IsVisible
         };

         var item = new ItemEntity
         {
            Name = company.Name,
            Description = company.Description,
            IsVisible = company.IsVisible

         };

         _dbContext.Items.Add(item);
         _dbContext.SaveChanges();

         return View("CompanyAdded", viewModel);
      }
   }
}
