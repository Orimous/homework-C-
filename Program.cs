using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tacks_02._02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1
            Console.Write("Введите натульное число: ");
            int addIntNumber = Convert.ToInt32(Console.ReadLine());
            int addIntNumberLast;
            int SearchLastNumber = addIntNumber % 10;
            Console.WriteLine($"Последнее число: {SearchLastNumber}");
            int NumberOfTriples = 0;
            int addLastNumber = 0;
            int sumNumbers = 0;
            int addEvenNumber = 0;
            int compositionNumbers = 1;
            int getZeroToFive = 0;
            while (addIntNumber > 0)
            {
                addIntNumberLast = addIntNumber % 10;
                int GetEvenNumber = addIntNumber % 2;
                //1.a
                if (addIntNumberLast == 3)
                {
                    NumberOfTriples++;
                }
                //1.б
                if (addIntNumberLast == SearchLastNumber)
                {
                    addLastNumber++;
                }
                //1.в
                if (addIntNumberLast >= 5)
                {
                    sumNumbers += addIntNumberLast;
                }
                //1.г
                if (GetEvenNumber == 0)
                {
                    addEvenNumber++;
                }
                //1.д
                if (addIntNumberLast >= 7)
                {
                    compositionNumbers *= addIntNumberLast;
                }
                //1.е
                if (addIntNumberLast > 0 && addLastNumber <= 5)
                {
                    getZeroToFive++;
                }
                addIntNumber /= 10;
            }
            Console.WriteLine($"Количество цифр 3: {NumberOfTriples}");
            Console.WriteLine($"Последняя цифра {SearchLastNumber} повторяются: {addLastNumber} раз");
            Console.WriteLine($"Количество чётных чисел: {addEvenNumber}");
            Console.WriteLine($"Сумма цифр больших пяти: {sumNumbers}");
            Console.WriteLine($"Произведение цифр больших семи: {compositionNumbers}");
            Console.WriteLine($"Числа от 0 до 5 встечаюся: {getZeroToFive} раз");
           

            

            
            

        }
    }
}
