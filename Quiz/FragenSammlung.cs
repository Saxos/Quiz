using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    
    class FragenSammlung
    {
        List<Frage> fragen = new List<Frage>();

        public void AddFrage(Frage f)
        {
            fragen.Add(f);
        }
        public void RemoveFrageAt(Int32 f)
        {
            fragen.RemoveAt(f);
        }
        public Frage RandomFrage()
        {
            Random r = new Random();
            return fragen[r.Next(0,500) + 1];
        }
        public int FragenAnzahl()
        {
            return fragen.Count;
        }
    }
}
