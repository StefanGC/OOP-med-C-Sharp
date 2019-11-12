class Candy : Product
{
    private string taste;
    private int quantity;

    public Candy (string t, int q) {
        taste = t;
        quantity = q;
    }

    public override void toString () {
        System.Console.WriteLine("  Godis med smak: " + taste + " och antal: " + quantity);
    }
}