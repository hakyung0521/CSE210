using BYUI.InheritanceExamples;

Customer John = new Customer("John Smith");
John.Purchase(50.00);
John.Getinfo();
Console.WriteLine(John.Name);

Dealer Ace = new Dealer("Ace Hardware", 12345678, 0.05);
Ace.Purchase(50.00);
Ace.Getinfo();
Console.WriteLine(Ace.Name);
Console.WriteLine(Ace.DealerId);
Console.WriteLine(Ace.Discount);






