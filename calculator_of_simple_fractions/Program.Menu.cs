using System;
using static System.Console;

namespace calculator_of_simple_fractions
{
    partial class Program
    {
        public class Menu
        {
           public void MenuAction(int numerator, int denaminator, int numerator1, int denaminator1 )
            {
                while (true) // данный цикл возвращает панель меню для повтора операции
                {
                    int numOfComand;
                    while (true)      // использоание конструкции для поимки исключений
                    {
                        WriteLine("\t\t\t\t\t\tМеню команд");
                        WriteLine("1 - сложение\n2 - вычитание\n3 - умножение\n4 - деление");
                        Write("Введите номер команды : ");
                        try
                        {
                            numOfComand = int.Parse(ReadLine());
                            break;
                        }
                        catch (Exception)
                        {
                            WriteLine("Команда введена некорректно, введите команду!");
                        }
                    }
                    switch (numOfComand)      // данная конструкция используется в качестве альтернативы if более читабельна и понятна
                    {
                        case 1:
                            var fraction = new Fraction(numerator, denaminator);
                            var fraction1 = new Fraction(numerator1, denaminator1);
                            Fraction result = fraction.Sum(fraction1);
                            Write($"{numerator}/{denaminator} + {numerator1}/{denaminator1} = ");
                            result.Print();
                            break;
                        case 2:
                            fraction = new Fraction(numerator, denaminator);
                            fraction1 = new Fraction(numerator1, denaminator1);
                            result = fraction.Difference(fraction1);
                            Write($"{numerator}/{denaminator} - {numerator1}/{denaminator1} = ");
                            result.Print();
                            break;
                        case 3:
                            fraction = new Fraction(numerator, denaminator);
                            fraction1 = new Fraction(numerator1, denaminator1);
                            result = fraction.Multiply(fraction1);
                            Write($"{numerator}/{denaminator} * {numerator1}/{denaminator1} = ");
                            result.Print();
                            break;
                        case 4:
                            fraction = new Fraction(numerator, denaminator);
                            fraction1 = new Fraction(numerator1, denaminator1);
                            result = fraction.Devide(fraction1);
                            Write($"{numerator}/{denaminator} / {numerator1}/{denaminator1} = ");
                            result.Print();
                            break;
                    }
                    WriteLine("Хотите произвести другое арифметическое действие с данными дробями? Да или Нет");
                    string answer = ReadLine();
                    answer = answer.ToLower();
                    if (answer == "да")    // данное ветвление указывает на возможный повтор проведения арифметических операции и вызова меню
                    { 
                        Console.Clear(); 
                        continue; 
                    }
                    else
                    {
                        Console.Clear();
                        Program.Main();    // выход в главный класс
                    }
                }
            }
        }
    }
}
