using HWMyMoney.Models;
using System.Web.Mvc;

namespace HWMyMoney.Controllers
{
    public class LedgerController : Controller
    {
        // GET: Ledger
        public ActionResult Index()
        {
            return View(new LedgerViewModel());
        }
    }
}