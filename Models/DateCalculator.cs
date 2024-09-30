namespace DateNight.Models;

public class DateCalculator
{
    public string CoffeeCost { get; set; }
    public string DinnerCost { get; set; }
    public string MovieCost { get; set; }

    public string GetTotalCost()
    {
        decimal decCoffee, decDinner, decMovie;

        if (!Decimal.TryParse(CoffeeCost, out decCoffee))
        {
            if (!String.IsNullOrEmpty(CoffeeCost))
            {
                throw new Exception("Invalid coffee cost.");
            }
        }
        
        if (!Decimal.TryParse(DinnerCost, out decDinner))
        {
            if (!String.IsNullOrEmpty(DinnerCost))
            {
                throw new Exception("Invalid dinner cost.");
            }
        }
        
        if (!Decimal.TryParse(MovieCost, out decMovie))
        {
            if (!String.IsNullOrEmpty(MovieCost))
            {
                throw new Exception("Invalid movie cost.");
            }
        }
        
        return (decCoffee + decDinner + decMovie).ToString("c");
    }
    
}