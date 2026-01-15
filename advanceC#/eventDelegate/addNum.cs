using System;

class AddTwoNumber
{
    public delegate void dg_OddNumber(); // declared decleration
    public event dg_OddNumber ev_OddNumber; // declared event

   

    public void Add()
    {
        int result;
        result = 5 + 5;
        Console.WriteLine(result.ToString());
        if ((result % 2 != 0) && (ev_OddNumber != null)) // check if someone tried to subscribe
        { 
            ev_OddNumber(); // raised event
        }
    }

    
}