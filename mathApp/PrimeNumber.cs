// using System;
// using System.Security.Cryptography.X509Certificates;

// namespace TransflowerLearning.MathSolution
// {
//     public class PrimeNumber
//     {
//             int n = 23;


//         public void CheckPrimeNumber(int n)
//         {
    
//             if (n < 2)
//             {
//                 Console.WriteLine($"The given number {n} is not prime");
//                 return;
//             }

            
//             if (n == 2)
//             {
//                 Console.WriteLine($"The given number {n} is prime");
//                 return;
//             }

           
//             if (n % 2 == 0)
//             {
//                 Console.WriteLine($"The given number {n} is not prime");
//                 return;
//             }

//             // check for factors up to the square root of n
//             for (int i = 3; i <= Math.Sqrt(n); i += 2)
//             {
//                 if (n % i == 0)
//                 {
//                     Console.WriteLine($"The given number {n} is not prime");
//                     return;
//                 }
//             }

//             Console.WriteLine($"The given number {n} is prime");


//     }

// public  int Sum(){
//    int y=20;
//    int z =50;
//    int x =y+z;
//    Console.WriteLine(x);
//    return x;
// }
// }
// }
