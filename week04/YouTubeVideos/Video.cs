public class Video
{
    private string _title;
    private string _author;
    private int _length;

    private List<Comment> _comments = new List<Comment>(); //create the list of comments



    public Video(string title, string author, int length)//stores the info of the video
    {
        _title = title;
        _author = author;
        _length = length;
    }


    public void StroreComment(Comment comment)
    {
        _comments.Add(comment);


    }

    public string GetTitle() //get title to take the name of the longest video to exceed requirements
    {
        return _title;
    }
    
    public int GetLength()
    {
        return _length;
    }


    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public string GetCommentsDisplay()
    {
        int commentCount = 0;
        string commentsDisplay = "";
        
        foreach (Comment comment in _comments)

        {
            commentCount += 1;
            commentsDisplay +=
                $"Comment Number {commentCount}:\n" +
                $"Commentor Name: {comment.GetName()}\n" +
                $"Comment: {comment.GetText()}\n \n";

        }

        return commentsDisplay;
    }
    
    public string DisplayVideoInfo()
    {
        string title = _title;
        string author = _author;
        string length = _length.ToString();
        int numberOfComments = GetNumberOfComments();
        string commentsDisplay = GetCommentsDisplay();




        string videoInfo =
            $"Video Title: {title}\n" +
            $"Author: {author}\n" +
            $"Length of video in seconds: {length} seconds.\n" +
            $" Number of comments: {numberOfComments} \n \n" +
            $"Comments: \n {commentsDisplay} ";


        return videoInfo;



    }
}