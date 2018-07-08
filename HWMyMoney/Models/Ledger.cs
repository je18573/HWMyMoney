using HWMyMoney.Models.Enum;
using System;

namespace HWMyMoney.Models
{
    /// <summary>
    /// 記帳本
    /// </summary>
    public class Ledger
    {
        /// <summary>
        /// 類別
        /// </summary>
        public CategoryType Category { get; set; }

        /// <summary>
        /// 金額
        /// </summary>
        public decimal Money { get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// 備註
        /// </summary>
        public string Memo { get; set; }
    }
}