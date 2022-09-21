﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace TurtleGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GraphicsWindow.KeyDown += GraphicsWindow_KeyDown;
            Turtle.PenUp();   // чтобы не было линии за черепашкой
            //Turtle.PenDown();

            GraphicsWindow.BrushColor = "Red"; // Красный цвет квадратика
            var eat = Shapes.AddRectangle(10,10); // Добавить квадратик  10x10
            int x = 200;
            int y = 200;
            Shapes.Move(eat, x, y);
            Random rand = new Random();
            while (true)
            {
                Turtle.Move(10);
                if (Turtle.X >= x && Turtle.X <= x + 10 && Turtle.Y >= y && Turtle.Y <= y + 10)
                {
                    x = rand.Next(0, GraphicsWindow.Width);
                    y = rand.Next(0, GraphicsWindow.Height);
                    Shapes.Move(eat, x, y);
                    Turtle.Speed++; 
                }
            }
        }

        private static void GraphicsWindow_KeyDown()
        {
            if (GraphicsWindow.LastKey == "Up")
            {
                Turtle.Angle = 0;
            }
            else if (GraphicsWindow.LastKey == "Right")
            {
                Turtle.Angle = 90;
            }
            else if (GraphicsWindow.LastKey == "Down")
            {
                Turtle.Angle = 180;
            }
            else if (GraphicsWindow.LastKey == "Left")
            {
                Turtle.Angle = 270;
            }
        }
    }
}
