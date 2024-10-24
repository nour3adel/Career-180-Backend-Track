namespace Day4
{
    public class Question
    {
        public string QuestionBody { get; set; }
        public int Mark { get; set; }

        public Question(string questionText, int mark)
        {
            QuestionBody = questionText;
            Mark = mark;
        }

        public override string ToString()
        {
            return $"{QuestionBody} : ({Mark} marks)";
        }
    }
}
