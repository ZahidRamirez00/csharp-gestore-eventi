using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    public class ProgrammaEventi
    {
        // PROPRIETA / ATTRIBUTI
        private string Titolo;
        private List<Evento> Eventi;
        // STATO
        // COSTRUTTORI
        public ProgrammaEventi(string titolo)
        {
            this.Titolo = titolo;
            this.Eventi = new List<Evento>();
        }
        // GETTERS
        public string GetTitolo()
        {
            return this.Titolo;
        }
        // SETTERS
        // METODI PUBBLICI
        public void AggiungiEvento(Evento Evento)
        {
            this.Eventi.Add(Evento);
        }

        public List<Evento> EventiInData(string stringData)
        {
            DateTime data = DateTime.Parse(stringData);
            List<Evento> ListaEventiInData = new List<Evento>();
            foreach (Evento evento in this.Eventi)
            {
                if (evento.GetData() == data)
                {
                    ListaEventiInData.Add(evento);
                }
            }
            return ListaEventiInData;
        }

        public static string StampaListaEventi(List<Evento> ListaEventi)
        {
            string stringaEventi = "\n";
            foreach (Evento evento in ListaEventi)
            {
                stringaEventi += evento.ToString();
                stringaEventi += "\n";
            }
            return stringaEventi;
        }

        public int NumeroEventi()
        {
            return this.Eventi.Count();
        }

        public void SvuotaListaEventi()
        {
            this.Eventi.Clear();
        }

        public override string ToString()
        {
            string ListaEventi = this.GetTitolo() + ":\n";
            ListaEventi += ProgrammaEventi.StampaListaEventi(this.Eventi);
            return ListaEventi;
        }
        // METODI PRIVATI
    }
}
