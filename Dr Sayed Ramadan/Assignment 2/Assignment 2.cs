using System;

class Program
{
    
    static void PrintGradeOfSubject(int[,] students)
    {
        int rows = students.GetLength(0);  
        int cols = students.GetLength(1);  

        Console.WriteLine("\nGrade Evaluation Table");
        Console.WriteLine("-----------------------------------------------------------------------------");
        Console.WriteLine("| Student ID | Subject 1 | Subject 2 | Subject 3 | Subject 4 | Total Grade |");
        Console.WriteLine("-----------------------------------------------------------------------------");

        for (int i = 0; i < rows; i++)
        {
            Console.Write($"|    {students[i, 0],-7} |");

            // Print grades for subjects
            for (int j = 1; j < cols; j++)
            {
                string grade = GetGrade(students[i, j]);
                Console.Write($"   {grade,-7} |");
            }

            // Calculate total grade average and display it in the last column
            double totalGrade = CalculateTotalGrade(students, i);
            string totalGradeEval = GetGrade(totalGrade);
            Console.Write($"   {totalGradeEval,-9} |");

            Console.WriteLine();
        }

        Console.WriteLine("-----------------------------------------------------------------------------");

    }

    // Method to calculate the average total grade for a student
    static double CalculateTotalGrade(int[,] students, int studentIndex)
    {
        int totalScore = 0;
        int subjectCount = students.GetLength(1) - 1;  

       
        for (int j = 1; j <= subjectCount; j++)
        {
            totalScore += students[studentIndex, j];
        }

        return totalScore / (double)subjectCount;
    }

    static string GetGrade(double score)
    {
        if (score >= 85)
            return "A";
        else if (score >= 70)
            return "B";
        else if (score >= 65)
            return "C";
        else if (score >= 50)
            return "D";
        else
            return "F";
    }



    static void FailedStudents(int[,] students)
    {
        int rows = students.GetLength(0);  
        int cols = students.GetLength(1);  

        Console.WriteLine("\nStudents who failed in more than two subjects:");
        for (int i = 0; i < rows; i++)
        {
            int failCount = 0;
            for (int j = 1; j < cols; j++)
            {
                if (students[i, j] < 50)  
                {
                    failCount++;
                }
            }
            if (failCount > 2)
            {
                Console.WriteLine($"Student #{students[i, 0]} failed in {failCount} subjects.");
            }
        }
    }


    static void Main(string[] args)
    {
        int[,] students = new int[6, 5];  // 6 students, 4 subjects + 1 column for student ID
        Console.WriteLine("Input the student subjects score");

        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine($"Student #{i + 1}");
            Console.WriteLine($"---------------");
            students[i, 0] = i + 1;  // Store student ID
            for (int j = 1; j < 5; j++)  // Loop through 4 subjects
            {
                Console.Write($"Subject [{j}] Score --> ");
                students[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Print grade evaluation for each subject
        PrintGradeOfSubject(students);

        // Print the IDs of students who failed more than two subjects
        FailedStudents(students);
    }
}
