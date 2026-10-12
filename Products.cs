class Products
{
    public int Id;
    public string Name;
    public decimal Price;
    public int Quantity;

   public Products(int productId, string productName, decimal productPrice, int productQuantity)
    {
        Id = productId;
        Name = productName;
        Price = productPrice;
        Quantity = productQuantity;
    }

    public void ViewProduct()
    {
        Console.WriteLine($"Product Id: {Id}");
        Console.WriteLine($"Product Name: {Name}");
        Console.WriteLine($"Product Price: {Price}");
        Console.WriteLine($"Product Quantity: {Quantity}");
        
    }
}
