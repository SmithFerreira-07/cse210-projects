using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;
    private double _shippCostUSA = 5.0;
    private double _shippCostInternational = 35.0;

    public Order (Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    public double GetTotalPrice()
    {
        double totalCost = 0;
        foreach (var product in _products)
        {
            totalCost += product.CalculateCost();
        }

        if (_customer.IsInUSA() == true)
        {
            return totalCost + _shippCostUSA;
        } else
        {
            return totalCost + _shippCostInternational;
        }
    }

}