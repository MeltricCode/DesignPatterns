using State.Class;
using State.Interface;

namespace State.Implementation;

public class HasCoinState : IVendingMachineState
{
    private VendingMachine _machine;
    public HasCoinState(VendingMachine vendingMachine)
    {
        _machine = vendingMachine;
    }
    public void InsertCoin()=>
        Console.WriteLine("You have inserted coin before");
    

    public void SelectProduct()
    {
        Console.WriteLine("Product selected");
        _machine.SetState(_machine.DispensingState);
    }

    public void Dispense()=>
        Console.WriteLine("First select product");
}