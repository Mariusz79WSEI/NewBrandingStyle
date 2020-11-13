using Microsoft.AspNetCore.Mvc;
using NewBrandingStyle.Web.Models;

namespace NewBrandingStyle.Web.Controllers
{
   [ApiController]
   [Route("api/[controller]")]
   public class CompanyAjaxController : ControllerBase
   {
      public CompanyModel Post()
      {
         var item = new CompanyModel();
         item.Name = "Kowalski";
         return item;
      }
   }
}
