public class Product
{
    private int productId;
    protected string productName;
    private protected double cost;
    internal string description;
    protected internal string manufacturer;
    public int quantityInStock;
}

// Child class in the same assembly/project
public class  DomesticProdut : Product
{
    public void Method1()
    {
        productId; // Not Accessible
        productName = "abc"; // Accessible
        cost = 1; // Accessible
        description = "Domestic Product"; // Accessible
        manufacturer = "Domestic Manufacturer"; // Accessible
        quantityInStock = 100; // Accessible
    }
}

// Other class in the same assembly/project
public class OtherClass
{
    public void Method1()
    {
        Product product1 = new Product();
        product1.productId; // Not Accessible
        product1.productName; // Not Accessible
        product1.cost; // Not Accessible
        product1.description = "Other Class Product"; // Accessible
        product1.manufacturer = "Other Class Manufacturer"; // Accessible
        product1.quantityInStock = 50; // Accessible
    }

}