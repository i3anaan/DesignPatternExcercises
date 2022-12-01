using DesignPatterns.Exercises.Basic.FactoryMethod.Products;

namespace DesignPatterns.Exercises.Basic.FactoryMethod;

// TODO: implement the factory method pattern in the client class so it's not dependent on 
// object construction, and that the client is able to work with any given generalized product
public class FactoryMethodClient
{
    public void Run()
    {
        var shop = new GenericShop();
        shop.AddPhoneToInventory();

        Console.WriteLine(shop.PrintInventory());
    }
}