﻿using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

class Snowflake
{
    public int X { get; set; }
    public int Y { get; set; }
    public char Appearance { get; set; }

    public Snowflake(int x, int y, char appearance)
    {
        X = x;
        Y = y;
        Appearance = appearance;
    }

    public void Fall(int speed)
    {
        Y += speed;
    }

    public void ResetPosition(int screenWidth)
    {
        Y = 0;
        X = new Random().Next(screenWidth);
    }

    class SnowfallAnimation
    {
        private List<Snowflake> snowflakes = new List<Snowflake>();
        private Random random = new Random();
        private int screenWidth = Console.WindowWidth;
        private int screenHeight = Console.WindowHeight;
        private Snowflake playerSnowflake;
        private bool isRunning = true;

        public SnowfallAnimation()
        {
            Console.CursorVisible = false;


            for (int i = 0; i < 10; i++)
            {
                snowflakes.Add(new Snowflake(random.Next(screenWidth), random.Next(screenHeight), '*'));
            }


            playerSnowflake = new Snowflake(screenWidth / 2, 0, '*');


            Task.Run(() => DropSnowflakes());
            Task.Run(() => ControlPlayerSnowflake());


            while (isRunning)
            {
                Draw();
                Thread.Sleep(100);
            }
        }

        private void ControlPlayerSnowflake()
        {
            while (isRunning)
            {
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true).Key;
                    switch (key)
                    {
                        case ConsoleKey.A: //слишком быстро не клацать, будет не успевать и будет идти в одно сторону столько
                            playerSnowflake.X = Math.Max(0, playerSnowflake.X - 1);
                            break;
                        case ConsoleKey.D:
                            playerSnowflake.X = Math.Min(screenWidth - 1, playerSnowflake.X + 1);
                            break;
                        case ConsoleKey.Escape:
                            isRunning = false;
                            break;
                    }
                }

                playerSnowflake.Fall(1);

                if (playerSnowflake.Y >= screenHeight)
                {
                    playerSnowflake.ResetPosition(screenWidth);
                }
                Thread.Sleep(300);

            }
        }


        private void DropSnowflakes()
        {
            while (isRunning)
            {
                for (int i = 0; i < snowflakes.Count; i++)
                {
                    snowflakes[i].Fall(1);

                    if (snowflakes[i].Y >= screenHeight)
                    {
                        snowflakes[i].ResetPosition(screenWidth);
                    }
                }
                Thread.Sleep(300);
            }
        }

        private void Draw()
        {
            Console.Clear();


            foreach (var snowflake in snowflakes)
            {
                Console.SetCursorPosition(snowflake.X, snowflake.Y);
                Console.Write(snowflake.Appearance);
            }

            Console.SetCursorPosition(playerSnowflake.X, playerSnowflake.Y);
            Console.ForegroundColor = ConsoleColor.Cyan; 
            Console.Write(playerSnowflake.Appearance);
            Console.ResetColor();
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            new SnowfallAnimation();
        }
    }
}