using System;
using System.Collections.Generic;
using System.Text;

namespace HelloAcademy
{
    public static class FunzioniRubrica
    {
        public static void InserisciPersoneEMostraRubrica()
        {
            //Dimensiono array per la rubrica

            //1.chiedo all'utente quante persone vuole inserire
            Console.Write("specifica il numero di persone da inserire");
            int numPersone = int.Parse(Console.ReadLine());
            Person[] rubrica = new Person[numPersone];


            //2.Validazione del valore inserito
            if (numPersone < 1 || numPersone >= 10)
            {
                Console.Write("Il numero di persone inserito non è valido");
                return;
            }
            //itero per il numero di persone richiesto

            for (int i = 1; i < numPersone + 1; i++)
            {
                //richiedo il nome e il cognome
                Console.WriteLine("Nome" + i);
                string nome = Console.ReadLine();


                Console.WriteLine("Cognome" + i);
                string cognome = Console.ReadLine();

                Person person = new Person
                {
                    FirstName = nome,
                    LastName = cognome

                };


            }
            

            


            /*

            //Richiedo persona 1 (nome + cognome)
            Console.Write("Nome 1: ");
            string nome1 = Console.ReadLine();
            Console.Write("Cognome 1: ");
            string cognome1 = Console.ReadLine();

            //Creo oggetto persona e inserisco valori
            Person uno = new Person();
            uno.FirstName = nome1;
            uno.LastName = cognome1;

            //Aggiungo persona a rubrica
            rubrica[0] = uno;


            //Richiedo persona 2 (nome + cognome)
            Console.Write("Nome 2: ");
            string nome2 = Console.ReadLine();
            Console.Write("Cognome 2: ");
            string cognome2 = Console.ReadLine();

            //Creo oggetto persona e inserisco valori
            Person due = new Person
            {
                FirstName = nome2,
                LastName = cognome2
            };

            //Aggiungo persona a rubrica
            rubrica[1] = due;


            //Richiedo persona 3 (nome + cognome)
            //Creo oggetto persona e inserisco valori
            //Aggiungo persona a rubrica
            Console.Write("Nome 2: ");
            string nome3 = Console.ReadLine();
            Console.Write("Cognome 2: ");
            string cognome3 = Console.ReadLine();
            rubrica[2] = new Person
            {
                FirstName = nome3,
                LastName = cognome3
            };

            
            Console.WriteLine("Iterazione rubrica (for):");
            for (int i = 0; i < rubrica.Length; i++)
            {
                Console.WriteLine(rubrica[i].FirstName + ", " + rubrica[i].LastName);
            }

            Console.WriteLine("Iterazione rubrica (while):");
            int index = 0;
            while (index < rubrica.Length)
            {
                Console.WriteLine(rubrica[index].FirstName + ", " + rubrica[index].LastName);
                index = index + 1;
            }
            /*
            foreach(Person current in rubrica)
            {
                Console.WriteLine(current.FirstName + ", " + current.LastName);
            }

            */
        }
    }
}
