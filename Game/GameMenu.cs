using ShapeMenu.Figures;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ShapeMenu.Game
{
    internal class GameMenu : Menu
    {
        private List<Enemy> enemy = new List<Enemy>();
        private Player player;
        double H, A;
        private int eleccion, count, capt;

        public override void Execute()
        {
            CreateCharacter();
            EnemyCreate();
            IMGEnemigo();
            Game();
        }

        private void Game()
        {
            Console.WriteLine("1- ATAQUE                                     2- INFO");
            while (!int.TryParse(Console.ReadLine(), out eleccion))
                Console.WriteLine("Error, ingrese un numero");

            Console.Clear();

            switch (eleccion)
            {
                case (1):
                    IMGEnemigo();

                    Console.WriteLine("¿A quien quieres atacar?");

                    for (int i = 0; i < enemy.Count; i++)
                    {
                        if (enemy[i].Islive) Console.WriteLine($"Enemigo: {i}                    Vida: {enemy[i].health}");
                        else Console.WriteLine($"Enemigo: {i}                    Vida:(Muerto)");
                    }

                    while (!int.TryParse(Console.ReadLine(), out eleccion)) Console.WriteLine("Error, ingrese un numero");

                    if (eleccion >= 0 && eleccion < enemy.Count)
                    {
                        if (enemy[eleccion].GetLive())
                        {
                            enemy[eleccion].GetHurt(player.GetAttack());
                            Console.WriteLine("Acertaste el ataque");
                        }
                        else Console.WriteLine("El enemigo ya esta muerto");
                    }
                    else Console.WriteLine("Parece que no quieres atacar a nadie");

                    Console.ReadLine();
                    Console.Clear();
                    break;
                case (2):
                    IMGEnemigo();
                    for (int i = 0; i < enemy.Count; i++)  Console.WriteLine($"Enemigo: {i + 1}        Ataque: {enemy[i].attack}            Vida: {enemy[i].health}");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Error, ingrese un numero valido");
                    Console.ReadLine();
                    Console.Clear();
                    break;
            }

            EnemyAttack();

            while (player.Health <= 0)
            {
                Console.Clear();
                Console.WriteLine("perdite");
                Console.ReadLine();
                return;
            }

            if (enemy.All(e => !e.Islive))
            {
                Console.WriteLine("Ganaste");
                Console.ReadLine();
                return;
            }

            IMGEnemigo();
            Game();
        }

        private void CreateCharacter()
        {
            do
            {
                Console.WriteLine("escribe la vida de tu personaje | 1 - 100");
                if (!double.TryParse(Console.ReadLine(), out H)) Error("Error, ingrese un numero");
                Console.Clear();
            }
            while (H < 1 || H > 100);

            do
            {
                Console.WriteLine("escribe el ataque de tu personaje | 1 - 100");
                if (!double.TryParse(Console.ReadLine(), out A)) Error("Error, ingrese un numero");
                Console.Clear();
            }
            while (A < 1 || A > 100);

            player = new Player(H, A);

            Console.WriteLine($"Jugador creado: \nVida   : {H} \nAtaque : {A}");
            Console.ReadKey();
            Console.Clear();

        }

        void EnemyAttack()
        { 
            //Console.WriteLine(count);

            while (!enemy[count].Islive && capt < enemy.Count)
            {
                count++;
                if (count >= enemy.Count) count = 0;
                capt++;
            }

            if (enemy[count].Islive)
            {
                player.GetHurt(enemy[count].attack);
                Console.WriteLine($"El enemeigo: {count} te hizo {enemy[count].attack} de daño");
            }

            count++;
            if (count >= enemy.Count) count = 0;
        }

        private void EnemyCreate()
        {
            Random random = new Random();
            for (int i = 0; i < 2; i++)
            {
                double H = random.Next(90,150);
                double A = random.Next(2,20);

                Enemy m = new EMelee(H, A, true);
                Enemy s = new EShooter(H, A, true);
                enemy.Add(m);
                enemy.Add(s);
            }      
        }

        private void IMGEnemigo()
        {
            string[] EnemigoFisico = new string[]
            {
                 "      @ .. . @      ",
                 "    @==@@==@@==@    ",
                 "    @=@@@==@@@*@    ",
                 "    @=@..@@..@=@    ",
                 "    %=:@@@@@@:=%    ",
                 "   *==.=@@@@=-==*   ",
                 "  @==-:++--*-:.==@  ",
                 " +*:==-@==-+@==--** ",
                 " #==--:+*%%#-=.--=# ",
            };

            for (int i = 0; i < EnemigoFisico.Length; i++)
            {
                for (int j = 0; j < enemy.Count; j++) Console.Write(EnemigoFisico[i]);

                Console.WriteLine();
            }

            Console.WriteLine("------------------------------------ Vida: " + (player.Health) + " ------------------------------------");
        }

        private void Error(string note)
        {
            Console.Clear();
            Console.WriteLine(note);
            Console.ReadKey();
            Console.Clear();
        }

    }
}
