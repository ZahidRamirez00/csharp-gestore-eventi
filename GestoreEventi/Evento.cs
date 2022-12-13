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
        public Evento(string titolo, DateTime data, int capacitaMassima, int postiPrenotati) 
        {
            this.Titolo = titolo;
            this.Data = data;
            this.CapacitaMassima = capacitaMassima;
            this.PostiPrenotati = postiPrenotati;
        }
        // GETTERS

        // SETTERS
        // METODI PUBBLICI
        // METODI PRIVATI
    }
}
