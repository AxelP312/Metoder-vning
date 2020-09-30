using System;

namespace Metoder
{
    public class Enemy
    {

        static Random generator = new Random();
        public int hp = generator.Next(3,50);

        public void enemy()
        {
            int choice = generator.Next(2);

            if(choice == 0)
            {
                hp = 50;
            }
            else
            {
                hp = 100;
            }

        }

        public int Attack()
        {
            return 2;
        }

        public void Draw()
        {
            System.Console.WriteLine("(O_>)/");
        }



        public void hurt(int ammount)
        {
            hp -= ammount;

            if (hp < 0)
            {
                hp = 0;
            }

            Console.WriteLine("Wääh jag tog skada, nu har jag bara " + hp + " kvar!!");
        }
    }
}
