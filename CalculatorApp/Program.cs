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
//    INPUT:     2+5-1
//OUTPUT:  6

//Shartlar:
//1. Faqat + va - amallari bajariladi
//2. Faqat 1 xonalik sonlar kiritiladi
//3. Foydalanuvchi doimo to'g'ri qiymatlarni kiritishi ta'minlanadi

//Kuchililar uchun:
//1. orada probel tashlab ketilgan holatlarni ham inobatga olish kerak, Ya'ni:
//INPUT:     2 + 5 - 1
//OUTPUT:  6
//2. Foydaluvchi xato qiymatlarni ham kiritib qoyishi mumkin.

//INPUT:  a&+51 -01
//OUTPUT: Iltimos, bir xonalik sonlardan iborat qo'shish va ayirish misolini yozing

    

