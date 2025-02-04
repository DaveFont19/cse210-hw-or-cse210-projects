class Math: Assignment
{
    private string  _textbookSection, _problems;
    public Math(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic){
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList(){
        return ($"{_textbookSection} {_problems}");
    }
}