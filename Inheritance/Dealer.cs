namespace BYUI.InheritanceExamples;

class Dealer : Customer
{
    public long DealerId { get; set; }
    public double Discount { get; set; }
    
    public Dealer(string name, long dealerId, double discount) : base(name)
    {
        DealerId = dealerId;
        Discount = discount;
    }

    /// extand getinfo..
    public override void Getinfo()
    {
        base.Getinfo();
        //Console.WriteLine($"My name is {name}")
        Console.WriteLine($"My Dealer ID is {DealerId} and my discount is {Discount}");
    }

}