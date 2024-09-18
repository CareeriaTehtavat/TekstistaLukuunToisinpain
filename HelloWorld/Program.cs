namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Koodi tähän
            string teksti = "1";
            int luku;

            luku = int.Parse(teksti);
            Console.WriteLine(teksti + teksti);
            Console.WriteLine(luku + luku);

            string teksti2;

            teksti2 = Convert.ToString(luku);

            Console.WriteLine(teksti2 + teksti2);

        }
    }
}