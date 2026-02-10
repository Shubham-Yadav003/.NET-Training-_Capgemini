public class BikeUtility
{

    public void AddBike(string model, string brand, int pricePerDay)
    {
        // Bike obj = new Bike();
        // obj.Model = model;
        // obj.Brand = brand;
        // obj.PricePerDay = pricePerDay;
        Bike obj = new Bike
        {
            Model = model,
            Brand = brand,
            PricePerDay = pricePerDay
        };

        Bike.dict.Add(Bike.dict.Count + 1, obj);

    }

    public SortedDictionary<string, List<Bike>> GroupBike()
    {
        SortedDictionary<string, List<Bike>> tempDict = new SortedDictionary<string, List<Bike>>();
        foreach (var elem in Bike.dict)
        {
            if (!tempDict.ContainsKey(elem.Value.Brand))
            {
                List<Bike> list = new List<Bike>();
                list.Add(elem.Value);
                tempDict.Add(elem.Value.Brand, list);
            }
            else
            {
                tempDict[elem.Value.Brand].Add(elem.Value);
            }
        }
        return tempDict;
    }
}