// See https://aka.ms/new-console-template for more information

using modul6_1302210028;

internal class Program
{
    public static void Main(string[] args)
    {
        SayaTubeUser stu = new SayaTubeUser("Rihan");

        SayaTubeVideo stv1 = new SayaTubeVideo("VideoA");
        stv1.IncreasePlayCount(1);
        stv1.PrintVideoDetails();
        stu.AddVideo(stv1);
        stu.PrintAllVideoPlaycount(); 
    }
}