namespace AsalSayiBulma
{
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Hello, World!");
    //    }
    //}
    public class Program
    {
        static void Main(string[] args)
        {
            int sayi = Convert.ToInt32(Console.ReadLine());
            bool a = Asal(sayi);
            if (a)
            {
                Console.WriteLine("Bu sayi asal");
                List<int> sayilar = BesAsal(sayi);
            }
            else
            {
                Console.WriteLine("Bu sayi asal değil");
            }
        }
        static bool Asal(int sayi)
        {
            int ipucu = 0;
            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    ipucu++;
                }
            }
            if (ipucu == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        static List<int> BesAsal(int sayi)
        {
            List<int> list = new List<int>();
            int depo = 0;
            for (int i = sayi + 1; i < 1000; i++)
            {
                int ipucu = 0;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        ipucu++;
                        break;
                    }
                }
                if (ipucu == 0)
                {
                    Console.WriteLine(i);
                    depo++;
                    list.Add(i);

                }
                if (depo == 5)
                {
                    break;
                }
            }
            return list;
        }
    }
}