
using UnityEngine;

public class BookStore : MonoBehaviour
{   //use decimals instead of floats for more accuracy
    public float coverPriceX; //except here, decimal is not a serializable type
    public int copiesY;
    public int storeDiscount = 40;
    public decimal intialCost = 3m;
    public decimal additionalCost = 0.75m;

    void Start()
    {
        decimal coverPrice = (decimal)coverPriceX; //convert to decimal
        //Determine cost
        decimal cost = CostCalculator(copiesY,WholesaleDiscount(coverPrice,storeDiscount),intialCost,additionalCost);
        //determine profit
        ProfitCalculator(cost,copiesY,coverPrice);
    }

    private decimal ProfitCalculator(decimal cost,int copies,decimal coverPrice)
    {
        decimal profit =(copies*coverPrice) - cost;
        Debug.Log("Profit: " + profit.ToString()); //print
        return profit; // could be void as well
    }

    private decimal CostCalculator(int copies,decimal storePrice, decimal intialC, decimal additionalC)
    {
        decimal cost = (copies*storePrice)+intialC; 
        if(copies>1) // if more than one
        {
            cost += (copies - 1)*additionalC; //add additional cost MINUS one to not overcharge
        }

        Debug.Log("Cost: " +cost.ToString()); //print
        return cost;
    }

    private decimal WholesaleDiscount(decimal price, int storeDiscount)
    {
        price -= (price*(storeDiscount*0.01m)); // converts discount to a tenth so it can be multiplied
        return price;
    }

}
