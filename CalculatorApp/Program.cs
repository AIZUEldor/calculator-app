using System.Timers;

namespace CalculatorApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            CalculatorServise calculator = new CalculatorServise();
            Console.WriteLine("Heloo !!! . Cankulyator dasturiga xush kelipsiz ! Boshlaymizmi ? ");
            Console.Write("  Ha \n. Yo'q .... ");
            string answer = Console.ReadLine();
            if (answer.ToLower() == "ha")
            { 
              bool continueCalculation = true;
                while (continueCalculation) // yangi hisoblash uchun tsikl
                {
                    calculator.HisoblashLogig();
                    Console.WriteLine("Yana hisoblamoqchimisiz? (Ha/Yo'q)");
                    string continueAnswer = Console.ReadLine();
                    if (continueAnswer.ToLower() != "ha")
                    {
                        continueCalculation = false;
                    }
                    
                }
                Console.WriteLine("Dasturdan foydalanganingiz uchun rahmat ! Xayr salomat bo'ling :) ");

            }
            else
            {
                Console.WriteLine("Dasturdan foydalanganingiz uchun rahmat ! Xayr :)");
            }
        }

       
    }
}


    

