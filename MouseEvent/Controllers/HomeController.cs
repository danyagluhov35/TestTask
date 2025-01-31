using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using MouseEvent.DOMAIN.Models;
using MouseEvent.IService;

namespace MouseEvent.Controllers
{
    public class HomeController : Controller
    {
        private IMouseService MouseService;

        public HomeController(IMouseService mouseService)
        {
            this.MouseService = mouseService;
        }
        public async Task<IActionResult> Index()
        {
            return View();
        }
        public async Task<IActionResult> SaveData([FromBody] MouseDataItemModel mouseData)
        {
            await MouseService.SaveToJson(mouseData);
            return View();
        }
    }
}
