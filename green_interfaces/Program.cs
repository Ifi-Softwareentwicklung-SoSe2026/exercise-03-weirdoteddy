using green_interfaces;

var plants = new List<Plants>
{
    new AppleTree("Boskoop", alter: 5),
    new Pumpkin("Hokkaido", alter: 1),
    new ChestnutTree("Maroni", alter: 12)
};

foreach (var plant in plants)
{
    Console.WriteLine(plant.GetDescription());

    if (plant is ICookable cookable)
    {
        Console.WriteLine($"  -> Kochbar: {cookable.GetCookingSuggestion()}");
    }

    if (plant is IWoodProducer woodProducer)
    {
        Console.WriteLine($"  -> Holz nutzbar: {woodProducer.GetWoodUsage()}");
    }
}
