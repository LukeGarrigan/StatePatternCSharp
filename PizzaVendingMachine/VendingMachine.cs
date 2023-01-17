namespace PizzaVendingMachine;

public class VendingMachine
{
    public IState NotSelected;
    public IState AwaitingPayment;
    public IState Sold;
    public IState SoldOut;
    
    public IState State { get; set; }

    public int Pizzas { get; }
    
    public VendingMachine(int pizzas)
    {
        NotSelected = new NotSelectedState(this);
        AwaitingPayment = new AwaitingPaymentState(this);
        Sold = new SoldState(this);
        SoldOut = new SoldOutState(this);
        
        Pizzas = pizzas;
        State = NotSelected;
    }

    public void SelectPizza()
    {
        State.SelectPizza();
    }
    
    public void DeselectPizza()
    {
        State.DeselectPizza();
    }
    
    public void TapCard()
    {
        State.TapCard();
    }

    public void Dispense()
    {
        State.Dispense();
    }
}