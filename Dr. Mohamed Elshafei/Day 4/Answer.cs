namespace Day4
{
    class Answer
    {
        public int Number { get; set; }
        public string ChoiceBody { get; set; }

        public Answer(int number, string choiceBody)
        {
            Number = number;
            ChoiceBody = choiceBody;
        }

        public override string ToString()
        {
            return $"{Number}. {ChoiceBody}";
        }

    }
}
