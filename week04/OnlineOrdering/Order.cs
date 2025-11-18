public class Order
{
    private Customer _customer; //create the customer
    private List<Product> _products = new List<Product>(); //create products list ordered by the customer

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;

    }


    public double CalculateTotalOrder()
    {
        double orderTotal = 0;
        int shippingCost = 0;
        foreach (Product product in _products)
        {
            orderTotal += product.CalculateTotalPrice();

        }
        if (_customer.IsInUsa() == true)
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }

        orderTotal += shippingCost;
        return orderTotal;


    }


    public string GetPackingLable()
    {
        string label = "PACKING LABEL\n";
        label += "-------------------------------------\n";

        foreach (Product product in _products)
        {
            label +=
                $"Name: {product.Getname()} \n" +
                $"Product Id: {product.GetId()} \n" +
                $"------------------------------------- \n";
        }

        return label;

    }

    public string GetShippingLabel()
    {
        string name = _customer.GetCustomerName();
        string address = _customer.GetAddress();
        string ShippingLabel =
            "SHIPPING LABEL\n" +
            "-------------------------------------\n" +
            $" Customer's name: {name}, full address: {address} \n" +
            $"-------------------------------------\n";
        return ShippingLabel;

    }


}