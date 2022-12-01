namespace DesignPatterns.Exercises.Basic.FactoryMethod.Products;

public sealed class PhoneProduct : Product
{
    public PhoneProduct(string type, string productDescription)
    {
        ProductDescription = productDescription;
        ProductType = type;
    }

    public override string ProductType { get; set; }
    public override string ProductDescription { get; set; }
}