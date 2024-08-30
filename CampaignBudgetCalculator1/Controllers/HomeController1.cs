using Microsoft.AspNetCore.Mvc;
using CampaignBudgetCalculator1.Models;
using CampaignBudgetCalculator1.Models;

namespace CampaignBudgetCalculator1.Controllers
{
    public class CampaignController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new CampaignModel());
        }

        [HttpPost]
        public IActionResult Index(CampaignModel model)
        {
            if (!string.IsNullOrEmpty(Request.Form["AdBudgets"]))
            {
                var adBudgetsString = Request.Form["AdBudgets"].ToString();

                string[] adBudgetStrings = adBudgetsString.Split(',');

                List<double> adBudgetList = new List<double>();

                foreach (string str in adBudgetStrings)
                {
                    string trimmedString = str.Trim();

                    // parse the trimmed substring as a double
                    bool isParsed = double.TryParse(trimmedString, out double result);
                    if (isParsed)
                    {
                        adBudgetList.Add(result);
                    }
                    else
                    {
                        adBudgetList.Add(0);
                    }
                }

                double[] adBudgets = adBudgetList.ToArray();

                model.AdBudgets = adBudgets;

            }

            // binary search iterative approach to find max TargetAdBudget that fits the TotalBudget
            double low = 0;
            double high = model.TotalBudget;

            while (high - low > 0.01) // if difference is kept at 0 it enters infinite loop hence 0.01
            {
                double mid = (low + high) / 2;
                model.TargetAdBudget = mid;

                double calculatedBudget = model.CalculateTotalBudget();

                if (calculatedBudget > model.TotalBudget)
                {
                    high = mid;
                }
                else
                {
                    low = mid;
                }
            }

            model.TargetAdBudget = Math.Round(low, 2); // budget found
            ViewBag.Result = model.TargetAdBudget;

            return View(model);
        }
    }
}
