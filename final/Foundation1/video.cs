using System;

namespace YouTubeVideos
{
    
    public class Video
    {
        public string Title { get; }
        public string Author { get; }
        public int Length { get; } // Length in seconds
        private List<Comment> Comments { get; }

        public Video(string title, string author, int length)
        {
            Title = title;
            Author = author;
            Length = length;
            Comments = new List<Comment>();
        }

        
        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        public int GetNumberOfComments()
        {
            return Comments.Count;
        }

       
        public IEnumerable<Comment> GetComments()
        {
            return Comments.AsReadOnly();
        }
    }
}
