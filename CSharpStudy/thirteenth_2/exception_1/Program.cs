using System;

namespace exception_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 예외 상황 확인(IndexOutOfRangeException)
            /*string[] array = { "가", "나" };
            Console.WriteLine("숫자를 입력해주세요: ");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("입력한 위치의 값은 '" + array[input] + "'입니다.");*/

            // 기본 예외 처리
            string[] array = { "가", "나" };
            Console.WriteLine("숫자를 입력해주세요: ");
            int input = int.Parse(Console.ReadLine());

            if (input < array.Length)
            {
                Console.WriteLine("입력한 위치의 값은 '" + array[input] + "'입니다.");
            }
            else
            {
                Console.WriteLine("인덱스 범위를 넘었습니다.");
            }

        }
    }
}
