using System;
using System.Collections.Generic;

public class Corso
{
    public string NomeCorso;
    public int DurataOre;
    public string Docente;
    public List<string> Studenti = new List<string>();

    public void AggiungiStudente(string nomestudente)
    {
        Studenti.Add(nomestudente);
    }

    public virtual string ToString()
    {
        return $"Corso: {NomeCorso}, Durata: {DurataOre} ore, Docente: {Docente}, Studenti: {string.Join(", ", Studenti)}";
    }

    public virtual void MetodoSpeciale()
    {
        Console.WriteLine("Messaggio generico....");
    }

}

public class Programms
{
    static List<Corso> corsi = new List<Corso>();
    public static void Main()
    {
        int scelta = 0;
        do
        {
            Console.WriteLine("[1] Aggiungi un corso di Musica");
            Console.WriteLine("[2] Aggiungi un corso di Pittura");
            Console.WriteLine("[3] Aggiungi un corso di Danza");
            Console.WriteLine("[4] Aggiungi studente a un corso");
            Console.WriteLine("[5] Visualizza tutti i corsi");
            Console.WriteLine("[6] Cerca corsi per nome docente");
            Console.WriteLine("[7] Esegui metodo speciale di un corso");
            Console.WriteLine("[0] Esci");
            Console.Write("Scelta: ");
            scelta = int.Parse(Console.ReadLine());

            switch (scelta) {
                case 1:
                    //AggiungiCorsoMusica();
                    break;
                case 2:
                    //AggiungiCorsoPittura();
                    break;
                case 3:
                    //AggiungiCorsoDanza();
                    break;
                case 4:
                    //AggiungiStudente();
                    break;
                case 5:
                    //VisualizzaCorsi();
                    break;
                case 6:
                    //CercaPerDocente();
                    break;
                case 7:
                    //EseguiMetodoSpeciale();
                    break;
                default:
                    Console.WriteLine("Scelta non valida.");
                    break;
            }
        } while (scelta != 0);
    }
}