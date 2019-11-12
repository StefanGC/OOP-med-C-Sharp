class Tube : Product
{
    private double diameter;
    private double length;

    public Tube (double d, double l) {
        diameter = d;
        length = l;
    }

    public override void toString () {
        System.Console.WriteLine("  Rör med diameter: " + diameter + " och läng: " + length);
    }
}