using static System.Console;

namespace calculator_of_simple_fractions
{
    partial class Program
    {
        class Fraction // основной класс, где хранятся методы арифметических операций с дробями
        {
            /// <summary>
            /// числитель
            /// </summary>
            int Numerator;
            /// <summary>
            /// знаменатель
            /// </summary>
            int Denaminator;


            public Fraction(int numerator, int denaminator)
            {
                Numerator = numerator;
                Denaminator = denaminator;
            }

            public Fraction(int numerator)
            {
                Numerator = numerator;
            }
            public void Print()
            {
                if (Denaminator == 0 || Denaminator == 1) 
                {
                    Write($"{Numerator}");
                } else
                WriteLine($"{Numerator}/{Denaminator}");
            }
            public Fraction Sum(Fraction otherFraction)
            {
                int commonDenaminator = Denaminator * otherFraction.Denaminator;
                int commonNumerator = Numerator * otherFraction.Denaminator + otherFraction.Numerator * Denaminator;
                if(commonNumerator >=Denaminator && commonNumerator % commonDenaminator == 0) // данное ветвление позволяет скоратить нацело неправильную дробь
                {
                    return new Fraction(commonDenaminator / commonNumerator); // возвращает остаток от деления неправильной дроби нацело в виде одного числа
                }
                else
                { 
                var test = new Test();      // Заход в метод класса для упрощения дроби
                test.Check( ref commonNumerator, ref commonDenaminator);               
                return new Fraction(commonNumerator,commonDenaminator);
                }
            }
            public Fraction Difference(Fraction otherFraction)
            {
                int commonNumerator = Numerator * otherFraction.Denaminator - otherFraction.Numerator * Denaminator;
                int commonDenaminator = Denaminator * otherFraction.Denaminator;
                if (commonNumerator >= Denaminator && commonNumerator % commonDenaminator == 0)
                {
                    return new Fraction(commonDenaminator / commonNumerator);
                }
                else
                {
                    var test = new Test();
                    test.Check(ref commonNumerator, ref commonDenaminator);
                    return new Fraction(commonNumerator, commonDenaminator);
                }
            }
            public Fraction Multiply(Fraction otherFraction)
            {
                int commonNumerator = (Numerator * otherFraction.Numerator);
                int commonDenaminator = Denaminator * otherFraction.Denaminator;
                if (commonNumerator >= Denaminator && commonNumerator % commonDenaminator == 0)
                {
                    return new Fraction(commonDenaminator / commonNumerator);
                }
                else
                {
                    var test = new Test();
                    test.Check(ref commonNumerator, ref commonDenaminator);
                    return new Fraction(commonNumerator, commonDenaminator);
                }
            }
            public Fraction Devide(Fraction otherFraction)
            {
                int commonNumerator = Numerator * otherFraction.Denaminator;
                int commonDenaminator = Denaminator * otherFraction.Numerator;
                if (commonNumerator >= Denaminator && commonNumerator % commonDenaminator == 0)
                {
                    return new Fraction(commonDenaminator / commonNumerator);
                }
                else
                {
                    var test = new Test();
                    test.Check(ref commonNumerator, ref commonDenaminator);
                    return new Fraction(commonNumerator, commonDenaminator);
                }
            }
        }
    }
}
