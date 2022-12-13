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
        private uint CapacitaMassima;
        private uint PostiPrenotati;
        // STATO
        // COSTRUTTORI
        public Evento(string titolo, string data, uint capacitaMassima)
        {
            this.Titolo = titolo;
            SetData(data);
            this.CapacitaMassima = capacitaMassima;
            this.PostiPrenotati = 0;
        }
        public Evento(string titolo, string data, uint capacitaMassima, uint postiPrenotati = 0)
        {
            this.Titolo = titolo;
            SetData(data);
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

        public uint GetCapacitaMassima()
        {
            return this.CapacitaMassima;
        }

        public uint GetPostiPrenotati()
        {
            return this.PostiPrenotati;
        }
        // SETTERS
        public void SetTitolo(string titolo)
        {
            this.Titolo = titolo;
        }

        public void SetData(string data)
        {
            this.Data = DateTime.Parse(data);
        }
        // METODI PUBBLICI
        public void PrenotaPosti(uint postiPrenotati)
        {
            uint numeroPostiDisponibili = this.CapacitaMassima - this.PostiPrenotati;
            if(numeroPostiDisponibili < postiPrenotati || DateTime.Today > this.GetData())
            {
                Console.WriteLine("Il valore non può essere minore di 0 o maggiore della capacità massima (" + this.CapacitaMassima + ")");
            }
            else
            {
                this.PostiPrenotati += postiPrenotati;
            }
        }

        public void DisdiciPosti(uint prenotazioniDisdette)
        {
            uint numeroPostiDisponibili = this.CapacitaMassima - this.PostiPrenotati;
            if (DateTime.Today > this.GetData() || this.PostiPrenotati <= 0)
            {
                Console.WriteLine("Il valore non può essere minore di 0 o maggiore della capacità massima (" + this.CapacitaMassima + ")");
            }
            else
            {
                this.PostiPrenotati -= prenotazioniDisdette;
            }
        }

        public override string ToString()
        {
            return "\n\n----- "
                   + this.GetTitolo()
                   + " -----\n\nData: "
                   + this.GetData().ToString("dd/MM/yyyy")
                   + "\nCapacità massima: "
                   + this.GetCapacitaMassima()
                   + "\nPosti prenotati: "
                   + this.GetPostiPrenotati();
        }
        // METODI PRIVATI
    }
}
