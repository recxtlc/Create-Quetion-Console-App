using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queiz
{
    class Game
    {
        Answer ans;
        Quetion que;
        Player player;
        bool correct;
        int answerCorrect;
        int incorrect;
        bool showScoreHeading;

        public int ScoreUpdate { get; set; }
        public Game()
        {
           ans = new Answer();
           que = new Quetion();
           player = new Player();
           answerCorrect = 0;
           incorrect = 0;
           correct = false;
           showScoreHeading = false;
            
        }

        public void ShowHeader()
        {
            Console.Clear();
            Console.WriteLine("***********************************************************************************************************************");
            Console.WriteLine("\t\t\t\t\t\t********Console App*********");

            Console.WriteLine("***********************************************************************************************************************");

            Console.WriteLine("***********************************************************************************************************************");
           if(showScoreHeading)
           {
               ShowCorrectAnswerUpdate();
               ShowIncorrectAnswerUpdate();
            
           }
            Console.WriteLine("");
            
           
        }
        // I need to fetc data one by one in the list and compare it to the answert questions lists
        public void play()
        {
            AnswerCorrectOrNot();
           
        }
        private void ShowQuestion(int index)
        {
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tThe Question is \t:"+ que.GetListOfQuestions[index]);
        }
        private  void AnswerCorrectOrNot()
        {
            answerCorrect = 0;// for every player score gets to be zero
            incorrect = 0;
            for (int i = 0; i < que.GetListOfQuestions.Count; i++)
            {
                showScoreHeading = true;//score will only show when the player answers questions
                ShowHeader();
                ShowQuestion(i);
                var answer = player.GetAnswer();

                if(ans.GetAnswer[i].ToLower().Trim() == answer.ToLower().Trim())
                {                  
                    correct = true;
                    answerCorrect++;
                   
                }
                else
                {
                    correct = false;
                    incorrect++;
                }

              
                
            }
            ShowHeader();
            Console.ReadLine();// to hold the screen for enter 
            showScoreHeading = false;// resert the heading without score appearing 
        }

        private void ShowCorrectAnswerUpdate()
        {
           
           
            if (correct == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t Correct Answers: \t_" + answerCorrect + "_out of " + que.GetListOfQuestions.Count);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tCorrect Answers: \t_" + answerCorrect+"_out of "+que.GetListOfQuestions.Count);
                Console.ResetColor();
            }
            
        }
        public void ShowIncorrectAnswerUpdate()
        {
            if(!correct)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tIncorrect Answers: \t_" + incorrect + "_out of " + que.GetListOfQuestions.Count);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tIncorrect Answers:\t_" + incorrect + "_out of " + que.GetListOfQuestions.Count);
                Console.ResetColor();
            }

        }

        public int NumberOfQuestions()
        {
            return que.GetListOfQuestions.Count;
        }

        public void MainMenu()
        {
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t1.Add Questions");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t2.Play game");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t3.Exit");
            Console.Write("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
            
            var opt = ConvertStringToInt(Console.ReadLine());
            option(opt);
        }
        private int ConvertStringToInt(string str)
        {
            int option;
            while (!Int32.TryParse(str, out option) || option > 3|| option <1)
            {
                if (option > 3 || option < 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tnumber range is 1-3");
                    Console.ResetColor();

                }
                else
                    Console.WriteLine("invalid input");

                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tEnter the options below");
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t1.Add Questions");
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t2.Play game");
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t3.Exit");
                Console.Write("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
                str = Console.ReadLine();
            }

            return option;
        }
       
        public void  option(int opt)
        {
            switch(opt)
            {
                case 1:
                    var done = true;
                    do
                    {
                    ShowHeader();
                        var questionOpion = que.SingleOrMultichoiceQuestion();
                        if (questionOpion == 1)
                        {
                            que.AskQuestion();
                        }
                        else if (questionOpion == 2)
                        {
                            que.AskMultiChoiceQuestion();
                        }
                
                    ans.AskAnswer();
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tif you would like to add more questions press y or n to go to the main menu");
                    Console.Write("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t:");
                        if(Console.ReadLine().Trim().ToLower() == "y")
                        {
                            continue;
                        }
                         else
                        {
                            done = false;
                        }

                    }while(done);
                  
                    break;
                case 2:
                    play();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
            }

        }
    }
}
