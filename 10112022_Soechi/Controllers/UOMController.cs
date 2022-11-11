using _10112022_Soechi.Data;
using _10112022_Soechi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _10112022_Soechi.Controllers
{
    public class UOMController : Controller
    {
        private readonly SoechiContext _soechicontext;

        public UOMController(SoechiContext soechicontext)
        {
            _soechicontext = soechicontext;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var _uoms = await _soechicontext.UOM.ToListAsync();
            return View(_uoms);
        }
    }
}
