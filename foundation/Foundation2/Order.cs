using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public double TotalCost()
    {
        // Determining the shipping cost
        int shippingCost;

        if (_customer.InUSA())
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }

        // Computing the total cost of the products
        double totalProductsCost = 0;

        foreach (Product product in _products)
        {
            totalProductsCost += product.TotalCost();
        }

        // Computing the total cost of the order
        double totalCost = shippingCost + totalProductsCost;

        return totalCost;
    }

    public string PackingLabel()
    {
        string packingLabel = "";
        
        for (int i = 0; i < _products.Count; i++)
        {
            packingLabel += $"{i+1}. {_products[i].GetNameAndId()}\n";
        }
        
        return packingLabel;
    }

    public string ShippingLabel()
    {
        string shippingLabel = _customer.GetNameAndAddress();
        
        return shippingLabel;
    }
}