using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleSecondProgram.DataAccess
{
    class ReadFile : IDisposable
    {
        public StreamReader filein { get; set; }
        public ReadFile(string file)
        {
            filein = new StreamReader(file);
        }
        public List<DBO.Person> ReadData()
        {
            string line = "";
            List<DBO.Person> list = new List<DBO.Person>();
            Char[] ctab = new Char [] { ';' };
            while ((line = filein.ReadLine()) != null)
            {
                string [] tab = line.Split(ctab);                
                list.Add(new DBO.Person() { Name = tab[0], FirstName = tab[1], Adress = tab[2] });
            }
            return list;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (filein != null)
                {
                    filein.Close();
                    filein.Dispose();
                }
            }

        }
    }
}