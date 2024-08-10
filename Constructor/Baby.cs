using Constructor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Constructor
{
    public class Baby
    {
        public string _name;
        public string _surname;
        public DateTime _date;


        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
            }
        }

        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
            }
        }


        public Baby(string name, string surname)
        {
            _name = name;
            _surname = surname;
            _date = DateTime.Now;
            Console.WriteLine("Ingaaaa");
        }


        public Baby()
        {
            _date = DateTime.Now;
            Console.WriteLine("Ingaaaa");
        }

        public void Baby1()
        {
            Console.WriteLine("Bebeğin adı: " + _name + "\nSoyadı: " + _surname + "\nDoğum tarihi ve saati: " + DateTime.Now);
        }

        public void Baby2()
        {
            Console.WriteLine("Bebeğin doğum tarihi ve saati: " + DateTime.Now);
        }
    }
}
