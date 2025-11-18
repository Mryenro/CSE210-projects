using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");




        //creating the videos
        Video video1 = new Video("How to cook rice", "Chef Mouha", 320);
        Video video2 = new Video("Learn C# Basics", "John Doe", 600);
        Video video3 = new Video("Age Of Empires building order to fast castle", "Hera", 540);
        Video video4 = new Video("Travel Vlog: Japan", "Hamza", 900);

        List<Video> videos = new List<Video>() {video1, video2, video3, video4};



        // Add comments to video 1
        video1.StroreComment(new Comment("Hamid Cherkaoui", "Great video!"));
        video1.StroreComment(new Comment("Mouad Sendaji", "Very helpful, thanks!"));
        video1.StroreComment(new Comment("Yassine", "Could you make more?"));
        video1.StroreComment(new Comment("Sara", "Nice tutorial!"));

        // Add comments to video 2
        video2.StroreComment(new Comment("Ali", "C# is awesome!"));
        video2.StroreComment(new Comment("Mohammed", "Very clear explanation."));
        video2.StroreComment(new Comment("Malak", "Loved it."));
        video2.StroreComment(new Comment("Layla", "Thanks for sharing!"));

        // Add comments to video 3
        video3.StroreComment(new Comment("Samir", "This made my day."));
        video3.StroreComment(new Comment("Imane", "Hahaha so funny."));
        video3.StroreComment(new Comment("Karim", "More AOE2 videos please."));
        video3.StroreComment(new Comment("Laila", "Super cute!"));

        // Add comments to video 4
        video4.StroreComment(new Comment("Adam", "Japan looks amazing."));
        video4.StroreComment(new Comment("Omar", "Great vlog!"));
        video4.StroreComment(new Comment("Fatima", "Nice editing."));
        video4.StroreComment(new Comment("Aya", "I want to go to Tokyo now!"));

        video1.DisplayVideoInfo();

        foreach (Video video in videos)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine(video.DisplayVideoInfo());
            Console.WriteLine("--------------------------------\n");
        }

        //exceed requirement, most viewed video:
        string longestVid = "";
        int longestLength = 0;
        foreach (Video video in videos)
        {
            if (longestLength < video.GetLength())
            {
                longestVid = video.GetTitle();
                longestLength = video.GetLength();
            }
        }

        Console.WriteLine("--------------------------------");
        Console.WriteLine($"Longest video is {longestVid} , with {longestLength} \n ");





    }
}