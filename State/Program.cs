
using State.Class;


// State Pattern:
// Enables an object to alter its behavior dynamically based on its internal state.  
// It replaces complex conditional logic (if-else/switch) with state-specific implementations,  
// making the code more maintainable, scalable, and easier to extend.

var vendingMachine = new VendingMachine();

vendingMachine.SelectProduct(); // First insert the coin
vendingMachine.InsertCoin();    // Coin Inserted
vendingMachine.SelectProduct(); // Product selected
vendingMachine.Dispense();      // Product dispensing...

vendingMachine.Dispense();      // First insert the coin