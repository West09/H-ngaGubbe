using System;
using System.Collections.Generic;
using System.Text;

namespace Hängafakkinggubbe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lista med randomizer som väljer ett av orden i listan.
            Random random = new Random();

            List<string> hemligaOrd = new List<string>();

            hemligaOrd.Add("HEJSAN");
            hemligaOrd.Add("HAJPO");
            hemligaOrd.Add("HITTEPO");
            string randomOrd = "";
            int randomNumber = 0;

            for (int i = 0; i < hemligaOrd.Count; i++)
            {
                randomNumber = random.Next(0, hemligaOrd.Count);
                randomOrd = hemligaOrd[randomNumber];
            }

           

            //Variabler deklareras innan de används i while-loopen.
            int lives = 5;
            int hej = 0;
            bool gameOver = false;
            string input = "";
            bool rightGuess;
            StringBuilder tomtOrd = new StringBuilder();
            StringBuilder ordAttGissa = new StringBuilder(randomOrd);
            for (int i = 0; i < randomOrd.Length; i++)
            {
                tomtOrd.Append("_");
            }

            while (!gameOver)
            {
                Console.Clear();
                rightGuess = false;
                Console.WriteLine("Skriv in en bokstav i taget för att gissa ordet, du har " + lives + " liv. " + tomtOrd);
                if (tomtOrd.ToString() == ordAttGissa.ToString())
                {
                    gameOver = true;
                }
                else if (!gameOver)
                {
                    input = Console.ReadKey().Key.ToString();
                }
                for (int i = 0; i < ordAttGissa.Length; i++)
                {
                    if (input.ToCharArray()[0] == ordAttGissa[i])
                    {
                        tomtOrd.Remove(i, 1);
                        tomtOrd.Insert(i, input);
                        rightGuess = true;
                    }
                }
                if (rightGuess == false)
                {
                    lives--;
                    hej++;                   //variabel döpts till hej vid brist av ordförråd, ska representera liv som förlorats.


                }
                if (lives < 1)
                {
                    gameOver = true;
                }
            }
           

            
            
            Console.Clear();
            if (lives == 0)
             {
                 Console.WriteLine("DU FÖRLORADE!! DU ÄR KASS. Ordet var: " + ordAttGissa);
             }
            else if (tomtOrd.ToString() == ordAttGissa.ToString())
             {
                 Console.WriteLine("DU VANN! GRATTIS!");
             }
            






        }








    }
}
