using Microsoft.AspNetCore.Mvc;
using Antra.CRMApp.WebMVC.Models;
using Antra.CRMApp.Infrastructure.Data;

namespace Antra.CRMApp.WebMVC.Controllers
{
    public class VendorController : Controller
    {
        private readonly CrmDbContext _db;

        public VendorController(CrmDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {   
            var objVendorList = _db.Vendor.ToList();
            return View();
        }
    }
}
