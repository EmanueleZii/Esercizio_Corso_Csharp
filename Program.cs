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

    public override string ToString()
    {
        return $"Corso: {NomeCorso}, Durata: {DurataOre} ore, Docente: {Docente}, Studenti: {string.Join(", ", Studenti)}";
    }

    public virtual void MetodoSpeciale()
    {
        Console.WriteLine("Messaggio generico");
    }
}

public class CorsoMusica : Corso
{
    public string Strumento;

    public override string ToString()
    {
        return $"Corso: {NomeCorso}, Durata: {DurataOre} ore, Docente: {Docente}, Studenti: {string.Join(", ", Studenti)}, Strumento: {Strumento}";
    }

    public override void MetodoSpeciale()
    {
        Console.WriteLine($"Si tiene una prova pratica dello strumento: {Strumento}");
    }
}

public class CorsoPittura : Corso
{
    public string Tecnica;

    public override string ToString()
    {
        return $"Corso: {NomeCorso}, Durata: {DurataOre} ore, Docente: {Docente}, Studenti: {string.Join(", ", Studenti)}, Tecnica: {Tecnica}";
    }

    public override void MetodoSpeciale()
    {
        Console.WriteLine($"Si lavora su una tela con tecnica: {Tecnica}");
    }
}

public class CorsoDanza : Corso
{
    public string Stile;

    public override string ToString()
    {
        return $"Corso: {NomeCorso}, Durata: {DurataOre} ore, Docente: {Docente}, Studenti: {string.Join(", ", Studenti)}, Stile: {Stile}";
    }

    public override void MetodoSpeciale()
    {
        Console.WriteLine($"Questo è un corso di danza di stile {Stile}. Muoviti a ritmo!");
    }
}

public class Programms
{
    static List<Corso> corsi = new List<Corso>();

    public static void Main()
    {
        int scelta;
        do
        {
            Console.WriteLine("\n[1] Aggiungi un corso di Musica");
            Console.WriteLine("[2] Aggiungi un corso di Pittura");
            Console.WriteLine("[3] Aggiungi un corso di Danza");
            Console.WriteLine("[4] Aggiungi studente a un corso");
            Console.WriteLine("[5] Visualizza tutti i corsi");
            Console.WriteLine("[6] Cerca corsi per nome docente");
            Console.WriteLine("[7] Esegui metodo speciale di un corso");
            Console.WriteLine("[0] Esci");
            Console.Write("Scelta: ");
            scelta = int.Parse(Console.ReadLine());

            switch (scelta)
            {
                case 1:
                    AggiungiCorsoMusica();
                    break;
                case 2:
                    AggiungiCorsoPittura();
                    break;
                case 3:
                    AggiungiCorsoDanza();
                    break;
                case 4:
                    AggiungiStudente();
                    break;
                case 5:
                    VisualizzaCorsi();
                    break;
                case 6:
                    CercaPerDocente();
                    break;
                case 7:
                    EseguiMetodoSpeciale();
                    break;
                case 0:
                    Console.WriteLine("Uscita...");
                    break;
                default:
                    Console.WriteLine("Scelta non valida.");
                    break;
            }
        } while (scelta != 0);
    }

    static void AggiungiCorsoMusica()
    {
        CorsoMusica corso = new CorsoMusica();
        Console.Write("Nome corso: ");
        corso.NomeCorso = Console.ReadLine();
        Console.Write("Durata ore: ");
        corso.DurataOre = int.Parse(Console.ReadLine());
        Console.Write("Docente: ");
        corso.Docente = Console.ReadLine();
        Console.Write("Strumento: ");
        corso.Strumento = Console.ReadLine();
        corsi.Add(corso);
    }

    static void AggiungiCorsoPittura()
    {
        CorsoPittura corso = new CorsoPittura();
        Console.Write("Nome corso: ");
        corso.NomeCorso = Console.ReadLine();
        Console.Write("Durata ore: ");
        corso.DurataOre = int.Parse(Console.ReadLine());
        Console.Write("Docente: ");
        corso.Docente = Console.ReadLine();
        Console.Write("Tecnica: ");
        corso.Tecnica = Console.ReadLine();
        corsi.Add(corso);
    }

    static void AggiungiCorsoDanza()
    {
        CorsoDanza corso = new CorsoDanza();
        Console.Write("Nome corso: ");
        corso.NomeCorso = Console.ReadLine();
        Console.Write("Durata ore: ");
        corso.DurataOre = int.Parse(Console.ReadLine());
        Console.Write("Docente: ");
        corso.Docente = Console.ReadLine();
        Console.Write("Stile: ");
        corso.Stile = Console.ReadLine();
        corsi.Add(corso);
    }

    static void AggiungiStudente()
    {
        VisualizzaCorsi();
        Console.Write("Indice del corso: ");
        int indice = int.Parse(Console.ReadLine());
        Console.Write("Nome studente: ");
        string nome = Console.ReadLine();
        if (indice >= 0 && indice < corsi.Count)
        {
            corsi[indice].AggiungiStudente(nome);
        }
        else
        {
            Console.WriteLine("Indice non valido.");
        }
    }

    static void VisualizzaCorsi()
    {
        for (int i = 0; i < corsi.Count; i++)
        {
            Console.WriteLine($"[{i}] {corsi[i]}");
        }
    }

    static void CercaPerDocente()
    {
        Console.Write("Nome docente: ");
        string docente = Console.ReadLine();
        foreach (Corso corso in corsi)
        {
            if (corso.Docente == docente)
            {
                Console.WriteLine(corso);
            }
        }
    }

    static void EseguiMetodoSpeciale()
    {
        VisualizzaCorsi();
        Console.Write("Indice del corso: ");
        int indicecorso = int.Parse(Console.ReadLine());
        if (indicecorso >= 0 && indicecorso < corsi.Count)
        {
            corsi[indicecorso].MetodoSpeciale();
        }
        else
        {
            Console.WriteLine("Indice non valido.");
        }
    }
}

