using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gustavooo
{
    

    public class Person
    {

        static void Main()
        {
            
        }
        private string _name;
        private double _savemoney;

        public string Name { get; }
        public double SaveMoney { get { return _savemoney; } }



        public Person(string name, double savemoney)
        { Name = name;
         _savemoney = savemoney; }

        public string ChangeName(string name) { _name = name; return _name; }

        public double Save(double save) { _savemoney += save; return _savemoney; }
        public double Spend(double save) { _savemoney -= save; return _savemoney; }

    }

}
