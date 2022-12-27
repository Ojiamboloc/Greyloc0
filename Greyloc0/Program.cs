using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greyloc0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gender(true);
            SayHi("felix",25);
            int card=Cube(57);
            Console.WriteLine(card);
            Console.ReadLine(); 
       }
       static void SayHi(string name, int age)
        {
            Console.WriteLine("hello "+name+ " you are " +age);
        }
        static  int Cube(int num)
        {
            int result = num * num * num;
            return result;
        }
        static void Gender(bool isMale)
           
        {
            if (isMale)
            {
            Console.WriteLine("You are male");
            }
    
        }
    }
}
