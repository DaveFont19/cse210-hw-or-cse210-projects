using System;

class Program
{
    static void Main(string[] args)
    {
        Order _order1 = new Order();
        _order1.CustomerInformation("David Fontes", "No street", "Zapopan", "jalisco", "Mexico");
        _order1.AddProduct(150, "Milk", 3.99, 4);
        _order1.AddProduct(125, "Eggs", 14.99, 2);
        _order1.DisplayInformation();
        _order1.DisplayOrder();
        _order1.DisplaySum();

        Order _order2 = new Order();
        _order2.CustomerInformation("Alonso Luna", "No street", "Los Angeles", "California", "USA");
        _order2.AddProduct(150, "Milk", 3.99, 4);
        _order2.AddProduct(125, "Eggs", 14.99, 2);
        _order2.DisplayInformation();
        _order2.DisplayOrder();
        _order2.DisplaySum();

    }
}