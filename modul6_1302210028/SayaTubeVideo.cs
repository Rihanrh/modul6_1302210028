using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302210028
{
    internal class SayaTubeVideo
    {
        private int id;
        public string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            this.title = title;
            Random random = new Random();
            this.id = random.Next(10000, 99999);
            this.playCount = 0;
        }

        public void IncreasePlayCount(int playCount)
        {
            this.playCount += playCount;
        }

        public int GetPlayCount()
        {
            return this.playCount;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("ID\t\t: " + this.id);
            Console.WriteLine("Judul video\t: " + this.title);
            Console.WriteLine("Play count\t: " + this.playCount);
        }
    }
}
