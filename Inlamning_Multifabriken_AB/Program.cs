using System;
using System.Collections.Generic;

enum Color { Red, Green, Blue, White, Black };  //TODO Färgen måste välja från listan  

namespace Inlamning_4_Multifabriken
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            List<Product> productList = new List<Product>();

            System.Console.WriteLine("Välkommen till Multifabriken AB!");
            do
            {
                showMenu();
            } while (option != 6);
            

            void showMenu (){
                System.Console.WriteLine("Välj ett alternativ:");
                System.Console.WriteLine("  1. Om du vill beställa bil.");
                System.Console.WriteLine("  2. Om du vill beställa godis.");
                System.Console.WriteLine("  3. Om du vill beställa rör.");
                System.Console.WriteLine("  4. Om du vill beställa en havremjölk.");
                System.Console.WriteLine("  5. Om du vill se din beställning.");
                System.Console.WriteLine("  6. Om du vill avsluta programmet.");

                option = Convert.ToInt32(Console.ReadLine());    //TODO Här finns ett undantag

                switch (option)
                {
                    case 1:
                        System.Console.WriteLine("Du har valt att beställa en bil");
                        makeCar();
                        Console.Clear();
                        System.Console.WriteLine("Din bil är registrerad. Vad vill du göra nu?");
                        break;
                    case 2:
                        System.Console.WriteLine("Du har valt att beställa en godis");
                        makeCandy();
                        Console.Clear();
                        System.Console.WriteLine("Din godis är registrerad. Vad vill du göra nu?");
                        break;
                    case 3:
                        System.Console.WriteLine("Du har valt att beställa ett rör");
                        makeTube();
                        Console.Clear();
                        System.Console.WriteLine("Ditt rör är registrerad. Vad vill du göra nu?");
                        break;
                    case 4:
                        System.Console.WriteLine("Du har valt att beställa havremjölk");
                        makeOatMilk();
                        Console.Clear();
                        System.Console.WriteLine("Havremjölk är registrerad. Vad vill du göra nu?");
                        break;
                    case 5:
                        Console.Clear();
                        showAllProducts();
                        break;
                    case 6:
                        System.Console.WriteLine("Programmet avslutas...");
                        break;
                    default:
                        System.Console.WriteLine("Något gick fel!!!");
                        break;   
                }
            }   //End showMenu()


            void makeCar() {
                Console.Write("Ange ett registreringsnummer (sträng): ");
                string rn = Console.ReadLine();

                Console.Write("Ange en färg (sträng): ");
                string c = Console.ReadLine();

                Console.Write("Ange ett bilmärke (sträng): ");
                string bm = Console.ReadLine();

                productList.Add(new Car (rn, c, bm));
            } //End makeCar


            void makeCandy() {
                Console.Write("Ange en smak (sträng): ");
                string s = Console.ReadLine();

                Console.Write("Ange antalet (heltal): ");
                int a = Convert.ToInt32(Console.ReadLine());

                productList.Add(new Candy (s, a));
            } //End makeCandy


            void makeTube() {
                Console.Write("Ange diameter (flytnummer): ");
                double d = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ange längdet (flytnummer): ");
                double l = Convert.ToDouble(Console.ReadLine());

                productList.Add(new Tube (d, l));
            } //End makeTube


            void makeOatMilk() {
                Console.Write("Ange fethalt (heltal): ");
                int f = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ange litermängd (heltal): ");
                int l = Convert.ToInt32(Console.ReadLine());

                productList.Add(new OatMilk (f, l));
            } //End makeOatMilk


            void showAllProducts() {
                if (productList.Count == 0) {
                    System.Console.WriteLine("Din beställning är tom. Vad vill du göra nu?");
                    showMenu();
                } else {
                    System.Console.WriteLine("Här kommer din beställning:");
                    foreach (Product prod in productList) {
                        prod.toString();
                    }
                    System.Console.WriteLine("Vad vill du göra nu?");
                }
                
            }   //End showAllProducts
        }
    }
}
