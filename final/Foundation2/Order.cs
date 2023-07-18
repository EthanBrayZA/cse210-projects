class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal CalculateTotalPrice()
    {
        decimal totalPrice = 0m;

        foreach (Product product in _products)
        {
            totalPrice += product.GetPrice();
        }

        totalPrice += _customer.IsInUSA() ? 5m : 35m; // Shipping cost

        return totalPrice;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (Product product in _products)
        {
            packingLabel += $"Product: {product.Name}, ID: {product.ProductId}\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = "Shipping Label:\n";
        shippingLabel += $"Name: {_customer.Name}\n";
        shippingLabel += _customer.GetAddress().GetFullAddress();
        return shippingLabel;
    }
}