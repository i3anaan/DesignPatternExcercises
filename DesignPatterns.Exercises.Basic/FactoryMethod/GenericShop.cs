using System.Text;
using DesignPatterns.Exercises.Basic.FactoryMethod.Products;

namespace DesignPatterns.Exercises.Basic.FactoryMethod;

public class GenericShop
{
    private readonly IList<Product> _inventory = new List<Product>();
    
    public void AddPhoneToInventory()
    {
        _inventory.Add(new PhoneProduct("Phone", "iPhone 10"));
        _inventory.Add(new PhoneProduct("Phone", "Samsung Galaxy A53"));
    }

    public string PrintInventory()
    {
        var sb = new StringBuilder();
        sb.AppendLine("*** shop inventory ***");
        sb.AppendLine("");

        foreach (var item in _inventory)
        {
            sb.AppendLine($"Product type: {item.ProductType}, product description: {item.ProductDescription}");
        }

        return sb.ToString();
    }
}