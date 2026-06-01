namespace green_interfaces;

public interface ICookable
{
    string GetCookingSuggestion();
}

public interface IWoodProducer
{
    string GetWoodUsage();
}

public abstract class Plants
{
    public Plants(string name, uint alter)
    {
        this.Name = name;
        this.Alter = alter;
    }

    public string Name
    {
        get;
        set;
    }

    public uint Alter
    {
        get; 
        set;
    }

    public string GetDescription()
    {
        return $"Name der Pflanze: {Name} \n Alter der Pflanze: {Alter}";
    }

}

public class Tree : Plants, IWoodProducer
{
    public Tree(string name, uint alter): base(name, alter){}
    public string GetWoodUsage()
    {
        return $"Das Holz der Pflanze {Name} ist verwendbar.";
    }
}

public class Vegetable : Plants, ICookable
{
    public Vegetable(string name, uint alter): base(name, alter){}
    public string GetCookingSuggestion()
    {
        return $"Die Pflanze {Name} ist essbar.";
    }
}

public class EatibleTree : Plants, ICookable, IWoodProducer
{
    public EatibleTree(string name, uint alter) : base(name, alter){}
    public string GetWoodUsage()
    {
        return $"Das Holz der Pflanze {Name} ist verwendbar.";
    }
    public string GetCookingSuggestion()
    {
        return $"Die Früchte des Baumes {Name} ist essbar.";
    }
}

public class AppleTree : EatibleTree
{
    public AppleTree(string name, uint alter) : base(name, alter){}

}

public class Pumpkin : Vegetable
{
    public Pumpkin(string name, uint alter) : base(name, alter){}
}

public class ChestnutTree : Tree
{
    public ChestnutTree(string name, uint alter) : base(name, alter){}
}
