using Microsoft.AspNetCore.Mvc;
using NewBrandingStyle.Web.Models;

namespace NewBrandingStyle.Web.Controllers
{
   public class CompanyController : Controller
   {
      [HttpGet]
      public IActionResult Index()
      {
         return View();
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
         return View("CompanyAdded", viewModel);
      }
   }
}
