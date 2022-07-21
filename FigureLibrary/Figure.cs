using System;


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
        public double Area(int a, int b, int c)
        {
            double semifPerimeter = (a + b + c) / 2;
            double result = Math.Sqrt(semifPerimeter * (semifPerimeter - a) * (semifPerimeter - b) * (semifPerimeter - c));   
            return result;
        }

    }
}
