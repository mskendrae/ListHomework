using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating a boolean list to evaluate

            List<bool> newBoolList = new List<bool>() { true, false, false, true, false };
            // Console.WriteLine(newBoolList[0]); testing what will print out of list
             
            foreach (bool gonnaRain in newBoolList) //telling the loop to go thru each list value.
               
                    // evaluating the contents of the list and sending output to the console.
                if (gonnaRain == true)
                {
                    Console.WriteLine("Better Bring an umbrella.");
                } else
                {
                    Console.WriteLine("No rain today, enjoy the sun.");
                }
                Console.ReadLine();


            //    
        }
    }  
}
    