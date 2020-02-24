using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queiz
{
    class Quetion 
    {
       private List<string> listOfQuestions;
       private enum options
       {
           A=1, B=2,C=3,D=4,E=5
       }
       public List<string> GetListOfQuestions
       {

           get
           {
               return listOfQuestions;
           }
       }

       public Quetion()
        {
            listOfQuestions = new List<string>() {"what is the name of your country?","Is france a country or a human ", "how many names can a one person have?"};
        }
        private void AddQuestion(string qestion)
        {
            listOfQuestions.Add(qestion);
        }
        public void AskQuestion()
        {

            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tEnter your question below.");
            Console.Write("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
            AddQuestion(Console.ReadLine());

        }
        public void AskMultiChoiceQuestion()
        { 
            string multiQuestion ="";
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tEnter number of options [2-5].");
            Console.Write("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
            var strOpt= Console.ReadLine();
            int optNumber =0;
            do
            {
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t1.One word or\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t2.Mutichoice Question");
                Console.Write("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
                strOpt = Console.ReadLine();
                if (optNumber > 5 || optNumber < 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tnumber range is [2-5]");
                    Console.ResetColor();
                  
                    
                }
                else
                {

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tnumbers only please");
                    Console.ResetColor();
                   
                }
               
                    
            } while (!Int32.TryParse(strOpt, out  optNumber) || optNumber > 5 || optNumber < 2);



            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tEnter your question below.");
            Console.Write("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
            multiQuestion = Console.ReadLine()+"\n";
            for (int i = 1; i <= optNumber; i++)
            {
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tEnter answer for " + (options)i);
                Console.Write("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
                multiQuestion += (options)i + "." + Console.ReadLine() + "\n";
            }
            
          
            AddQuestion(multiQuestion);
        }
      
        public int SingleOrMultichoiceQuestion()
        {

            int opt;
            var strOpt = "";
            do
            {
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t1.One Word Question\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tor\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t2.Mutichoice Question");
                Console.Write("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
                strOpt = Console.ReadLine();

            } while (!Int32.TryParse(strOpt, out  opt) || opt > 2 || opt < 1);



            return opt;
        }

       

    }
}
