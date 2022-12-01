using DesignPatterns.Exercises.Basic.FactoryMethod.Products;

namespace DesignPatterns.Exercises.Basic.FactoryMethod;

public static class Program
{
    public static void Main(string[] args)
    {
        new Client().Run();
    }
}

// TODO: implement the factory method pattern in the client class so it's not dependent on 
// object construction, and that the client is able to work with any given generalized product
public class Client
{
    public void Run()
    {
        var product = new PhoneProduct(); 
        Console.WriteLine(product.ProductDescription);
    }
}