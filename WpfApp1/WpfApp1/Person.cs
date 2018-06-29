using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Person
    {
        private string _nom;
        private string _prenom;
        private int _id;

        public Person(string nom, string prenom, int id)
        {
            Nom = nom;
            Prenom = prenom;
            Id = id;
        }

        public string Nom
        {
            get
            {
                return _nom;
            }
            set
            {
                _nom = value;
            }
        }
        
        public string Prenom
        {
            get
            {
                return _prenom;
            }
            set
            {
                _prenom = value;
            }
        }

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        
    }
}
