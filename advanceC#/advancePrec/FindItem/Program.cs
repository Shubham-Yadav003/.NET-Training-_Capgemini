using System.Collections.Generic;
using System.Linq;
using System;
class Activity
{
    Dictionary<string, long> itemSoldCount = new Dictionary<string, long>()
{
    { "Burger", 150 },
    { "Pizza", 200 },
    { "Pasta", 95 },
    {"Mango", 200},
    {"Froot", 300}
};
    public SortedDictionary<String, long> FindItemDetails(long soldCount)
    {
        SortedDictionary<String, long> dict = new SortedDictionary<string, long>();
        foreach (var val in itemSoldCount)
        {
            if (val.Value == soldCount)
            {
                dict.Add(val.Key, val.Value);
            }
        }
        return dict;
    }

    public List<string> FindMinandMax()
    {
        long min = itemSoldCount.Values.Min();
        long max = itemSoldCount.Values.Max();
        List<string> list = new List<string>();

        string minItem = itemSoldCount.First(x => x.Value == min).Key;
        string maxItem = itemSoldCount.First(x => x.Value == max).Key;

        list.Add(minItem);
        list.Add(maxItem);
        return list;

        // foreach(var val in itemSoldCount)
        // {
        //     if(val.Value < minVal)
        //     {
        //         minVal = val.Value;
        //     }
        //     else if(val.Value > maxVal)
        //     {
        //         maxVal = val.Value;
        //     }
        // }
        // list.Add(minVal,maxval);

    }

    public Dictionary<string, long> Sorting()
    {
        return itemSoldCount
        .OrderBy(x => x.Value)
        .ToDictionary(x => x.Key, x => x.Value);
    }
}

class Program
{
    public static void Main()
    {
        Activity obj = new Activity();
        obj.FindItemDetails(200);
        obj.FindMinandMax();
        obj.Sorting();
    }
}