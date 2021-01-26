using System;
using System.Collections.Generic;
using System.Text;

namespace _003_T2K2_Uhrzeit
{
     class Uhrzeit
    {
        private long sec;

        public bool setUhrzeit(int h, int m, int s)
        {
            sec = (h * 60 * 60) + (m * 60) + s;
            return true;
        }

        public void Add(int hadd, int madd, int sadd)
        {
            long new_time = (hadd*60*60) + (madd*60) + sadd;
            while(new_time / 3600 >= 24)
            {
                new_time -= 24*3600;
            }
            sec = sec + new_time;
        }

        public void Sub(int hsub, int msub, int ssub)
        {
            long new_time = (hsub * 60 * 60) + (msub * 60) + ssub;
            new_time = sec - new_time;
            while (new_time<0)
            {
                new_time += 24 * 3600;
            }
            sec = new_time;
        }

        public void Diff(int hdiff, int mdiff, int sdiff)
        {
            long new_time = (hdiff * 60 * 60) + (mdiff * 60) + sdiff;
            new_time = new_time - sec ;

            int h = Convert.ToInt32(new_time / 3600);
            new_time = new_time % 3600;
            if(new_time < 0) //damit nur die Stunden als negativ angezeigt werden
            {
                new_time *= -1;
            }
            int m = Convert.ToInt32(new_time / 60);
            new_time = new_time % 60;
            int s = Convert.ToInt32(new_time);
            Console.WriteLine("Differenz: {0}:{1}:{2}", h.ToString("00"), m.ToString("00"), s.ToString("00"));
        }

        public void Drucken()
        {
            long sekunden = sec;
            int h = Convert.ToInt32(sekunden / 3600);
            if(h > 23)// Wenn Tag übersprungen wird
            {
                h -= 24;
            }
            else if (h < 0)//Wenn Tag negativ übersprungen wird
            {
                h += 24;
            }
            sekunden = sekunden % 3600;
            int m = Convert.ToInt32(sekunden / 60);
            sekunden = sekunden % 60;
            int s = Convert.ToInt32(sekunden);
            Console.WriteLine("Uhrzeit: {0}:{1}:{2}", h.ToString("00"), m.ToString("00"), s.ToString("00"));
        }
    }
}
