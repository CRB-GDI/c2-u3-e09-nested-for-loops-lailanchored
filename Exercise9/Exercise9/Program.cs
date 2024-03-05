namespace Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
          //Prompt for rowNums and rowWidth
            Console.WriteLine(" How many Rows : ");
            int rowNum = int.Parse(Console.ReadLine());

            Console.Write("What Row Width : ");
            int rowWidth = int.Parse(Console.ReadLine());


            //print number of rows (up and down)
            //print width of asterisks (left to right)
            for (int i = 0; rowNum > i; i++)
            {
                for (int j = 0; j < rowWidth; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                //end of problem one

            }
            Console.Write("What Width : ");
            
                int stairWidth = int.Parse(Console.ReadLine());
            //prompt for width of the stairs
            for (int k = 1; k <= stairWidth; k++)
            {

                for (int astAcross = 1; astAcross <= k; astAcross++)
                {
                    Console.Write("*");
                    //[print stairs
                    
                }


                Console.WriteLine();
            }
            
        


    }


    }
}