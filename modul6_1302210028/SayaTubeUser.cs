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
            // Prekondisi 1 : Username memiliki panjang maksimal 100 karakter dan tidak berupa null.
            Debug.Assert(Username != null && Username.Length <= 100, "Username null atau lebih dari 100 karakter");
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
            Debug.Assert(video != null && video.GetPlayCount() != 2147483647, "Video null atau playCount melebihi integer maximum");
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
