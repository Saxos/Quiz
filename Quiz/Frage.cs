using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    class Frage
    {
        List<String> antworten;
        public Frage(Int32 id, String frage, String a1, String a2, String a3, String a4, Int32 gebiet)
        {
            antworten = new List<string>();
            Id = id;
            FrageString = frage;
            antworten.Add(a1);
            antworten.Add(a2);
            antworten.Add(a3);
            antworten.Add(a4);
            Gebiet = gebiet;
            Shuffle();
        }

        public Int32 Id { get; set; }
        public String FrageString { get; set; }
        public Int32 Gebiet { get; set; }
        public String RichtigeFrage{ get;set; }
        public void Shuffle()
        {
            
            Random r = new Random();
            for(int i = 0; i < 6; i++)
            { 
                int r1 = r.Next(0, 4);
                int r2 = r.Next(0, 4);
                if(r1 != r2)
                {
                    String s = antworten[r1];
                    antworten[r1] = antworten[r2];
                    antworten[r2] = s;
                }

            }
        }
        public String getFrage(int i)
        {
            if(i > -1 && i <= 3)
            {
                return antworten[i];
            }
            return "Index out of bound(getFrage()";
        }

    }
}
