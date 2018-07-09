using HWMyMoney.Models.Enum;
using System;
using System.ComponentModel.DataAnnotations;

namespace HWMyMoney.Models
{
    /// <summary>
    /// 記帳本
    /// </summary>
    public class LedgerViewModel
    {
        /// <summary>
        /// 類別
        /// </summary>
        public CategoryType Category { get; set; }

        /// <summary>
        /// 金額
        /// </summary>
        [DisplayFormat(DataFormatString = "{0:n0}")]
        public decimal Money { get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime Date { get; set; }

        /// <summary>
        /// 備註
        /// </summary>
        public string Memo { get; set; }
    }
}