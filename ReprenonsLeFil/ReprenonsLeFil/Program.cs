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
            return _LaFormation.GetNom();
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

        public string GetNom()
        {
            return _Nom;
        }

    }

    class Participant
    {
        private int _Id;
        private string _Nom;
        private string _Prenom;
        private Session _LaSessionChoisie;
    }
}
