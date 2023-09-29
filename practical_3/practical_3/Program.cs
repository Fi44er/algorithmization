using Flee.PublicTypes; // импорт библиотеки flee
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_3
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Выберите действие: 1 - калькулятор , 2 - решение квадратного уравнения");

            char action = Convert.ToChar(Console.ReadLine()); // происходит выбор действия

            if (action == '1') // если выбран пункт 1 выполняется код ниже (калькулятор)
            {   
                
                ExpressionContext context = new ExpressionContext(); // Определяем контекст нашего выражения
                context.Imports.AddType(typeof(Math));  // Разрешаем выражению использовать все статические общедоступные методы  System.Math
                Console.WriteLine("Введите пример(корень числа: sqrt(a); число пи: pi");
                string math = Console.ReadLine(); // вписываем математическое выражение
                IDynamicExpression eDynamic = context.CompileDynamic(math); // Создаем динамическое выражение, которое вычисляет значение объекта
                Object result = eDynamic.Evaluate(); // Вычислите выражения
                Console.WriteLine(result);
            }
            else if (action == '2') // если выбран пункт 2 выполняется код ниже (квадратное уравнение)
            {
                Console.WriteLine("Введите число a b и c через пробел");
                string[] mathArray_2 = Console.ReadLine().Split(); // делем строку по границе пробелов и записываем в массив
                double a = Convert.ToDouble(mathArray_2[0]); // присваиваем переменной значение из массива
                double b = Convert.ToDouble(mathArray_2[1]);
                double c = Convert.ToDouble(mathArray_2[2]);

                double formula = b * b - 4 * a * c; // формула квадратного уравнения
                double x1 = (-b + Math.Sqrt(formula)) / (2 * a); // вычисляем x1
                double x2 = (-b - Math.Sqrt(formula)) / (2 * a); // вычисляем x2

                Console.WriteLine("x1 = " + x1 + "\nx2 = " + x2);
            }
            else
            {
                Console.WriteLine("ВВЕДИТЕ СУЩЕСТВУЮЩИЕ ДЕЙСТВИЕ!!!");
            }
            
            
            Console.ReadLine();
           
        }
    }
}
