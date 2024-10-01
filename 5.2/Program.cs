namespace _5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double earthweight;
            int planet;

            Console.WriteLine("What planet would you like to fight on?");
            Console.WriteLine(" 1. venus 2. mars 3. jupiter 4.saturn 5. uranus 6. neptune");
            planet = int.Parse(Console.ReadLine());
            Console.WriteLine("What is  your earth weight?");
            earthweight = double.Parse(Console.ReadLine());

            if (planet == 1)
            {


                Console.WriteLine(" on venus your weight would be " + earthweight * 0.78 + "LBS");
                Console.WriteLine("You got this, win this fight");
            }
            else if (planet == 2)
            {


                Console.WriteLine(" on mars your weight would be " + earthweight * 0.39 + "LBS");
                Console.WriteLine("You got this, win this fight");
            }
            else if(planet == 3)
            {


                Console.WriteLine(" on jupiter your weight would be " + earthweight * 2.65 + "LBS");
                Console.WriteLine("You got this, win this fight");
            }
            else if (planet == 4)
            {



                Console.WriteLine(" on saturn your weight would be " + earthweight * 1.17 + "LBS");
                Console.WriteLine("You got this, win this fight");
            }
            else if (planet == 5)
            {




                Console.WriteLine(" on uranus your weight would be " + earthweight * 1.05 + "LBS");
                Console.WriteLine("You got this, win this fight");
            }
            else if (planet == 6)
            {



                Console.WriteLine(" on Neptune your weight would be " + earthweight * 1.23 + "LBS");
                Console.WriteLine("You got this, win this fight");
            }
                
            
            
            
            
            
            



              
            





        }
    }
}
