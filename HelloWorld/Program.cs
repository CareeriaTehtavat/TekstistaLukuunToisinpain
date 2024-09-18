namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Koodi tähän
            int luku1 = 5;
            int luku2 = 10;
            int luku3 = 19;

            double summa = luku1 + luku2 + luku3;

            double keskiarvo = summa / 3;

            Console.WriteLine("Lukujen: " + luku1 + " " + luku2 + " ja " + luku3 + " summa on: "
                + summa + " ja keskiarvo on: " + keskiarvo + "   ");

        }
    }
}
