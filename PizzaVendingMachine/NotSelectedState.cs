namespace PizzaVendingMachine;

public class NotSelectedState : IState
{
    private readonly VendingMachine _vendingMachine;

    public NotSelectedState(VendingMachine vendingMachine)
    {
        _vendingMachine = vendingMachine;
    }
    
    public void SelectPizza()
    {
        _vendingMachine.State = _vendingMachine.AwaitingPayment;
        Console.WriteLine("You have selected a pizza, please tap your card!");
    }

    public void DeselectPizza()
    {
        Console.WriteLine("You haven't selected a pizza yet");
    }

    public void TapCard()
    {
        Console.WriteLine("You haven't selected a pizza yet");
    }

    public void Dispense()
    {
        Console.WriteLine("You haven't selected a pizza yet");
    }
}