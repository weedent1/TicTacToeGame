using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weeden_Assignment9
{
    class Info
    {
        public void DisplayInfo(string assignment)
        {

            Console.WriteLine("********************************************************************************");
            Console.WriteLine();
            Console.WriteLine("Name:\t\tTristan Weeden");
            Console.WriteLine("Course:\t\tITDEV-115-200");
            Console.WriteLine("Instructor:\tJanese Christie");
            Console.WriteLine("Assignment:\t" + assignment);
            Console.WriteLine("Date:\t\t" + System.DateTime.Today.ToShortDateString());
            Console.WriteLine();
            Console.WriteLine("********************************************************************************");


        }

    }
}
