using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quizmaster
{
    public class StartQuiz
    {
        public static int quiz(string[] questions, string[] answers) {
            int count = 0,i=0;
            Console.WriteLine("Wellcome to QuizMaster\n this quiz is about C# basics it will have 10 questions so get ready and let get started!");
            Console.WriteLine("but before we start please make sure to enter A/a ,B/b ,C/c or D/d as an answer");
            while (i != 9) {
               
                Console.WriteLine(questions[i]);
                string ans=Console.ReadLine();
                if (ans == answers[i] || ans.ToUpper() == answers[i])
                {
                    count++;
                    Console.WriteLine("Good Job you've got this right!");

                }
                else if (ans != "A" && ans != "B" && ans != "C" && ans != "D" && ans != "a" && ans != "b" && ans != "c" && ans != "d") { 
                Console.WriteLine("you entered a not suppoted format! please try again making sure your anwser is A/a B/b C/c D/d \n ");
                    Console.WriteLine(questions[i]);
                    string a = Console.ReadLine();
                    if (a == answers[i] || a.ToUpper() == answers[i])
                    {
                        count++;
                        Console.WriteLine("Good Job you've got this right!");

                    }
                    else
                    {
                        Console.WriteLine("you've got this wrong again ;(");
                    }
                }
                
               
                else {
                    Console.WriteLine("your answer is wrong :( but dont worry you have one more shoot! lets try again");
                    Console.WriteLine(questions[i]);
                    string bb = Console.ReadLine();
                    if (bb == answers[i] || bb.ToUpper() == answers[i])
                    {
                        count++;
                        Console.WriteLine("Good Job you've got this right!");

                    }
                    else {
                        Console.WriteLine("you've got this wrong again ;(");
                    }

                   
                }

                i++;
            }

        return count;
        }
    }
}
