namespace quizmaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] ss = questions();
                string[] aa = answers();
                int c = StartQuiz.quiz(ss, aa);
                Console.WriteLine($"your mark is {c} out of 10");
                if (c < 5)
                {
                    Console.WriteLine("dont feel upset you can alwayes try again ;)");
                }
                else
                {
                    Console.WriteLine(" Great job! keep it up");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong please try again!");
            }
            finally {
                Console.WriteLine("thank you for using and supporting QuizMaster :)");
            }
          
        }
        /*for (int i = 0;i< ss.Length;i++) {
                Console.WriteLine(ss[i]);
                Console.WriteLine();
                Console.WriteLine(aa[i]);
            }*/
        static string[] questions()
        {
            string[] q = { "1. C# is a programming language, developed by ___.\nA. Oracle\r\nB. Microsoft\r\nC. GNU project\r\nD. Google", "2. C# runs on the ___.\r\n\r\nA. .NET Framework\r\nB. Java Virtual Machine\r\nC. Both A. and B.\r\nD. None of the above", "3. Is C# an object-oriented programming language?\r\n\r\nA. Yes\r\nB. No", "4. What is CLR in C#?\r\n\r\nA. It is a virtual machine component of Microsoft .NET Framework\r\nB. It is a virtual machine component of JVM\r\nC. It is a compiler to compiler the C# code\r\nD. All of the above", "5. Is C# programming language a case-sensitive?\r\n\r\nA. Yes\r\nB. No", "6.What is the correct syntax to declare a variable in C#?\r\n\r\nA. type variableName = value;\r\nB. type variableName;\r\nC. variableName as type = value;\r\nD. Both A. and B.", "7.Which C# keyword is used to define a constant?\r\n\r\nA. define\r\nB. fixed\r\nC. constant\r\nD. const", "8.Which is not a valid C# data type?\r\n\r\nA. long\r\nB. int\r\nC. float\r\nD. complex", "9. What is 'Console' in C#?\r\n\r\nA. Class\r\nB. Object\r\nC. Method\r\nD. Structure", "10.Which is/are the correct method(s) to input a float value in C#?\r\n\r\nA. Parse(Console.ReadLine())\r\nB. ToSingle(Console.ReadLine())\r\nC. ToFloat(Console.ReadLine());\r\nD. Both A and B" };
            return q;
        }
        static string[] answers() {
            string[] s = { "B", "A","A","A","A","D","D","D","A","B" };
            return s;
        }
    }
}
