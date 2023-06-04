using System;

class MathAssignment : Assignment
{
    private string _textbookSection = " ";
    private string _problems = " ";
    public MathAssignment(string studentName, string topic, string textbookSection, string problmes)
        : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problmes;
    }
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems{_problems}";
    }
}