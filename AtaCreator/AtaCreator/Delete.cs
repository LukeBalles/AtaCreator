using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtaCreator
{
    internal class Delete
    {
        public string text;
        public void del()
        {
            File.Delete(text);
            Console.WriteLine();
            Console.WriteLine("The Ata has been deleted");
        }
    }
}
