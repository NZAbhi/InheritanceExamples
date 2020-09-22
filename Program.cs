
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Thanks for Wishes",true,"BJ");
            Console.WriteLine(post1.ToString());

            //
            ImagePost imagePost1 = new ImagePost("Check out my new Shoes",true,
                                                     "https://images.com/shoes","CZ");

            Console.WriteLine(imagePost1.ToString());
            
            //

            VideoPost videoPost1 = new VideoPost("Check my new video:",true,
                                                     "https://video.com/myVideo",3,"VZ");

            Console.WriteLine(videoPost1.ToString());

            videoPost1.Play();
            Console.WriteLine("Press any key to stop the video!!");
            Console.ReadKey();
            videoPost1.Stop();

            Console.ReadLine();
        }
    }
}
