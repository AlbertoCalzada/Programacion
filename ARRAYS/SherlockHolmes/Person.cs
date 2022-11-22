using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adn
{
    class Person
    {
        string name;
        string surName;
        string adn;

        public Person()
        {
            name = "Npersona";
            surName = "SurNpersona";
            adn = "";
        }

        public Person(string newName, string newSurname)
        {
            name = newName;
            surName = newSurname;
            adn = "";
        }

        //Hacemos los getter
        public string GetName()
        {
            return name;
        }

        public string GetSurName()
        {
            return surName;
        }

        public string GetAdn()
        {
            return adn;
        }

        //Hacemos los setter

        public void SetName(string newName)
        {
            name = newName;
        }

        public void SetSurName(string newSurName)
        {
            surName = newSurName;
        }

        public void SetAdn(string newAdn)
        {
            adn = newAdn;
        }
    }
}
