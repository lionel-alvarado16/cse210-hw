using System;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetNameAndAddress()
    {   
        return $"Name: {_name}\nAddress:\n{_address.DisplayAddress()}";
    }

    public bool InUSA()
    {
        if (!_address.InUnitedStates())
        {
            return false;
        }

        return true;
    }
}