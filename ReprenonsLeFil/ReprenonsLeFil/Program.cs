using System;
using System.Collections.Generic;

namespace ReprenonsLeFil
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }

    class Session
    {
        public int _Id;
        private string _DateDebut;
        private string _DateFin;
        private string _Lieu;
        private Formation _LaFormation;
        private List<Participant> _LesParticipants;

        public Session(string debut, string fin, string lieu, Formation formation)
        {
            _DateDebut = debut;
            _DateFin = fin;
            _Lieu = lieu;
            _LaFormation = formation;
        }

        public void SetLesDates(string debut, string fin)
        {
            _DateDebut = debut;
            _DateFin = fin;
        }

        public void SetLieu(string lieu)
        {
            _Lieu = lieu;
        }

        public void SetLaFormation(Formation formation)
        {
            _LaFormation = formation;
        }

        public void AjouterParticipant(Participant participant)
        {
            _LesParticipants.Add(participant);
        }
        public string StrSession()
        {
            return _LaFormation.GetNom() + ' ' + _Lieu + ' ' + _DateDebut + ' ' + _DateFin;
        }

        public int Save()
        {
            return 0;
        }
        
        public bool Delete()
        {
            return true;
        }

        public List<Participant> GetLesParticipants()
        {
            return _LesParticipants;
        }

        public bool SupprimerParticipant(Participant participant)
        {
            _LesParticipants.Remove(participant);
            return true;
        }
        
    }

    class Formation
    {
        private int _Id;
        private string _Nom;
        private int _Niveau;
        private List<Session> _LesSessions;

        public Formation(int id, string nom)
        {
            _Id = id;
            _Nom = nom;
        }

        public Formation(int id, string nom, int niveau)
        {
            _Id = id;
            _Nom = nom;
            _Niveau = niveau;
        }

        public string GetNom()
        {
            return _Nom;
        }

        public void SetNom(string nom)
        {
            _Nom = nom;
        }

        public string StrFormation()
        {
            return _Nom + ' ' + _Niveau;
        }

        public void SetLeNiveau(int niveau)
        {
            _Niveau = niveau;
        }

        public int Save()
        {
            return 0;
        }

        public Boolean Delete()
        {
            return true;
        }

        public List<Session> GetLesSessions()
        {
            return _LesSessions;
        }

    }

    class Participant
    {
        private int _Id;
        private string _Nom;
        private string _Prenom;
        private Session _LaSessionChoisie;

        public Participant(string nom, string prenom, Session session)
        {
            _Nom = nom;
            _Prenom = prenom;
            _LaSessionChoisie = session;
        }

        public void SetParticipant(string nom, string prenom, Session session)
        {
            _Nom = nom;
            _Prenom = prenom;
            _LaSessionChoisie = session;
        }

        public void SetLaSession(Session session)
        {
            _LaSessionChoisie = session;
        }

        public string StrParticipant()
        {
            return _Nom + ' ' + _Prenom;
        }

        public int Save()
        {
            return 0;
        }

        public Boolean Delete()
        {
            return true;
        }
    }
}
