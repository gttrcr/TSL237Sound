using System;
using System.Collections.Generic;

namespace A5000
{
    class Note
    {
        string n;
        double d;
        List<string> note = new List<string>();

        public Note()
        {
            note.Add("DO");
            note.Add("RE");
            note.Add("MI");
            note.Add("FA");
            note.Add("SOL");
            note.Add("LA");
            note.Add("SI");
            note.Add("DO#");
            note.Add("RE#");
            note.Add("MI#");
            note.Add("FA#");
            note.Add("SOL#");
            note.Add("LA#");
            note.Add("SI#");
            note.Add("DOb");
            note.Add("REb");
            note.Add("MIb");
            note.Add("FAb");
            note.Add("SOLb");
            note.Add("LAb");
            note.Add("SIb");
        }

        public string Nome
        {
            get
            {
                return n;
            }
            set
            {
                n = value;
                if (!note.Contains(n.Substring(0, n.Length-1))) throw new Exception("Nota non trovata");
            }
        }

        public double Durata
        {
            get
            {
                return d;
            }
            set
            {
                d = value;
            }
        }
    }
}