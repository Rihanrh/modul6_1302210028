using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302210028
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public string Username;

        public SayaTubeUser(string Username) 
        {
            this.Username = Username;
            this.uploadedVideos= new List<SayaTubeVideo>();
        }

        public int GetTotalVideoPlayCount()
        {
            int total = 0;
            foreach(SayaTubeVideo video in uploadedVideos)
            {
                total += video.GetPlayCount();
            }
            return total;
        }

        public void AddVideo(SayaTubeVideo video)
        {
            uploadedVideos.Add(video);
        }

        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine("User\t\t: " + Username);
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                Console.WriteLine("Review Film " + uploadedVideos[i].title + " Count: " + uploadedVideos[i].GetPlayCount());
            }
        }
    }
}
