// See https://aka.ms/new-console-template for more information

using modul6_1302210028;

internal class Program
{
    public static void Main(string[] args)
    {
        try
        {
            SayaTubeUser stu = new SayaTubeUser("Rihan");
            SayaTubeVideo stv1 = new SayaTubeVideo("VideoA");
            stv1.IncreasePlayCount(1);
            stv1.PrintVideoDetails();
            Console.WriteLine("");

            SayaTubeVideo stv2 = new SayaTubeVideo("VideoB");
            stv2.IncreasePlayCount(1);
            stv2.PrintVideoDetails();
            Console.WriteLine("");

            SayaTubeVideo stv3 = new SayaTubeVideo("VideoC");
            stv3.IncreasePlayCount(1);
            stv3.PrintVideoDetails();
            Console.WriteLine("");

            SayaTubeVideo stv4 = new SayaTubeVideo("VideoD");
            stv4.IncreasePlayCount(1);
            stv4.PrintVideoDetails();
            Console.WriteLine("");

            SayaTubeVideo stv5 = new SayaTubeVideo("VideoE");
            stv5.IncreasePlayCount(1);
            stv5.PrintVideoDetails();
            Console.WriteLine("");

            SayaTubeVideo stv6 = new SayaTubeVideo("VideoF");
            stv6.IncreasePlayCount(1);
            stv6.PrintVideoDetails();
            Console.WriteLine("");

            SayaTubeVideo stv7 = new SayaTubeVideo("VideoG");
            stv7.IncreasePlayCount(1);
            stv7.PrintVideoDetails();
            Console.WriteLine("");

            SayaTubeVideo stv8 = new SayaTubeVideo("VideoH");
            stv8.IncreasePlayCount(1);
            stv8.PrintVideoDetails();
            Console.WriteLine("");

            SayaTubeVideo stv9 = new SayaTubeVideo("VideoI");
            stv9.IncreasePlayCount(1);
            stv9.PrintVideoDetails();
            Console.WriteLine("");

            SayaTubeVideo stv10 = new SayaTubeVideo("VideoJ");
            stv10.IncreasePlayCount(1);
            stv10.PrintVideoDetails();
            Console.WriteLine("");

            stu.AddVideo(stv1);
            stu.AddVideo(stv2);
            stu.AddVideo(stv3);
            stu.AddVideo(stv4);
            stu.AddVideo(stv5);
            stu.AddVideo(stv6);
            stu.AddVideo(stv7);
            stu.AddVideo(stv8);
            stu.AddVideo(stv9);
            stu.AddVideo(stv10);

            stu.PrintAllVideoPlaycount();

            Console.WriteLine("Total Playcount: " +stu.GetTotalVideoPlayCount());
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        

    }
}