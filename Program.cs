using System;

namespace LesBouclesExo4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Définir un nombre en 1 et 50.Demander à l’utilisateur de deviner ce nombre.
            //Si la réponse est supérieure au nombre, afficher « C’est plus petit », 
            //si la réponse est inférieure au nombre, afficher « C’est plus grand ».
            //Si l’utilisateur trouve la bonne réponse, afficher « Bravo vous avez trouvé ! »
            //Bonus 1 : Le nombre défini au départ est aléatoire.
            //Bonus 2 : Vous affichez le nombre de tentatives.


            Random aleatoire = new Random();
            int secretnumber = aleatoire.Next(1, 51);
            int attempts = 1; // nombre d'essaie 
            int success = 0;

            Console.WriteLine("Devine un nombre entre 1 et 50 ");
            int input = int.Parse(Console.ReadLine());

            do
            {
                if (input == secretnumber)
                {
                    Console.WriteLine($"essaie n°{attempts} \n Gagné !");
                    success = 1;
                }
                else if (input < secretnumber)
                {
                    Console.WriteLine($"essaie n° {attempts} \n trop petit, retente ta chance !");
                    attempts++;
                    input = int.Parse(Console.ReadLine());
                }
                else if (input > secretnumber)
                {
                    Console.WriteLine($"essaie n° {attempts} \n Ah trop grand!  retente ta chance !");
                    attempts++;
                    input = int.Parse(Console.ReadLine());
                }
            } while (success == 0);
        }
            
            
            
            
            
            /*Random aleatoire = new Random();
            int number = aleatoire.Next(1, 10); // Génère un entier compris entre 1 et 50
            int numberFound;
            int start = 0;

            Console.WriteLine("Devinez le nombre : ");
            numberFound = Convert.ToInt32(Console.ReadLine());

            while (numberFound != number)
            {               
                    if (numberFound >= number)
                    {
                        Console.WriteLine("C’est plus petit : ");
                        number = Convert.ToInt32(Console.ReadLine());
                        start++;
                        Console.WriteLine("Tentative n° :" + start);
                        numberFound = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    else
                    {
                        Console.WriteLine("C'est plus grand");
                        start++;
                        Console.WriteLine("Tentative n° :" + start);
                        numberFound = Convert.ToInt32(Console.ReadLine());
                        continue;
                    }
            }

                start++;
                Console.WriteLine($"Bravo vous avez trouvé en {start} coups !");*/


            //Console.WriteLine("Le nombre est compris entre 1 et 50 :" );
            //numberFound = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Deviner le nombre entre 1 et 50:" /*+ number*/);
            //numberFound = Convert.ToInt32(Console.ReadLine());

            

        }
    }

