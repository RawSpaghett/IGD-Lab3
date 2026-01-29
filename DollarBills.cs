using UnityEngine;

public class DollarBills : MonoBehaviour
{
    public int dollars;

    void Start()
    {
        dollars = Hundreds(dollars);
        dollars = Fiftys(dollars);
        dollars = Twentys(dollars);
        dollars = Tens(dollars);
        dollars = Fives(dollars);
        dollars = Ones(dollars);
    }

    public int Ones(int dollars)
    {
        int ones = 0; //set initial number of ones to zero
    
        if(dollars >= 1) // if there is at least one one
        {
        ones = dollars / 1;  // determine amount of ones
        dollars -= (ones*1); // set new amount to be equal to the amount minus all of the ones
        }
        Debug.Log("Ones: " + ones);  //print number of ones
        return dollars; // return for next logic, none in this case.
        
    }

    public int Fives(int dollars)
    {
        int fives = 0;
    
        if(dollars >= 5)
        {
        fives = dollars / 5; 
        dollars -= (fives*5);
        }
        Debug.Log("Fives: " + fives); 
        return dollars;
    }

    public int Tens(int dollars)
    {
        int tens = 0;
    
        if(dollars >= 10)
        {
        tens = dollars / 10; 
        dollars -= (tens*10);
        }
        Debug.Log("Tens: " + tens); 
        return dollars;
    }

    public int Twentys(int dollars)
    {
        int twentys = 0;
    
        if(dollars >= 20)
        {
        twentys = dollars / 20; 
        dollars -= (twentys*20);
        }
        Debug.Log("Twentys: " + twentys); 
        return dollars;
    }

    public int Fiftys(int dollars)
    {
        int fiftys = 0;
    
        if(dollars >= 50)
        {
        fiftys = dollars / 50; 
        dollars -= (fiftys*50);
        }
        Debug.Log("Fiftys: " + fiftys); 
        return dollars;
    }

    public int Hundreds(int dollars)
    {
        int hundreds = 0;
    
        if(dollars >= 100)
        {
        hundreds = dollars / 100; 
        dollars -= (hundreds*100);
        }
        Debug.Log("Hundreds: " + hundreds);
        return dollars;
        
    }
}
