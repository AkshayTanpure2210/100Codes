//using System;

namespace TransflowerLearning.MathSolution
{
    public static  class ExampleA
    {
        public static int x;
        private static int y = 30;
        private static int z = 50;
   
        public static void MaxValue()
        {
            if (x >= y && x >= z)
                Console.WriteLine(x + " is the greatest");
            else if (y >= x && y >= z)
                Console.WriteLine(y + " is the greatest");
            else
                Console.WriteLine(z + " is the greatest");
        }
          public static void MinValue()
        {
             if (x <= y && x <= z)
        Console.WriteLine (x + " x is the lowest value");

  
       else if (y <= x && y <= z)
         Console.WriteLine(y + "y  is the lowest value");

  
      else if (z <= x && z <= y)
       Console.WriteLine(z + " z is the lowest value");
        }
 public static void MaxValueByTernory()
        {
            int temp,result;

            temp =x>y? x:y;

            result= temp>z ? temp:z;
            Console.WriteLine(result + " is the greatest");
            

        }


    }
}
