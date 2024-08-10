// Write a program in C# to convert a string array to a string.

using System;

namespace Ishma_dot_net_practical_1
{
     class IshmaLab1Qn13
    {
        static void Main(string[] args)
        {
            string[] strArray = { "Hello!", "there", "how ", "are", "you. " , "This " , "is ", "dotnet" ,"practical" };

            string result = string.Join(" ", strArray);

            Console.WriteLine("Converted string array to atring is :");
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
