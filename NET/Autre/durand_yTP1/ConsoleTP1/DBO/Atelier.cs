using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTP1.DBO
{
    public class Atelier
    {
        public String Name { get; set; }
        public String Description { get; set; }
        public decimal[] TrackMark { get; set; }
        public decimal[] VivaMark   { get; set; }

        public override string ToString()
        {
            string res = "";

            for (int i = 0; i < this.TrackMark.Length; i++)
            {
                res += this.TrackMark[i].ToString ()+" ";
            }
            res += ";";

            for (int i = 0; i < this.TrackMark.Length; i++)
            {
                res += this.VivaMark[i].ToString ()+" ";
            }

            return res; 

        }
    }
}
