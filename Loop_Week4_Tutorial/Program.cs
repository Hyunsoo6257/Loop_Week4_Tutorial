namespace Loop_Week4_Tutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SumFiveInts();
        }

        static void SumFiveInts() { 
            for (int i = 0; i < 5; i++) {
                int sum;
                Console.WriteLine("Enter integer: ");
                sum = Convert.ToInt32(Console.ReadLine());

            }
            // Answer (using While)
            /*
                int i =0, number =0;
                while (i<5)
                {
                    Console.Write("Enter an Integar: ")
                    number = Convert.ToInt32(Console.ReadLine());
                    sum += number; => sum = sum+ number;
                }
                Console.WriteLine("The sum of 5 numbers i ={0}",sum)

            */
            /*
                sum=0;
                for(i=0; i<5; i++)
                {
                    Console.Write("Enter an Integar: ")
                    number = Convert.ToInt32(Console.ReadLine());
                    sum += number; => sum = sum+ number;
                }
                Console.WriteLine("The sum of 5 numbers i ={0}",sum)
            */

        }
    }
}
