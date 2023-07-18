class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public string DisplayInfo()
    {
        string info = $"Title: {_title}\nAuthor: {_author}\nLength: {_length} seconds\n" +
                      $"Number of comments: {GetNumberOfComments()}\n";

        foreach (Comment comment in _comments)
        {
            info += $"Comment by {comment.GetCommentInfo()}\n";
        }

        return info;
    }
}
