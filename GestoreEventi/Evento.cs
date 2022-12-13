using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    public class Evento
    {
        // PROPRIETA / ATTRIBUTI
        private string Titolo;
        private DateTime Data;
        private int CapacitaMassima;
        private int PostiPrenotati;
        // STATO
        // COSTRUTTORI
        public Evento(string titolo, DateTime data, int capacitaMassima, int postiPrenotati = 0) 
        {
            this.Titolo = titolo;
            this.Data = data;
            this.CapacitaMassima = capacitaMassima;
            this.PostiPrenotati = postiPrenotati;
        }
        // GETTERS
        public string GetTitolo()
        {
            return this.Titolo;
        }

        public DateTime GetData()
        {
            return this.Data;
        }

        public int GetCapacitaMassima()
        {
            return this.CapacitaMassima;
        }
        // SETTERS
        public void SetTitolo(string titolo)
        {
            this.Titolo = titolo;
        }

        public void SetData(DateTime data)
        {
            this.Data = data;
        }
        // METODI PUBBLICI
        public void PrenotaPosti()
        {
            if(this.PostiPrenotati < this.CapacitaMassima || this.PostiPrenotati >= 0)
            {
                this.PostiPrenotati++;
            }
            else
            {
                Console.WriteLine("Il valore non può essere minore di 0 o maggiore della capacità massima (" + this.CapacitaMassima + ")");
            }
        }
        // METODI PRIVATI
    }
}
