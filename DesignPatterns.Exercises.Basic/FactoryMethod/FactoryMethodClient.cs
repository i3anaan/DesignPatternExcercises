namespace DesignPatterns.Exercises.Basic.FactoryMethod;

// TODO: implement the factory method pattern in the client class so it's not dependent on 
// object construction, and that the client is able to work with any given generalized product
public class FactoryMethodClient
{
    public void Run()
    {
        var shop = new AirconditionerShop();
        var airco = shop.GetNewAirconditioner(ConditionerType.Warming);
        Console.WriteLine(airco.GetAction());
        
        airco = shop.GetNewAirconditioner(ConditionerType.Cooling);
        Console.WriteLine(airco.GetAction());
    }
}