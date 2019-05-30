using System;
using Microsoft.AspNetCore.Mvc;
using Virtuous.Pages.Models;

namespace Virtuous
{
    [Route("api/[controller]/[action]")]
    public class DonationsController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Gift(decimal giftAmount, DateTime? giftDate, bool recurring)
        {
            var giftAsk = new GiftAskModel();

            giftAsk.IsRecurring = recurring;
            giftAsk.RecurringStartDate = giftDate;
            giftAsk.GiftAskAmount = GetGiftAskAmount(giftAmount);

            // Maybe do some EF database saving or other logic

            return PartialView("_GiftAsk", giftAsk);
        }

        private decimal GetGiftAskAmount(decimal giftAmount)
        {
            var giftAskAmount = Math.Round(giftAmount + (giftAmount * 15/100));
            
            return giftAskAmount;
        }

        [HttpPost]
        public GiftAskModel GiftConfirmation(decimal giftAskAmount, DateTime? giftRecurringStartDate, string recurringInterval)
        {
            var giftAsk = new GiftAskModel();

            giftAsk.GiftAskAmount = giftAskAmount;
            if(recurringInterval != null || recurringInterval != "")
            {
                giftAsk.RecurranceIntreval = recurringInterval;
                giftAsk.RecurringStartDate = giftRecurringStartDate;
            }

            // Save to database with automapper and EF

            return giftAsk;
        }
    }
}
