
using TemplateMethod.Abstract;
using TemplateMethod.Implementation;


// Template Method Pattern:
// Defines the skeleton of an algorithm in an abstract class and lets subclasses override specific steps.
// This pattern ensures that the structure of the algorithm remains unchanged while allowing customization of individual operations.
// It's a behavioral pattern and is useful when multiple classes share the same algorithm structure with some variation in the steps.

ReportGenerator saleReport  = new SaleReport();
saleReport.GenerateReport();

ReportGenerator inventoryReport  = new InventoryReport();
inventoryReport.GenerateReport();