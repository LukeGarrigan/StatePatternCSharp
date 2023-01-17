// See https://aka.ms/new-console-template for more information

using PizzaVendingMachine;

Console.WriteLine("Hello, World!");


var vendingMachine = new VendingMachine(3);

vendingMachine.SelectPizza();
vendingMachine.DeselectPizza();
vendingMachine.SelectPizza();
vendingMachine.TapCard();
vendingMachine.Dispense();
