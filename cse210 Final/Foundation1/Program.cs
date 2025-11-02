using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video eatingVideo = new Video("How to eat", "Avery Krall", 120);
        eatingVideo.AddComment("James", "Great Video");
        eatingVideo.AddComment("Peter", "Well Done");
        eatingVideo.AddComment("John", "Interesting");
        eatingVideo.AddComment("Mark", "Love it");
        videos.Add(eatingVideo);

        Video runningVideo = new Video("How to run", "John Burkey", 80);
        runningVideo.AddComment("Cailah", "I love running");
        runningVideo.AddComment("Bethany", "So Helpful");
        runningVideo.AddComment("Linsey", "Thanks!");
        videos.Add(runningVideo);

        Video sleepingVideo = new Video("How to sleep", "Chris Pratt", 40);
        sleepingVideo.AddComment("Nick", "First Comment!");
        sleepingVideo.AddComment("Robin", "First Comment!");
        sleepingVideo.AddComment("Parker", "ZZZZZZZ");
        sleepingVideo.AddComment("Danny", "Relaxing");
        videos.Add(sleepingVideo);

        foreach (Video video in videos)
        {
            video.GetInfo();
            Console.WriteLine("Press enter to see comments");
            Console.ReadLine();
            video.ShowComments();
            Console.WriteLine("Press enter to view the next video: ");
            Console.ReadLine();
        }
    }
}