public class Comment
{
    private string _commenterName;
    private string _commenterText;

    public Comment(string commenterName, string commenterText)
    {
        _commenterName = commenterName;
        _commenterText = commenterText;
    }

    public string GetCommenterName()
    {
        return _commenterName;
    }

    public string GetCommenterText()
    {
        return _commenterText;
    }
}
