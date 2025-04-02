using State.Class;
using State.Interface;

namespace State.Implementation;

public class DispensingState : IVendingMachineState
{
    private VendingMachine _machine;

    public DispensingState(VendingMachine vendingMachine)
    {
        _machine = vendingMachine;
    }
    public void InsertCoin()=>
        Console.WriteLine("You have inserted coin before");

    public void SelectProduct()=>
        Console.WriteLine("You have selected product before");

    public void Dispense()
    {
        Console.WriteLine("Product dispensing...");
        _machine.SetState(_machine.NoConinState);
    }
}