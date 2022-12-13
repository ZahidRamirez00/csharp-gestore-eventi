// See https://aka.ms/new-console-template for more information
using GestoreEventi;

string nomeEvento = "";
string dataEvento = "";
uint numeroPostiMassimo;
uint numeroPostiPrenotati;
/*
Console.WriteLine("Hello, World!");


Evento evento1 = new Evento("Evento1","13/12/2022",200,6);

Console.WriteLine(evento1.ToString());
*/

Evento evento2;

Console.Write("Inserisci il nome dell'evento: ");
nomeEvento = Console.ReadLine();

Console.Write("\nInserisci la data dell'evento (gg/mm/yyyy): ");
dataEvento = Console.ReadLine();

Console.Write("\nInserisci il numero di posti totale: ");
numeroPostiMassimo = uint.Parse(Console.ReadLine());

Console.Write("\nQuanti posti desideri prenotare? ");
numeroPostiPrenotati = uint.Parse(Console.ReadLine());