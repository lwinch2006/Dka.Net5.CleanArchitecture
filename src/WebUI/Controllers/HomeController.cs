using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class HomeController : WebUiControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}