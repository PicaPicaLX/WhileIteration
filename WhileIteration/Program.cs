using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileIteration
{
    class Program
    {
        static void Main(string[] args) // 创建一个控制台，能够玩游戏
        {
            bool displayMenu = true; // bool变量，类似布尔值
            while (displayMenu) // while循环当括号内为true时，执行花括号里的，否则执行花括号外的
            {
                displayMenu=MainMenu(); // 调用自定义方法"MainMenu"
            }
            
        }


        private static bool MainMenu() // 自定义方法"MainMenu"，在控制台显示以下选项并在其之后返回布尔值
        {
            Console.Clear(); // 清屏
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Print Numbers");
            Console.WriteLine("2) Guessing Game");
            Console.WriteLine("3) Exit");

            string result = Console.ReadLine(); // 读取用户输入
            if (result=="1")
            {
                PrintNumbers(); // 调用自定义方法"PrintNumbers"
                return true;
            }
            else if (result == "2")
            {
                GuessingGame(); // 调用自定义方法"GuessingGame"
                return true;
            }
            else if (result=="3")
            {
                return false; // 输入"3",返回false
            }
            else
            {
                return true; // 输入其他值则返回true
            }
        }

        private static void PrintNumbers() // 自定义方法"PrintNumbers"，在控制台显示"Print numbers"
        {
            Console.Clear();
            Console.WriteLine("Print numbers");
            Console.Write("Type a number: ");
            int result = int.Parse(Console.ReadLine());
            int counter = 1;
            while (counter < result + 1)
            {
                Console.Write(counter);
                Console.Write("-");
                counter ++;
            }
            Console.ReadLine();
        }

        private static void GuessingGame() // 自定义方法"Guessing game"，在控制台显示"Guessing game！"
        {
            Console.Clear();
            Console.WriteLine("Guessing game!"); 

            Random myRandom = new Random();
            int randomNumber = myRandom.Next(1, 11);

            int guesses = 0;
            bool incorrect = true;

            do
            {
                Console.WriteLine("Guess a number between 1 and 10: ");
                string result = Console.ReadLine();
                guesses++;

                if (result == randomNumber.ToString())
                    incorrect = false;
                else
                    Console.WriteLine("Wrong!");     
            } while (incorrect);
            Console.WriteLine("Correct! It took you {0} guesses.",guesses);
            Console.ReadLine();
        }
    }
}