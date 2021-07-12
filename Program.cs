using System;

namespace Week_Day_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        
        // stampa frase a video
        int a = 2; // da 32 bit
        const int N = 50; // NON può essere modificato un valore di una costante
        int var1 = 1, var2 = 2, var3 = 3; //inizializzare di piu variabili con lo stesso tipo.
        string parola = "ciao a tutte!";// sequenza di lettere
        char carattere = 'b'; // per memorizzare un singolo carattere
        byte c; //  di tipo intero da 0 a 255
        short d; // da 16 bit
        long l;        // 64 bit


        //numeri a virgola mobile
        float f = 2.33f; // memorizza 6-9 cifre oltre la virgola
        double pi = 3.145545224125d; //tanti numeri dopo la virgola
        decimal dec = 123.425m; //si utilizza per il denaro e menorizza circa 27 cifre

        //booleani: true/false
        bool isSunny = true;

        Console.WriteLine(parola);

            int x = 1;
            int y = 2;
            Console.WriteLine($"Ciao il valore della prima variabile è {x}. Il valore della seconda variabile è {y}"); // \n serve per andare a capo e \t per dare uno spazio

            // come si prende un valore da tastiera
            Console.WriteLine("Ciao come ti chiami?");
            string nome; // dichiaro la variabile che conterrà il nome scritto dall'utente
            nome = Console.ReadLine();// legge la stringa che viene immesso da tastiera
            Console.WriteLine($"Il tuo nome è {nome}");

            Console.WriteLine("SCRIVI UN carattere");
            char caracter = Console.ReadKey().KeyChar; // per leggere un carattere singolo
            DateTime data= new DateTime (2021 ,7 , 12); // dichiaro una variabile che memorizza sia data che orario, si mette new perche è un oggetto
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            DateTime today = DateTime.Today;
            Console.WriteLine(today.ToShortDateString());


            }
    }
}
