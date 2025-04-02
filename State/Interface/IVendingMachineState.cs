namespace State.Interface;

public interface IVendingMachineState
{
    void InsertCoin();
    void SelectProduct();
    void Dispense();
}