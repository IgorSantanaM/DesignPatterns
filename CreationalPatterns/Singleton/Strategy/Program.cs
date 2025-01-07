using StrategyPattern;
using StrategyPattern.Strategies;

ShoppingCart context = new();

context.SetStrategy(new CreditCardStrategy(
    name: "Igor Santana",
    cardNumber: "1234567890123456",
    cvv: "698",
    dateOfExpiry: "01/28"
    ));

context.Checkout(100.50m);

context.SetStrategy(new PayPalStrategy(
    email: "igor@santana.com",
    password: "mypasswordofcourse"));

context.Checkout(1m);

context.SetStrategy(new BankTransferStrategy(
    bankName: "igorsbank",
    accountNumber: "cool123"));

context.Checkout(1m);