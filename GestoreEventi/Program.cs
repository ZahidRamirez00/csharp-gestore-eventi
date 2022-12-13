// See https://aka.ms/new-console-template for more information
using GestoreEventi;
using System.Text;
Console.OutputEncoding = Encoding.Default;

string nomeEvento = "";
string dataEvento = "";
uint numeroPostiMassimo;
uint numeroPostiPrenotati;
/*
Console.WriteLine("Hello, World!");


Evento evento1 = new Evento("Evento1","13/12/2022",200,6);

Console.WriteLine(evento1.ToString());
*/


Console.Write("Inserisci il nome del tuo programma di eventi: ");
string titoloProgramma = Console.ReadLine();
ProgrammaEventi programmaEventi = new ProgrammaEventi(titoloProgramma);
Console.Write("Quanti eventi contiene il tuo programma? ");
uint numeroEventi = uint.Parse(Console.ReadLine());

while (programmaEventi.NumeroEventi() != numeroEventi)
{
    try
    {
        Evento evento;

        Console.Write("Inserisci il nome dell'evento: ");
        nomeEvento = Console.ReadLine();

        Console.Write("\nInserisci la data dell'evento (gg/mm/yyyy): ");
        dataEvento = Console.ReadLine();

        Console.Write("\nInserisci il numero di posti totale: ");
        numeroPostiMassimo = uint.Parse(Console.ReadLine());

        Console.Write("\nQuanti posti desideri prenotare? ");
        numeroPostiPrenotati = uint.Parse(Console.ReadLine());

        evento = new Evento(nomeEvento, dataEvento, numeroPostiMassimo, numeroPostiPrenotati);
        programmaEventi.AggiungiEvento(evento);
        //Console.WriteLine(evento2.ToString());
    }
    catch (FormatException e)
    {
        Console.WriteLine("L'input inserito è in formato errato");
    }
    catch (OverflowException e)
    {
        Console.WriteLine("Non puoi inserire numeri negativi");
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }



    

}
