namespace PizzaVendingMachine;

public class SoldState : IState
{
    private readonly VendingMachine _vendingMachine;

    public SoldState(VendingMachine vendingMachine)
    {
        _vendingMachine = vendingMachine;
    }
    
    public void SelectPizza()
    {
        Console.WriteLine("You've already bought a pizza, hold on whilst we dispense it!");
    }

    public void DeselectPizza()
    {
        Console.WriteLine("You've already bought a pizza, hold on whilst we dispense it!");
    }

    public void TapCard()
    {
        Console.WriteLine("You've already bought a pizza, hold on whilst we dispense it!");
    }

    public void Dispense()
    {
        Console.WriteLine("Dispensing your pizza!");
        if (_vendingMachine.Pizzas > 0)
        {
            _vendingMachine.State = _vendingMachine.NotSelected;
        }
        else
        {
            _vendingMachine.State = _vendingMachine.SoldOut;
        }

    }
}