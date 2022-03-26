namespace calculator_of_simple_fractions
{
    partial class Program
    {
        class Test        // функционал этого класса предназначен для сокращения простых дробей и привидения их к конечному ответу
        {
           
            public void Check(ref int numerator, ref int denaminator)
            
            {
                int tmpNum = 0;
                for(int i = 1; i <= numerator; i++)
                {
                    if(numerator % i == 0 && denaminator % i == 0)
                    {
                        tmpNum = i;
                    }
                }
                numerator = numerator / tmpNum;
                denaminator = denaminator / tmpNum;
            }

        }
    }
}
