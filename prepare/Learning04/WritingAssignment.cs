class WritingAssingment :Assignment
{
    private string _title = " ";

    public WritingAssingment(string studentName, string topic, string title)
    : base(studentName, topic)
    {
        _title = title;
    }
    public string GetWritingInformation()
    {
        return "Title " + _title;
    }
}