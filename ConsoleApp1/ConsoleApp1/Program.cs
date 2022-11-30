using System;

namespace ConsoleApp1 {
    class Program {

        static public void Main(string[] args) {
           
        }
        static void WhileDoWhile() {
            int age = 26;
            while (age < 18) {
                Console.WriteLine("First while loop");
                Console.WriteLine("What is your age?");
                age = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Good!");


            do {
                Console.WriteLine("Do/while while loop");
                Console.WriteLine("What is your age?");
                age = int.Parse(Console.ReadLine());
            } while (age < 18);


        }
        static void NestedFor() {
            int[] numbers = { 1, -2, 4, -7, 5, 3, 2, -1, -3, 2, 7, -1, -3, 1, 7 };

            for (int i = 0; i < numbers.Length; i++) {
                for (int y = i + 1; y < numbers.Length - 2; y++) {
                    for (int j = y + 1; j < numbers.Length - 1; j++) {
                        int atI = numbers[i];
                        int atY = numbers[y];
                        int atJ = numbers[j];

                        if (atI + atY + atJ == 0) {
                            Console.WriteLine($"Triplete ({atI};{atY};{atJ}). Indexes ({i};{y};{j})");
                        }
                    }

                }
            }
        }
    }
}