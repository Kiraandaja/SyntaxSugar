using System;

namespace SyntaxSugarExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer = 4; //Explicit Typing
            string response;//Explicit Typing


            if (answer < 9)
            {
                response = answer + " is less than nine";

                Console.WriteLine(response);
            }
            else
            {
                response = answer + "greater than or equal to nine";
                Console.WriteLine(response);
            }
            //Terenary Operator, Syntax Sugar, String Interpolation
            var response2 = (answer < 9) ? $"{answer} is less than nine." : $"{answer} is greater than or equal to nine.";


        }
        



    }
}
