using System;

namespace Exercise6_CozaLozaWoza
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lowerBarier = 1;
            int upperBarier = 110;
            int counter = 1;
            string printableLine;

            for (int i = lowerBarier; i < upperBarier; i++) 
            {
                printableLine = "";

                for (int j = 0; j < 11; j++) 
                {
                    printableLine = printableLine + " " + GetCozaWozaLoza(counter) ;
                    counter++;
                }

                Console.WriteLine(printableLine);
                if (counter >= upperBarier)
                {
                    break;
                }
            }

            Console.ReadKey();
        }

        static string GetCozaWozaLoza(int currentValue) 
        {
            string whatToPrint = "";
            if (currentValue % 3 == 0)
            {
                whatToPrint = "Coza";
            }
            if (currentValue % 5 == 0)
            {
                whatToPrint = whatToPrint + "Loza";
            }
            if (currentValue % 7 == 0)
            {
                whatToPrint = whatToPrint + "Woza";
            }
            if(whatToPrint == "")
            {
                whatToPrint = currentValue.ToString();
            }
            
            return whatToPrint;
        }
    }
}
