using System;

using FigureLibrary;

namespace FigureApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /******************  ВВОДИМ КОЛИЧЕСТВО УГЛОВ ФИГУРЫ  ******************/

            Console.WriteLine("HOW MANY ANGLES?: ");                                           
            string angle = Console.ReadLine();


            /******************  ПРОВЕРЯЕМ, ВСЕ ЛИ В ПОРЯДКЕ  СО ВВОДОМ  ******************/
            try
            {
                int angleNumber = int.Parse(angle);

                // СЛИШКОМ МНОГО УГЛОВ                                
                if (angleNumber > 3)  
                {
                    Console.WriteLine("TOO MUCH ANGLES. NEED TO ADD THIS FUGURE IN YOUR PROGRAM.");
                }

                // ЧИСЛО УГЛОВ НЕ ДОЛЖНО БЫТЬ ОТРИЦАТЕЛЬНЫМ
                else if (angleNumber < 0)
                {
                    Console.WriteLine("CAN'T BE NEGATIVE.");
                }

                else if (angleNumber == 1 || angleNumber == 2)
                {
                    Console.WriteLine("NEED MORE ANGLES.");
                }

                // В СЛУЧАЕ ОКРУЖНОСТИ
                else if (angleNumber == 0)                                                                     
                {
                    Console.WriteLine("CIRCLE? ENTER RADIUS HERE: ");
                    string radius = Console.ReadLine();
                    
                    // ПРОВЕРКА ЗНАЧЕНИЯ РАДИУСА 
                    try
                    {                        
                        double radiusNumber = double.Parse(radius);
                        Figure figure = new Figure();

                        
                        if (radiusNumber < 0)
                        {
                            Console.WriteLine("CAN'T BE NEGATIVE.");
                        }


                        //ВЫЧИСЛЯЕМ ПЛОЩАДЬ И ВЫВОДИМ В КОНСОЛИ
                        else
                        {
                            Console.WriteLine(figure.Area(radiusNumber));                            
                        }
                    }

                    catch
                    {
                        Console.WriteLine($"UNABLE TO PARSE '{radius}'");
                    }
                }


                else
                {
                    // ВВОДИМ ЗНАЧЕНИЯ СТОРОН

                    Console.WriteLine("ENTER SIDES OF TRIANGLE HERE: ");
                    string A = Console.ReadLine();
                    string B = Console.ReadLine();
                    string C = Console.ReadLine();

                    // ПРОВЕРКА ЗНАЧЕНИЙ 
                    try
                    {
                        int a = int.Parse(A);
                        int b = int.Parse(B);
                        int c = int.Parse(C);
                        Figure figure = new Figure();


                        if (a <= 0 || b <= 0 || c <= 0 )
                        {
                            Console.WriteLine("SIDE CAN'T BE NULL OR NEGATIVE.");
                        }


                        //ВЫЧИСЛЯЕМ ПЛОЩАДЬ И ВЫВОДИМ В КОНСОЛИ
                        else
                        {
                            Console.WriteLine(figure.Area(a, b, c));
                        }
                    }

                    catch
                    {
                        Console.WriteLine($"UNABLE TO PARSE");
                    }

                }

                
            }

            /******************  ВЫДАЕМ ОШИБКУ КОНВЕРТАЦИИ  ******************/

            catch (FormatException)

            {
                Console.WriteLine($"UNABLE TO PARSE '{angle}'");
            }

        }
    }
}
