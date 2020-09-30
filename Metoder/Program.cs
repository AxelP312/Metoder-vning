using System;

namespace Metoder
{
    class Program
    {
        static void Main(string[] args)
        {
            Enemy e1 = new Enemy();
            // e1.Setup();
            Enemy e2 = new Enemy();
            // e2.Setup();

            int dmg = e1.Attack();

            e2.hurt(dmg);
            e1.Draw();

            Console.ReadLine();
        }
    }
}
