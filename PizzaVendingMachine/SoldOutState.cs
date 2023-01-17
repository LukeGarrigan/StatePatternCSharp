namespace PizzaVendingMachine;

public class SoldOutState : IState
{
    private readonly VendingMachine _vendingMachine;

    public SoldOutState(VendingMachine vendingMachine)
    {
        _vendingMachine = vendingMachine;
    }
    
    public void SelectPizza()
    {
        Console.WriteLine("Sorry we're out of pizzas!");
    }

    public void DeselectPizza()
    {
        Console.WriteLine("Sorry we're out of pizzas!");
    }

    public void TapCard()
    {
        Console.WriteLine("Sorry we're out of pizzas!");
    }

    public void Dispense()
    {
        Console.WriteLine("Sorry we're out of pizzas!");
    }
}