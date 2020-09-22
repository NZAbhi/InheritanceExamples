using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InheritanceExamples
{
    class VideoPost:Post
    {
        //member field
        protected bool isPlaying=false;
        protected int currentDuration = 0;
        Timer timer;



        //properties
        protected string VideoURL { get; set; }
        protected int Lenth { get; set; }

        public VideoPost() { }

        public VideoPost(string title, bool isPublic, string videoURL, int lenth , string sendByUserName)
        {
            this.ID = GetPostID();
            this.Title = title;
            this.IsPublic = isPublic;
            this.SendByUserName = sendByUserName;

            this.VideoURL=videoURL;
            this.Lenth = lenth;

        }
        public void Play()
        {
            if (!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Playing");
                timer = new Timer(TimerCallback, null, 0, 1000);
            }
            
        }

        private void TimerCallback(object obj)
        {
            if (currentDuration<Lenth)
            {
                currentDuration++;
                Console.WriteLine($"Video at {currentDuration}sec");
                GC.Collect();
            }
            else 
            {
                Stop();
            }

        }
        public  void Stop()
        {
            if (isPlaying)
            {
                isPlaying = false;
                Console.WriteLine($"Stoped at {currentDuration}sec");
                currentDuration = 0;
                timer.Dispose();
            }
           
        }


        public override string ToString()
        {
            return String.Format($"{this.ID} - {this.Title} : {this.VideoURL}: {this.Lenth} - by {this.SendByUserName}");
        }




    }
}
