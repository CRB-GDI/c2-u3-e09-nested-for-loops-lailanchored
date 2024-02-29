namespace Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What Row Width");
            int rowWidth = int.Parse(Console.ReadLine());

            Console.WriteLine("How many Rows");
           int rowNum = int.Parse(Console.ReadLine());

            for (rowWidth = 0; rowWidth < rowNum; rowWidth++)
            {
               
                Console.WriteLine("*");


            }

 int colWidth = int.Parse(Console.ReadLine());
        }
    }
}