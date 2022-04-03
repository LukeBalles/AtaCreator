using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AtaCreator
{
    internal class Creator
    {
        public ArrayList names = new ArrayList();
        public string title;
        public int numbPart = 1;
        public string description;
        public string text;
        int i = 1;
        public void Cre()
        {
            

            using (StreamWriter sw = new StreamWriter(text))
            {
                var date = DateTime.Now;
                sw.WriteLine($"Title of meeting: {title}");
                sw.WriteLine();
                sw.WriteLine($"Description: {description}");
                sw.WriteLine();
                sw.WriteLine($"Number of participants: {numbPart}");
                sw.WriteLine();
                foreach (string name in names)
                {  
                    sw.WriteLine($"{i}º Participant: {name}");
                    i++;
                }
                sw.WriteLine();
                sw.WriteLine($"Date: {date}");
                Console.WriteLine("The Ata was created!");
            }
        }
    }
}
