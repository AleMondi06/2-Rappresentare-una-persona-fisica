using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Rappresentare_una_persona_fisica
{
    // Classe
    class Datas
    {
        public string codice;
        public string nome;
        public string cognome;
        public bool registrato;

        public Datas(string codice, string cognome, string nome)
        {
            this.codice = codice;
            this.cognome = cognome;
            this.nome = nome;
            registrato = false;
        }
        public void Mostra()
        {
            Console.WriteLine("Codice: {0}", codice);
            Console.WriteLine("Cognome: {0}", cognome);
            Console.WriteLine("Nome: {0}", nome);
            Console.WriteLine("Registrato: {0}", registrato ? "Sì" : "No");
        }
        public void Registra()
        {
            registrato = true;
            Console.WriteLine("Persona registrata correttamente.");
        }
    }
    // Main
    internal class Program
    {
        static void Main(string[] args)
        {
            Datas persona = new Datas("24125", "Mondino", "Alessandro");

            Console.WriteLine("Dati Anagrafici prima:");
            persona.Mostra();

            Console.WriteLine("Clicca un tasto per confermare la registrazione");
            Console.ReadLine();
            persona.Registra();

            Console.WriteLine("\nDati Anagrafici dopo:");
            persona.Mostra();           
            Console.ReadLine();

        }
    }
}
