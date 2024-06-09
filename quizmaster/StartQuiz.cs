using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quizmaster
{
    public class StartQuiz
    {
        private const int timeLimit = 10000;
        public static void quiz() {
            string[] questions = { "1. C# is a programming language, developed by ___.\nA. Oracle\r\nB. Microsoft\r\nC. GNU project\r\nD. Google", "2. C# runs on the ___.\r\n\r\nA. .NET Framework\r\nB. Java Virtual Machine\r\nC. Both A. and B.\r\nD. None of the above", "3. Is C# an object-oriented programming language?\r\n\r\nA. Yes\r\nB. No", "4. What is CLR in C#?\r\n\r\nA. It is a virtual machine component of Microsoft .NET Framework\r\nB. It is a virtual machine component of JVM\r\nC. It is a compiler to compiler the C# code\r\nD. All of the above", "5. Is C# programming language a case-sensitive?\r\n\r\nA. Yes\r\nB. No", "6.What is the correct syntax to declare a variable in C#?\r\n\r\nA. type variableName = value;\r\nB. type variableName;\r\nC. variableName as type = value;\r\nD. Both A. and B.", "7.Which C# keyword is used to define a constant?\r\n\r\nA. define\r\nB. fixed\r\nC. constant\r\nD. const", "8.Which is not a valid C# data type?\r\n\r\nA. long\r\nB. int\r\nC. float\r\nD. complex", "9. What is 'Console' in C#?\r\n\r\nA. Class\r\nB. Object\r\nC. Method\r\nD. Structure", "10.Which is/are the correct method(s) to input a float value in C#?\r\n\r\nA. Parse(Console.ReadLine())\r\nB. ToSingle(Console.ReadLine())\r\nC. ToFloat(Console.ReadLine());\r\nD. Both A and B" };
            string[] answers = { "B", "A", "A", "A", "A", "D", "D", "D", "A", "B" };
            int count = 0,i=0;
            Console.WriteLine("Wellcome to QuizMaster\n this quiz is about C# basics it will have 10 questions so get ready and let get started!");
            Console.WriteLine("but before we start please make sure to enter A/a ,B/b ,C/c or D/d as an answer you have 10 seconds per question\n\n");
            while (i <= 9) {
                Stopwatch stopwatch = Stopwatch.StartNew();
                string ans = null;
                Console.WriteLine(questions[i]);
                while (stopwatch.ElapsedMilliseconds < timeLimit && ans == null)
                {
                    if (Console.KeyAvailable)
                    {
                        ans = Console.ReadLine();
                    }
                }

                stopwatch.Stop();
                if (ans == null)
                {
                    Console.WriteLine("\nTime's up! Moving to the next question.\n");
                    i++;
                    continue;
                }
                if (ans == answers[i] || ans.ToUpper() == answers[i])
                {
                    count++;
                    Console.WriteLine("Good Job you've got this right!\n");

                }
                else if (ans != "A" && ans != "B" && ans != "C" && ans != "D" && ans != "a" && ans != "b" && ans != "c" && ans != "d") { 
                Console.WriteLine("you entered a not suppoted format! please try again making sure your anwser is A/a B/b C/c D/d \n ");
                    string a = null;
                    Stopwatch stopwatch2 = Stopwatch.StartNew();
                    Console.WriteLine(questions[i]);
                    while (stopwatch2.ElapsedMilliseconds < timeLimit && a == null)
                    {
                        if (Console.KeyAvailable)
                        {
                            a = Console.ReadLine();
                        }
                    }

                    stopwatch2.Stop();
                    if (a== null)
                    {
                        Console.WriteLine("Time's up! Moving to the next question.\n");
                        i++;
                        continue;
                    }
                    if (a == answers[i] || a.ToUpper() == answers[i])
                    {
                        count++;
                        Console.WriteLine("Good Job you've got this right!\n");

                    }
                    else
                    {
                        if (a != "A" && a != "B" && a != "C" && a != "D" && a != "a" && a != "b" && a != "c" && a != "d") {
                            Console.WriteLine("you've entered a not supported format again \n");
                        }
                        else
                            Console.WriteLine("you've got this wrong again ;(\n");
                    }
                }
                
               
                else {
                    Console.WriteLine("your answer is wrong :( but dont worry you have one more shoot! lets try again\n");
                    string bb = null;
                    Stopwatch stopwatch3 = Stopwatch.StartNew();
                   
                    Console.WriteLine(questions[i]);
                    while (stopwatch3.ElapsedMilliseconds < timeLimit && bb == null)
                    {
                        if (Console.KeyAvailable)
                        {
                            bb = Console.ReadLine();
                        }
                    }

                    stopwatch3.Stop();
                    if (bb == null)
                    {
                        Console.WriteLine("Time's up! Moving to the next question.\n");
                        i++;
                        continue;
                    }
                    if (bb == answers[i] || bb.ToUpper() == answers[i])
                    {
                        count++;
                        Console.WriteLine("Good Job you've got this right!\n");

                    }
                    else if (bb != "A" && bb != "B" && bb != "C" && bb != "D" && bb != "a" && bb != "b" && bb != "c" && bb != "d")
                    {
                        Console.WriteLine("you've entered a not supported format \n");
                    }

                    else {
                        Console.WriteLine("you've got this wrong again ;(\n");
                    }

                   
                }

                i++;
            }
            Console.WriteLine($"your mark is {count} out of 10");
            if (count < 5)
            {
                Console.WriteLine("dont feel upset you can alwayes try again ;)");
            }
            else
            {
                Console.WriteLine(" Great job! keep it up");
            }

        }
    }
}
