using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queiz
{
    class Program
    {
        static void Main(string[] args)
        {

           
            var game = new Game();
            var count = 0;
            do
            {
               game.ShowHeader();
               game.MainMenu();
               //game.option(1);
              
                count++;
            } while (count != game.NumberOfQuestions());
          


            Console.ReadKey();
        }
    }
}
