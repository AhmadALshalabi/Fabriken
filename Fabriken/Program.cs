using Fabriken;
using System;
using System.Collections.Generic;

Warehouse warehouse = new Warehouse();
Machine machine = new Machine();

string[] menu = new string[5];
var amount = 0;
while (true)
{
    
    //Console.WriteLine(test);
    menu[0] = "Warehouse> ";
    menu[1] = $"1. Metal  ({warehouse.Metal.Count})";
    menu[2] = $"2. Glass  ({warehouse.Glass.Count})";
    menu[3] = $"3. Wood   ({warehouse.Wood.Count})";
    menu[4] = $"4. Rubber ({warehouse.Rubber.Count})";
    for (int i = 0; i < menu.Length; i++)
    {
        Console.WriteLine(menu[i]);
    }
    Console.WriteLine("Which material do you want to put in the warehouse? ");
    var choosing = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"You have choosed {menu[choosing]}");
    Console.Write($"How much you want to add to {menu[choosing]}? ");
    amount = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < amount; i++)
    {
        if (choosing == 1)
        {
            warehouse.Metal.Add(amount);
        }
        else if (choosing == 2)
        {
            warehouse.Glass.Add(amount);
        }
        else if (choosing == 3)
        {
            warehouse.Wood.Add(amount);
        }
        else if (choosing == 4)
        {
            warehouse.Rubber.Add(amount);
        }

    }

    foreach (var item in warehouse.Wheel1)
    {
        Console.WriteLine("Type someting plz: "+ item);
    }
    machine.Wheel();

}


