class Car : Product
{
    private string registrationNumber;
    private string color;       //TODO Färgen måste välja från listan
    private string carBrand;    //TODO Märke måste välja från listan

    public Car (string rn, string c, string cb) {
        registrationNumber = rn;
        color = c;
        carBrand = cb;
    }

    public override void toString () {
        System.Console.WriteLine("  Bil med registreringsskylt: " + registrationNumber + ", färg: " + color + " och bilmärke: " + carBrand);
    }
}