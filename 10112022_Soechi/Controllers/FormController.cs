using _10112022_Soechi.Data;
using _10112022_Soechi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace _10112022_Soechi.Controllers
{
    public class FormController : Controller
    {
        private readonly SoechiContext _soechicontext;
        FormModel formModel = new FormModel();
        public FormController(SoechiContext soechicontext)
        {
            _soechicontext = soechicontext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            formModel = new FormModel();
            formModel.Rate = null;
            formModel.QTY = null;
            getddluom();
            return View(formModel);
        }

        public void getddluom() {
            var uomddl = _soechicontext.UOM.Select(x => new ItemList { ID = x.UOMRate, Name = x.UOMName}).ToList();
            formModel.uoms = uomddl;
        }

        [HttpPost]
        public IActionResult Index(int value) {

            var uomSelected = _soechicontext.UOM.FirstOrDefault(x=> x.UOMID == 1);
            formModel.Rate = uomSelected == null? 0: uomSelected.UOMRate ;
            return View();
        }
    }
}
