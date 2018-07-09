using HWMyMoney.Models;
using System.Web.Mvc;

namespace HWMyMoney.Controllers
{
    public class LedgerController : Controller
    {
        // GET: Ledger
        public ActionResult Index()
        {
            var source = new LedgerService().LookupAllData();
            return View(source);
        }
    }
}