namespace DesignPatterns.Exercises.Basic.FactoryMethod;

public class AirconditionerShop
{
    public IAirConditioner GetNewAirconditioner(ConditionerType type)
    {
        return type switch
        {
            ConditionerType.Cooling => new Cooler(),
            ConditionerType.Warming => new Heater(),
            _ => throw new ArgumentOutOfRangeException(nameof(type))
        };
    }
}

public class Heater : IAirConditioner
{
    public string GetAction()
    {
        return "Warming...";
    }
}

public class Cooler : IAirConditioner
{
    public string GetAction()
    {
        return "Cooling...";
    }
}