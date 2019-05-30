using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Virtuous.Pages.Models
{
    public class GiftAskModel
    {
        public decimal? GiftAskAmount { get; set; }
        public bool IsRecurring { get; set; }
        public string RecurranceIntreval { get; set; }
        public DateTime? RecurringStartDate { get; set; }
    }
}
