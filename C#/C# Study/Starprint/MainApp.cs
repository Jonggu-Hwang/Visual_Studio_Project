using System;

namespace Starprint
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.Write("반복 횟수를 입력하세요: ");
            string input = Console.ReadLine();
            int input_number = int.Parse(input);

            if (input_number <= 0)
            {
                Console.WriteLine("0보다 작거나 같은 수는 입력할 수 없습니다.");
                goto EXIT;
            }

            for (int i = 0; i < input_number; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        EXIT:;



        }
    }
}