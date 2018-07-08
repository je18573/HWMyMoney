using System;
using System.Collections.Generic;
using HWMyMoney.Models.Enum;

namespace HWMyMoney.Models
{
    public class LedgerViewModel
    {
        public LedgerViewModel()
        {
            #region ===產生假資料===
            var fakeList = new List<Ledger>();
            var random = new Random();

            for (var i = 1; i <= 50; i++)
            {
                var fakeData = new Ledger
                {
                    Category = random.Next(1, 100) % i == 0? CategoryType.Expenditure : CategoryType.Income,
                    Money = random.Next(0, 100000),
                    Date = DateTime.Now.AddDays(-random.Next(0, 100)).AddMinutes(random.Next(0, 60)),
                    Memo = $"fake memo {i}"
                };
                fakeList.Add(fakeData);
            }
            #endregion

            LedgerList = fakeList;
        }

        public List<Ledger> LedgerList { get; set; }
    }
}