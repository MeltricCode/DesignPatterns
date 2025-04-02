using State.Implementation;
using State.Interface;

namespace State.Class;

public class VendingMachine
{
    public IVendingMachineState NoConinState { get; }
    public IVendingMachineState HasConinState { get; }
    public IVendingMachineState DispensingState  { get; }
    
    private IVendingMachineState _currentState;

    public VendingMachine()
    {
        NoConinState = new NoCoinState(this);
        HasConinState = new HasCoinState(this);
        DispensingState = new DispensingState(this);
        
        _currentState = NoConinState;
    }
    
    public void SetState(IVendingMachineState state) => _currentState = state;
    public void InsertCoin() => _currentState.InsertCoin();
    public void SelectProduct() => _currentState.SelectProduct();
    public void Dispense() => _currentState.Dispense();
}