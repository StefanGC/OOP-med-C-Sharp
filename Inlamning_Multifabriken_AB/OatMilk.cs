class OatMilk : Product
{
    private int fatContent;
    private int litersAmount;

    public OatMilk (int fc, int la) {
        fatContent = fc;
        litersAmount = la;
    }

    public override void toString () {
        System.Console.WriteLine("  Havremjölk med fetthalt: " + fatContent + " och litermängd: " + litersAmount);
    }
}