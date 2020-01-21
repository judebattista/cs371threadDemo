using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw01ex01
{
    public class Music {
        public void PlayImperialMarch() {
            /*
             * Imperial March translated by Y.Y. Bizyanov at http://llrprt.blogspot.com/2013/11/programming-imperial-march.html
             */
            Console.Beep(440, 500); Console.Beep(440, 500);
            Console.Beep(440, 500);
            Console.Beep(349, 350); Console.Beep(523, 150);
            Console.Beep(440, 500); Console.Beep(349, 350);
            Console.Beep(523, 150); Console.Beep(440, 1000);
            Console.Beep(659, 500); Console.Beep(659, 500);
            Console.Beep(659, 500); Console.Beep(698, 350);
            Console.Beep(523, 150);
            Console.Beep(415, 500); Console.Beep(349, 350);
            Console.Beep(523, 150); Console.Beep(440, 1000);
            Console.Beep(880, 500); Console.Beep(440, 350);
            Console.Beep(440, 150); Console.Beep(880, 500);
            Console.Beep(830, 250);
            Console.Beep(784, 250);
            Console.Beep(740, 125); Console.Beep(698, 125);
            Console.Beep(740, 250);
            Thread.Sleep(250); // Delay 250 milliseconds !!!!
            Console.Beep(455, 250); Console.Beep(622, 500);
            Console.Beep(587, 250); Console.Beep(554, 250);
            Console.Beep(523, 125); Console.Beep(466, 125);
            Console.Beep(523, 250);
            Thread.Sleep(250); // Delay 250 milliseconds !!!!
            Console.Beep(349, 125); Console.Beep(415, 500);
            Console.Beep(349, 375); Console.Beep(440, 125);
            Console.Beep(523, 500); Console.Beep(440, 375);
            Console.Beep(523, 125); Console.Beep(659, 1000);
            Console.Beep(880, 500); Console.Beep(440, 350);
            Console.Beep(440, 150); Console.Beep(880, 500);
            Console.Beep(830, 250); Console.Beep(784, 250);
            Console.Beep(740, 125); Console.Beep(698, 125);
            Console.Beep(740, 250);
            Thread.Sleep(250);
            Console.Beep(455, 250); Console.Beep(622, 500);
            Console.Beep(587, 250); Console.Beep(554, 250);
            Console.Beep(523, 125); Console.Beep(466, 125);
            Console.Beep(523, 250);
            Thread.Sleep(250);
            Console.Beep(349, 250); Console.Beep(415, 500);
            Console.Beep(349, 375); Console.Beep(523, 125);
            Console.Beep(440, 500); Console.Beep(349, 375);
            Console.Beep(261, 125); Console.Beep(440, 1000);
            Thread.Sleep(100);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello, {0}. How would you prefer to be addressed? ", Environment.UserName);
            string Handle = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Hello {0}, how old are you? ", Handle);
            int Age;
            bool validAge = Int32.TryParse(Console.ReadLine(), out Age);
            Console.WriteLine();
            //ConsoleColor OldBgColor = Console.BackgroundColor;
            ConsoleColor OldFgColor = Console.ForegroundColor;
            if (Age < 18) {
                //Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Red;
                System.Windows.Forms.MessageBox.Show("Danger " + Handle + "! Danger!", "Underage user.");
                Console.WriteLine("I am sorry, {0}. You are not authorized to proceed.", Handle);
            }
            else {
                //Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Welcome {0}. You are cleared to proceed. Apparently we live in a gerentocracy now.", Handle);
            }
            //Console.BackgroundColor = OldBgColor;
            Console.ForegroundColor = OldFgColor;
            // Wait for the user to press enter to terminate
            Console.WriteLine("Press any key to terminate...");
            Console.ReadLine();

        }

        public void playAsync() {
            Music March = new Music();
            Thread Th = new Thread(new ThreadStart(March.PlayImperialMarch));
            Th.Start();
        }

        public void PlaySynch() {
            Music March = new Music();
            March.PlayImperialMarch();
        }
    }
}
