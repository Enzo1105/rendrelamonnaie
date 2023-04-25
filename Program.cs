using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetRendreLaMonnaie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                // Montant aléatoire à regler 
                Random aleatoire = new Random();
                decimal montpaye = (decimal)Math.Round(aleatoire.NextDouble() * 200, 2);
                Console.WriteLine($"Montant à payer : {montpaye}€ ");


                // Saisie du montant réglé
                Console.Write("Saisir le montant réglé ( 0 pour mettre fin au programme ) : ");
                if (decimal.TryParse(Console.ReadLine(), out decimal montreg))
                {
                    {
                        if (montreg <= 0) // Saisie du chiffre 0 = met fin au programme
                            return;
                    }

                    if (montreg < montpaye)

                    {
                        Console.WriteLine($"Le montant réglé ne peut être inférieur à {montpaye}€ !");
                    }
                    else
                    {

                        decimal resteArendre = montreg - montpaye;
                        Console.WriteLine($"Montant à rendre : {resteArendre}€ ");

                        int nb20 = 0;
                        while (resteArendre >= 20)
                        {
                            nb20++;
                            resteArendre = resteArendre - 20; 
                        }

                        int nb10 = 0;
                        if (resteArendre >= 10 && resteArendre < 20)
                        {
                            nb10++;
                            resteArendre = resteArendre - 10;
                        }

                        int nb5 = 0;
                        if (resteArendre >= 5 && resteArendre < 10)
                        {
                            nb5 ++;
                            resteArendre = resteArendre - 5;
                        }

                        int nb2 = 0;
                        while (resteArendre >= 2 && resteArendre < 5)
                        {
                            nb2++;
                            resteArendre = resteArendre - 2;
                        }

                        int nb1 = 0;
                        if (resteArendre >= 1 && resteArendre < 2)
                        {
                            nb1 += 1;
                            resteArendre = resteArendre - 1;
                        }

                        int nb05 = 0;
                        if (resteArendre >= (decimal)0.5 && resteArendre < 1)
                        {
                            nb05 += 1;
                            resteArendre = resteArendre - (decimal)0.5;
                        }

                        int nb02 = 0;
                        while (resteArendre >= (decimal)0.2 && resteArendre < (decimal)0.5)
                        {
                            nb02++;
                            resteArendre = resteArendre - (decimal)0.2;
                        }

                        int nb01 = 0;
                        if (resteArendre >= (decimal)0.1 && resteArendre < (decimal)0.2)
                        {
                            nb01 += 1;
                            resteArendre = resteArendre - (decimal)0.1;
                        }

                        int nb005 = 0;
                        if (resteArendre >= (decimal)0.05 &&  resteArendre < (decimal)0.1)
                        {
                            nb005 += 1;
                            resteArendre = resteArendre - (decimal)0.05;
                        }

                        int nb002 = 0;
                        while (resteArendre >= (decimal)0.02 && resteArendre < (decimal)0.05)
                        {
                            nb002 += 1;
                            resteArendre = resteArendre - (decimal)0.02;
                        }

                        int nb001 = 0;
                        if (resteArendre >= (decimal)0.01 && resteArendre < (decimal)0.02)
                        {
                            nb001 += 1;
                            resteArendre = resteArendre - (decimal)0.01;
                        }

                        if (nb20 > 0)
                        {
                            if (nb20 == 1)
                            {
                                Console.WriteLine($"Billet de 20 euros : {nb20}");
                            }
                            else
                            {
                                Console.WriteLine($"Billets de 20 euros : {nb20}");
                            }
                        }
                        if (nb10 > 0)
                        {
                            if (nb10 == 1)
                            {
                                Console.WriteLine($"Billet de 10 euros : {nb10}");
                            }
                            else
                            {
                                Console.WriteLine($"Billets de 10 euros : {nb10}");
                            }
                        }
                        if (nb5 > 0)
                        {
                            if (nb5 == 1)
                            {
                                Console.WriteLine($"Billet de 5 euros : {nb5}");
                            }
                            else
                            {
                                Console.WriteLine($"Billets de 5 euros : {nb5}");
                            }
                        }
                        if (nb2 > 0)
                        {
                            if (nb2 == 1)
                            {
                                Console.WriteLine($"Pièce de 2 euros : {nb2}");
                            }
                            else
                            {
                                Console.WriteLine($"Pièces de 2 euros : {nb2}");
                            }
                        }
                        if (nb1 > 0)
                        {
                            if (nb1 == 1)
                            {
                                Console.WriteLine($"Pièce de 1 euro : {nb1}");
                            }
                            else
                            {
                                Console.WriteLine($"Pièces de 1 euro : {nb1}");
                            }
                        }
                        if (nb05 > 0)
                        {
                            if (nb05 == 1)
                            {
                                Console.WriteLine($"Pièce de 50 centimes : {nb05}");
                            }
                            else
                            {
                                Console.WriteLine($"Pièces de 50 centimes : {nb05}");
                            }
                        }
                        if (nb02 > 0)
                        {
                            if (nb02 == 1)
                            {
                                Console.WriteLine($"Pièce de 20 centimes : {nb02}");
                            }
                            else
                            {
                                Console.WriteLine($"Pièces de 20 centimes : {nb02}");
                            }
                        }
                        if (nb01 > 0)
                        {
                            if (nb01 == 1)
                            {
                                Console.WriteLine($"Pièce de 10 centimes : {nb01}");
                            }
                            else
                            {
                                Console.WriteLine($"Pièces de 10 centimes : {nb01}");
                            }
                        }
                        if (nb005 > 0)
                        {
                            if (nb005 == 1)
                            {
                                Console.WriteLine($"Pièce de 5 centimes : {nb005}");
                            }
                            else
                            {
                                Console.WriteLine($"Pièces de 5 centimes : {nb005}");
                            }
                        }
                        if (nb002 > 0)
                        {
                            if (nb002 == 1)
                            {
                                Console.WriteLine($"Pièce de 2 centime : {nb002}");
                            }
                            else
                            {
                                Console.WriteLine($"Pièces de 2 centimes : {nb002}");
                            }
                        }
                        if (nb001 > 0)
                        {
                            if (nb001 == 1)
                            {
                                Console.WriteLine($"Pièce de 1 centime : {nb001}");
                            }
                            else
                            {
                                Console.WriteLine($"Pièces de 1 centime : {nb001}");
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Saisie incorrecte , saisissez une autre valeur !");

                }

            }
            Console.ReadKey();
        }


    }

}


