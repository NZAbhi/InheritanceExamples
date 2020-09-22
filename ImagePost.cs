using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExamples
{
    class ImagePost:Post
    {
        public string ImageURL { get; set; }
        public ImagePost() { }
        public ImagePost(string title, bool isPublic, string imageURL, string sendByUserName)
        {
            this.ID = GetPostID();
            this.Title = title;
            this.IsPublic = isPublic;
            this.SendByUserName = sendByUserName;

            this.ImageURL = imageURL;
        }
        public override string ToString()
        {
            return String.Format($"{this.ID} - {this.Title} : {this.ImageURL} - by {this.SendByUserName}");
        }
    }
}
