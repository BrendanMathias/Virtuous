using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Virtuous.Pages.Models
{
    public class GiftModel
    {
        public decimal? GiftAmount { get; set; }
        public DateTime? GiftDate { get; set; }
        public bool? Recurring { get; set; }
    }
}
