namespace PizzaVendingMachine;

public interface IState
{
    public void SelectPizza();
    public void DeselectPizza();
    public void TapCard();
    public void Dispense();
}