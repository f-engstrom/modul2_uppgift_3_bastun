using System;

namespace modul2_uppgift_3_bastun
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int fahrenheitIn = 1;
            double tempCelsius = 0.00;
            double fahrenheit = 1.00;
            bool inSiffror = false;
            bool tempOk = false; //Bool variable som styr while loopen för bastutemeraturen

            do // While loop som ser till att programmet börjar varje cykel med att först testa efter siffror och sen efter ifall temperaturen stämmer.
            {

                do //While loop för try and catch som testar att siffor matas in och som uppmanar användaren att mata in siffor om annat.
                {
                    Console.Write("Please enter temperature in Farenheit:");
                    string strFarhenheit = Console.ReadLine();

                    try
                    {
                        fahrenheitIn = Convert.ToInt32(strFarhenheit);
                        inSiffror = true;
                    }
                    catch
                    {
                        Console.WriteLine("Only Numbers Please.");

                    }

                } while (inSiffror == false);

                fahrenheit = (double)fahrenheitIn; //Omvandling av integern som läses in av användaren till double.  
                tempCelsius = (fahrenheit - 32) / (9.0 / 5.0); // Uträkning av Celsius värdet för givet Fahrenheit värde, flyttal för precision.

                if (tempCelsius >= 73.00 && tempCelsius <= 77.00) //Är temperaturen inom spannet 73 till 77 grader är den godkänns och While loopen avslutas.
                {
                    tempOk = true;
                }
                else if (tempCelsius < 73.00) // Är temperaturen under 73 fortsätter loopen och användaren ombeds höja den.
                {
                    Console.WriteLine("That's too cold, try a higher temperature.");

                }
                else if (tempCelsius > 77.00) //Är temperaturen över 77 grader ombeds användaren sänka den och loopen fortsätter.
                {
                    Console.WriteLine("That's too warm, try a lower temperature.");

                }


            } while (tempOk == false); 

            Console.WriteLine("Enjoy the Sauna.");
        }
    }
}
