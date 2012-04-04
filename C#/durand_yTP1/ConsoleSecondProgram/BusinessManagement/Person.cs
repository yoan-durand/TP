using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleSecondProgram.BusinessManagement
{
    public static class Person
    {
        public static List<DBO.Person> ReadData(string filename)
        {
            try
            {
                DataAccess.ReadFile read = new DataAccess.ReadFile(filename);

                return read.ReadData();
            }
            catch (Exception e)
            {

                DataAccess.ReadFile dispo = new DataAccess.ReadFile("");
                dispo.Dispose();

                throw (e);

            }

        }
    }
}
