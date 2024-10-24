namespace Day4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var exam = CreateExam();
            DisplayExam(exam);
        }

        #region Exam ( Questions & Answers)
        static Dictionary<Question, List<Answer>> CreateExam()
        {

            Question q1 = new Question("What is Inheritance in OOP?", 10);

            List<Answer> answers1 = new List<Answer>
            {
                new Answer(1, "A way to reuse code from another class"),
                new Answer(2, "A mechanism to protect data"),
                new Answer(3, "A type of loop structure"),
                new Answer(4, "A method to manage access to variables")
            };


            Question q2 = new Question("What is Encapsulation in OOP?", 8);

            List<Answer> answers2 = new List<Answer>
            {
                new Answer(1, "A way to hide implementation details from users"),
                new Answer(2, "A method to inherit methods from another class"),
                new Answer(3, "A design pattern to improve performance"),
                new Answer(4, "A mechanism to create new objects")

            };

            Question q3 = new Question("Which of the following is an OOP principle?", 7);


            List<Answer> answers3 = new List<Answer>
            {
                new Answer(1, "Inheritance"),
                new Answer(2, "Polymorphism"),
                new Answer(3, "Encapsulation"),
                new Answer(4, "All of the above")
            };

            Question q4 = new Question("What is the purpose of a Constructor in OOP?", 6);

            List<Answer> answers4 = new List<Answer>
            {
                new Answer(1, "To initialize an object when it is created"),
                new Answer(2, "To destroy objects when they are no longer needed"),
                new Answer(3, "To create new methods inside a class"),
                new Answer(4, "To handle exceptions in OOP")
            };


            Dictionary<Question, List<Answer>> exam = new Dictionary<Question, List<Answer>>
            {
                { q1, answers1 },
                { q2, answers2 },
                { q3, answers3 },
                { q4, answers4 }
            };

            return exam;
        }

        #endregion

        #region Print Exam
        static void DisplayExam(Dictionary<Question, List<Answer>> exam)
        {
            foreach (var q in exam)
            {
                Console.WriteLine(q.Key);
                foreach (var a in q.Value)
                {
                    Console.WriteLine(a);
                }
                Console.WriteLine();
            }
        }

        #endregion
    }


}
