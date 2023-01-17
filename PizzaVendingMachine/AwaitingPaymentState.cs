namespace PizzaVendingMachine;

public class AwaitingPaymentState : IState
{
    private readonly VendingMachine _vendingMachine;

    public AwaitingPaymentState(VendingMachine vendingMachine)
    {
        _vendingMachine = vendingMachine;
    }
    
    public void SelectPizza()
    {
        Console.WriteLine("You must first deselect your current pizza");
    }

    public void DeselectPizza()
    {
        Console.WriteLine("Deselected your pizza");
    }

    public void TapCard()
    {
        _vendingMachine.State = _vendingMachine.Sold;
        Console.WriteLine("Congratulations, you've bought a pizza!");
    }

    public void Dispense()
    {
        Console.WriteLine("You need to pay before we dispense your pizza!");
    }
}