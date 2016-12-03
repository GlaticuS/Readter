using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ReadteR
{
    public class Structs
    {
        public struct RootWord
        {
            public bool Start;
            public bool End;
            public string Word;
            public int ChildCount;
            public Hashtable Childs;
        }
        public struct Child
        {
            public int Occurrence;
            public string Word;
        }
    }
    public class MarkovChain
    {
        ArrayList startindex = new ArrayList();
        public Hashtable Words = new Hashtable(1024, .1f);
        public void Load(string Input)
        {
            startindex = new ArrayList();
            Words = new Hashtable(1024, .1f);
            Structs.RootWord w = new Structs.RootWord();
            Structs.Child c = new Structs.Child();
            string[] s = Input.Replace("\r\n", " ").Replace("\n", " ").Replace("\n\n", " ").Replace("\t", " ").Replace("  ", " ").Split(' ');
            foreach(var piece in s)
            {
                if(piece.StartsWith("https:"))
                { 
                    var tmp = new List<string>(s); // Преобразование в список
                    tmp.Remove(piece); // Удаление элемента
                    s = tmp.ToArray(); // Преобразование в массив
                    //Array.Clear(s, Array.IndexOf(s, piece, 1), 1);
                }
            }

           // for(int i = 0; i < s.Length; i++)
           //     Console.WriteLine("all string: {0}\n", s[i]);

            string s1 = "";
            bool NextisStart = false;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == "")
                    continue;
                s1 = s[i].ToLower();
               // Console.WriteLine("s1 = {0}\n", s1);
                w = new Structs.RootWord();
                c = new Structs.Child();
                if (Words.ContainsKey(s1))
                {//Already Exists, add new child word or update count of existing child word
                    if (i < s.Length - 1)
                    {
                        w = (Structs.RootWord)Words[s1];
                        if (NextisStart)
                        {
                            w.Start = true;
                            NextisStart = false;
                            startindex.Add(s1);
                        }
                        if (w.Childs.ContainsKey(s[i + 1].ToLower())) //Exists, just update count
                        {
                            c = (Structs.Child)w.Childs[s[i + 1].ToLower()];
                            c.Occurrence++;
                            w.Childs.Remove(s[i + 1].ToLower());
                        }
                        else //Doesn't Exist, add new word
                        {
                            c.Word = s[i + 1];
                            c.Occurrence = 1;

                        }
                        w.ChildCount++;
                        w.Childs.Add(s[i + 1].ToLower(), c);

                        Words.Remove(s1);
                        Words.Add(s1, w);
                        //Console.WriteLine("w_old = {0}\n", w.Word);
                    }
                }
                else
                {//New Word
                    w = new Structs.RootWord();
                    w.Childs = new Hashtable();
                    if (i == 0)
                    {
                        w.Start = true;
                        startindex.Add(s1);
                    }
                    w.Word = s[i];
                    if (i < s.Length - 1)
                    {
                        c.Word = s[i + 1];
                        c.Occurrence = 1;
                        w.Childs.Add(s[i + 1].ToLower(), c);
                        w.ChildCount = 1;
                    }
                    else
                        w.End = true;
                    if (s1.Substring(s1.Length - 1, 1) == ".")
                    {
                        w.End = true;
                        NextisStart = true;
                    }
                    else if (NextisStart)
                    {
                        w.Start = true;
                        NextisStart = false;
                        startindex.Add(s1);
                    }
                    Words.Add(s1, w);
                   // Console.WriteLine("w_new = {0}\n", w.Word);
                }
            }
        }
        public string Output()
        {
            string output = "";
            Random r = new Random(Environment.TickCount + startindex.Count + 1);
            Structs.RootWord w = (Structs.RootWord)Words[((string)startindex[r.Next(startindex.Count)]).ToLower()];
            output = w.Word + " ";
            //Console.WriteLine("output = {0}\n", output);
            Structs.Child c = new Structs.Child();
            ArrayList a = new ArrayList();
            int pos = 0;
            int rnd = 0; int min = 0; int max = 0;
            do
            {
                rnd = r.Next(w.ChildCount + 1);
                pos = 0;
                foreach (object x in w.Childs)
                {
                    c = (Structs.Child)w.Childs[((DictionaryEntry)x).Key];
                    min = pos;
                    pos += c.Occurrence; //bigger slice for more occurrences
                    max = pos;
                    if (min <= rnd & max >= rnd)
                    {
                        output += c.Word + " ";
                        if(c.Word != null && Words[c.Word.ToLower()] != null)
                        {
                            w = (Structs.RootWord)Words[c.Word.ToLower()];
                            //Console.WriteLine("w_end = {0}\n", w.Word);
                        }
                                 
                        break;
                    }
                }
                if (output.Length > 140)
                    break;
            } while (!w.End);

            Console.WriteLine("output_end = {0}\n", output);
            return output;
        }
    }
}
