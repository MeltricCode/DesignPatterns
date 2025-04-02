using State.Class;
using State.Interface;

namespace State.Implementation;

public class NoCoinState: IVendingMachineState
{
    private VendingMachine _machine;
    public NoCoinState(VendingMachine vendingMachine)
    {
        _machine = vendingMachine;
    }
    public void InsertCoin()
    {
        Console.WriteLine("Coin Inserted");
        _machine.SetState(_machine.HasConinState);
    }

    public void SelectProduct()=>
        Console.WriteLine("First insert the coin");
    

    public void Dispense() =>
        Console.WriteLine("First insert the coin");
    
}