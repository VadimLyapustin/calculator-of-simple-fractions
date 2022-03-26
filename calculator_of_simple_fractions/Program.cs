using System;
using static System.Console;

namespace calculator_of_simple_fractions
{
    partial class Program
    {
        static void Main()
        {
            int numerator;
            int denaminator;
            while (true)
            {
                Write("Введите значения числителя и знаменателя первой дроби : ");
                char[] c = { '.', ',', ' ', '-', '/', '\\' }; //массив символов водится для указания основных символов по которым строка будет разбиваться на массив,
                string[] s = ReadLine().Split(c, StringSplitOptions.RemoveEmptyEntries); // ввод данных в массив.  

                if (s.Length == 1) // Данное ветвление используется в случае если мы вводим одно число 
                {
                    try            // конструкция отлавливает исключения если пользователь ввел неверный символ  
                    {
                        numerator = int.Parse(s[0]);

                    }
                    catch (Exception)
                    {
                        WriteLine("Значение введено неверно!");
                        continue;                    // оператор возвращает в начало цикла, в случае пойманного исключения
                    }
                    denaminator = 1;
                    break;
                }
                else
                    try      //ловим исключение при вводе не цифровых символов.
                    {
                        numerator = int.Parse(s[0]);                  
                        denaminator = int.Parse(s[1]);
                        if(denaminator == 0)                          // данное ветвление используется в случае,если знаменатель 0 и возвращает в начало цикла  
                        {
                            WriteLine("Дробь введена с ошибкой.Знаменатель не может быть равен нулю.Введите корректные значения");
                            continue;
                        }
                        break;
                    }
                    catch (Exception)
                    {
                        WriteLine("Одно из значений введено неверно!Попробуйте снова");
                    }
            }
            int numerator1;
            int denaminator1;
            while (true)
            {
               
                Write("Введите значения числителя и знаменателя второй дроби : ");
                char[] c = { '.', ',', ' ', '-', '/', '\\' }; // массив символов водится для указания основных символов по которым строка будет разбиваться на массив,
                string[] s1 = ReadLine().Split(c, StringSplitOptions.RemoveEmptyEntries); // ввод данных в массив.  
               if(s1.Length == 1) // рассмотрен случай, когда в массив вводится только числитель
                {
                    try 
                    { 
                        numerator1 = int.Parse(s1[0]);
                        
                    }
                    catch (Exception)
                    {
                        WriteLine("Значение введено неверно!");
                        continue;  
                    }
                    denaminator1 = 1; // значение знаменателя при отсутсвии вводимого значения знаменателя
                    break;
                }
                else
                try
                {
                    numerator1 = int.Parse(s1[0]);                  //ловим исключение при вводе не цифровых символов.
                    denaminator1 = int.Parse(s1[1]);
                        if(denaminator1 == 0)
                        {
                            WriteLine("Дробь введена с ошибкой.Знаменатель не может быть равен нулю.Введите корректные значения");
                            continue; 
                        }
                    break;
                }
                catch (Exception)
                {
                    WriteLine("Одно из значений введено неверно!Попробуйте снова");
                }

            }
            WriteLine("Для вызова меню арифметических действий нажмите любую клавишу....");
            ReadKey();
            Console.Clear();
            var menu = new Menu();
            menu.MenuAction(numerator,denaminator,numerator1,denaminator1);
           
        }
    }
}
