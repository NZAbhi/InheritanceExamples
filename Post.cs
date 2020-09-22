using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExamples
{
    class Post
    {
        private static int currentPostId;

        //properties
        protected int ID { get; set; }
        protected string Title { get; set; }
        protected bool IsPublic { get; set; }
        protected   string SendByUserName { get; set; }

        //defult Constructor
        public Post()
        {

            ID = 0;
            Title = "My first post";
            IsPublic = true;
            SendByUserName = "NZ";
        }

        //instance constructor that has three parameters
        public Post(string title,bool isPublic, string sendByUserName)
        {
            this.ID = GetPostID();
            this.Title = title;
            this.IsPublic = isPublic;
            this.SendByUserName = sendByUserName;

        }

        protected int GetPostID()
        {
            return ++currentPostId;
        }

        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        public override string ToString()
        {
            return String.Format($"{this.ID} - {this.Title} - by {this.SendByUserName}");
        }
    }
}
