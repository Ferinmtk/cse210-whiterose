using System;

namespace YouTubeVideos
{
    
    public class Comment
    {
        public string CommenterName { get; }
        public string Text { get; }

        public Comment(string commenterName, string text)
        {
            CommenterName = commenterName;
            Text = text;
        }
    }
}
