using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class CalculatorServise
    {
        public void HisoblashLogig()
        {
            Console.WriteLine("Iltimos hisoblamoqchi bo'lgan raqamlaringizni kiriting : ");
            Console.Write(" Ifodani kiriting  =  ");
            string summ = Console.ReadLine();

            int summa = 0;

            char currentSign = '+'; // Dastlabki amal +

            for (int i = 0; i < summ.Length - 1; i++)
            {
                if (char.IsDigit(summ[i]) && char.IsDigit(summ[i + 1]))
                {
                    Console.WriteLine(" Xato kiritdingiz !!!!! \n Iltimos, bir xonalik sonlardan iborat qo'shish va ayirish misolini yozing !!!");
                    return;
                }
            }

            foreach (char c in summ)
            {
                if (c == ' ')
                {
                    continue; // Probelni o'tkazib yuborish
                }
                if (c == '+' || c == '-')
                {
                    currentSign = c; // Joriy amalni yangilash
                }
                else if (char.IsDigit(c))
                {
                    int number = int.Parse(c.ToString());
                    if (currentSign == '+')
                    {
                        summa += number;
                    }
                    else if (currentSign == '-')
                    {
                        summa -= number;
                    }
                }
                else
                {
                    Console.WriteLine(" Xato kiritdingiz !!!!! \n Iltimos, bir xonalik sonlardan iborat qo'shish va ayirish misolini yozing !!!");
                    return;
                }

            }
            Console.WriteLine("Natija : " + summa);
        }
    }
}

