using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_02
{
    class Driver
    {
        
        public static void Main(string[] args)
        {
            var newPost = new Post("The Post", "This is a new post.");
            var postList = new PostList();
            postList.AddPost(newPost);
            newPost.UpVote();
            newPost.UpVote();
            newPost.UpVote();
            newPost.DownVote();

            newPost.ViewPost();

            Console.ReadKey(true);

            
        }
    }
    class PostList
    {
        private List<Post> _postList = new List<Post>();

        public PostList()
        {

        }

        public void AddPost(Post post)
        {
            _postList.Add(post);
        }

    }
    
    
    class Post
    {
        private DateTime _timeCreated;
        private string _description;
        private string _title;
        private int _voteCount;

        public Post()
        {
            _timeCreated = DateTime.Now;
            _voteCount = 0;
        }
        public Post(string title, string des)
            :this()
        {
            this._description = des;
            this._title = title;
        }

        public void UpVote()
        {
            _voteCount++;
        }
        public void DownVote()
        {
            _voteCount--;
        }

        public void ViewPost()
        {
            Console.WriteLine("Time posted: " + _timeCreated);
            Console.WriteLine("Title: " + _title);
            Console.WriteLine("Description: " + _description);
            Console.WriteLine("Post score: " + _voteCount);

        }


    }
}
