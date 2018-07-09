using HWMyMoney.Models.Services;
using System.Web.Mvc;

namespace HWMyMoney.Controllers
{
    public class LedgerController : Controller
    {
        private readonly ILedgerService _ledgerService;

        public LedgerController()
        {
            _ledgerService = new LedgerService();
        }

        // GET: Ledger
        public ActionResult Index()
        {
            var source = _ledgerService.LookupAllData();
            return View(source);
        }
    }
}