using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a value from 1 to 3 to win a price: ");
            string userValue = Console.ReadLine();
            Program newValue = new Program();
            newValue.DessisionMethod(userValue);
            Console.ReadLine();
        }


        public void DessisionMethod(string userValue)
        {
            
            if (userValue == "1")
             Console.WriteLine("you won a car");
            
            else if (userValue == "2")
             Console.WriteLine("you won Pheobe, the bad the pussy");
            
            else if (userValue == "3")
             Console.WriteLine("you won Aventer the lazy cat");
                       
            else if (userValue != "1" && userValue != "2" && userValue != "3") 
              Console.WriteLine("I told you put a value from 1 to 3. Am I speaking spanish? ");
          
            else
              Console.WriteLine("I speak in spanish whe I get mad. Te dije que pusieras un numero del 1 al 3 como puta madre tendre que decirlo");
        }

    }  
}
