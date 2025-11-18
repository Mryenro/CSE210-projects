public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }



    public bool IsInUsa()
    {
        return _address.UsaCheck();
    }

    public string GetCustomerName()
    {
        return _name;
    }

    public string GetAddress()
    {
        return _address.FullAddressDisplay();
    }



}

