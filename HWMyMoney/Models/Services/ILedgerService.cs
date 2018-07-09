using System.Collections.Generic;

namespace HWMyMoney.Models.Services
{
    public interface ILedgerService
    {
        /// <summary>
        /// 取得所有記帳資料
        /// </summary>
        /// <returns></returns>
        IEnumerable<LedgerViewModel> LookupAllData();
    }
}
