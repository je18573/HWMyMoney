using System.ComponentModel.DataAnnotations;

namespace HWMyMoney.Models.Enum
{
    public enum CategoryType
    {
        /// <summary>
        /// 支出
        /// </summary>
        [Display(Name = "支出")]
        Expenditure = 1,

        /// <summary>
        /// 收入
        /// </summary>
        [Display(Name = "收入")]
        Income = 2
    }
}