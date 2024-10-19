using System;

public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public string GetNameAndId()
    {   
        return $"Product Name: {_name} | Product ID: {_productId}";
    }
    
    public double TotalCost()
    {
        double total = _price * _quantity;

        return total;
    }
}