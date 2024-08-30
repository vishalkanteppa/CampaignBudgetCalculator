namespace CampaignBudgetCalculator1.Models
{
    public class CampaignModel
    {
        public double TotalBudget { get; set; } // Z
        public double AgencyFeePercentage { get; set; } // Y1
        public double ThirdPartyToolFeePercentage { get; set; } // Y2
        public double FixedHoursCost { get; set; } // HOURS
        public double[] AdBudgets { get; set; } // X1, X2, ..., Xn
        public double TargetAdBudget { get; set; } // ad budget we're solving for

        public double CalculateTotalBudget()
        {
            double totalAdSpend = AdBudgets.Sum() + TargetAdBudget;
            double agencyFees = AgencyFeePercentage / 100 * totalAdSpend;
            double thirdPartyFees = ThirdPartyToolFeePercentage / 100 * totalAdSpend;
            return totalAdSpend + agencyFees + thirdPartyFees + FixedHoursCost;
        }
    }
}
