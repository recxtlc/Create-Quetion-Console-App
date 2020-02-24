using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queiz
{
    class Answer 
    {
        private List<string> listOfAnswers;

        public List<string> GetAnswer 
        { 
            get
            {
                return listOfAnswers;
            }
        
        }
       public Answer()
        {
            listOfAnswers = new List<string>() { "South Africa","Human","4"};
        }
        private void AddAnswer(string answer)
        {
            listOfAnswers.Add(answer);

        }
        public void AskAnswer()
        {
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tEnter The Correct Answer.\t");
            Console.Write("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
            AddAnswer(Console.ReadLine());
        }

      

    }
}
