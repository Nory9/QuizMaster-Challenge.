namespace quizmaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StartQuiz.quiz();
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong please try again!");
            }
            finally {
                Console.WriteLine("\nthank you for using and supporting QuizMaster :)");
            }
          
        }
    }
}
