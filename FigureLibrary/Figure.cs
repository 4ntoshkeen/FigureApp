using System;
using System.Linq;
using System.Collections.Generic;

namespace FigureLibrary
{

    /* 
     
     ОБЪЯВЛЯЕМ КЛАСС 'FIGURE'. В НЕМ СОДЕРЖАТСЯ ПОЛЯ ДЛЯ ЗНАЧЕНИЙ СТОРОН ФИГУРЫ И ПОЛЕ РАДИУСА (ПО УМОЛЧАНИЮ РАВНОЕ НУЛЮ). 
     ДЛЯ БОЛЬШЕГО КОЛИЧЕСТВА УГЛОВ НЕОБХОДИМО ДОБАВИТЬ СООТВЕТСТВУЮЩЕЕ ПОЛЕ ДОПОЛНИТЕЛЬНЫМ СТОРОНАМ.   
     ТАКЖЕ НЕОБХОДИМО ДОПОЛНИТЕЛЬНО СОЗДАТЬ МЕТОД ДЛЯ ВЫЧИСЛЕНИЯ ПЛОЩАДИ ФИГУРЫ, НО С БОЛЬШИМ КОЛИЧЕСТВОМ ПЕРЕДАВАЕМЫХ ПАРАМЕТРОВ.
          
     */


    public class Figure
    {
        public int a;
        public int b;
        public int c;
        // ЗДЕСЬ МОГУТ БЫТЬ ДОПОЛНИТЕЛЬНЫЕ ПОЛЯ
        public double r = 0;


        // МЕТОД ДЛЯ ОКРУЖНОСТИ
        public double Area(double r)
        {
            const double pi = 3.1415926535897931;
            double result = pi * (r * r);
            return result;  
        }

        // МЕТОД ДЛЯ ТРЕУГОЛЬНИКА
        public string Area(int a, int b, int c)
        {
            
            List<int> sides = new List<int>() { a, b ,c };

            // ПРОВЕРКА НА ПРЯМОУГОЛЬНОСТЬ
            int hypotenuse = sides.Max();
            int index = sides.IndexOf(hypotenuse);
            
            Console.WriteLine("INDEX OF MAX INT: " + index + ", ELEMENT IS " + sides[index] + "."); 
           
            sides.RemoveAt(index);

            int sum = 0; 

            foreach (int side in sides)
            {
                sum = sum + side*side;
            }

            if (hypotenuse*hypotenuse ==  sum)
            {
                Console.WriteLine("*** ANGLE IS 90 ***");
            }

            else
            {
                Console.WriteLine("*** ANGLE IS NOT 90 ***");
            }

            // РАСЧЕТ ПЛОЩАДИ
            double semifPerimeter = (a + b + c) / 2;
            double result = Math.Sqrt(semifPerimeter * (semifPerimeter - a) * (semifPerimeter - b) * (semifPerimeter - c));
            string resultString = "AREA IS: " + result + ".";
            return resultString;
        }

    }
}
