using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;  // библиотека для работы с программой управления черепашкой C:\Program Files (x86)\Microsoft\Small Basic\SmallBasicLibrary.dll подключена в ссылках

namespace TurtleTraining
{
    internal class Program
    {
        static void WriteT(int size)
        {
            // Буква "Т" начало
            Turtle.Angle = 0;
            Turtle.Move(size);
            Turtle.Angle = 270;
            Turtle.Move(size/3);
            Turtle.Angle = 90;
            Turtle.Move(size * 2 / 3);
            // Буква "Т" конец 
        }

        static void WriteO(int size)
        {
            Turtle.Angle = 0;
            for (int i = 0; i < 4; i++)
            {
                Turtle.Move(size);
                Turtle.TurnRight();
            }
        }

        static void WriteP(int size)
        {
            Turtle.Angle = 0;
            Turtle.Move(size);
            for (int i = 0; i < 4; i++)
            {
                Turtle.Move(size);
                Turtle.TurnRight();
            }
        }

        static void WriteA(int size)
        {
            Turtle.Angle = 30;
            Turtle.Move(size);
            Turtle.Angle = 150;
            Turtle.Move(size);
            Turtle.Angle = 330;
            Turtle.Move(size / 2);
            Turtle.Angle = 270;
            Turtle.Move(size / 2);

        }

        static void Main(string[] args)
        {
            Turtle.Speed = 8;
            Turtle.X = 200;
            Turtle.Y = 200;

            // торт
            int size = 40;

            WriteA(2 * size);

            //WriteT(2 * size);

            //Turtle.X = 230;
            //Turtle.Y = 200;

            //WriteO(size);

            //Turtle.X = 290;
            //Turtle.Y = 200 + size;

            //WriteP(size);

            //Turtle.X = 360;
            //Turtle.Y = 200;

            //WriteT(size);


            //for (int i = 0; i < 6; i++) // цикл поворота и движения черепашки
            //{
            //    //int j = 0;  // циклы для движения и поворота заборчиком
            //    //while (j < 2)
            //    //{
            //    //    turtle.move(20);
            //    //    turtle.turnright();
            //    //    j++;
            //    //    //turtle.turn(90);
            //    //}
            //    //int k = 0;
            //    //while (k < 2)
            //    //{
            //    //    turtle.move(20);
            //    //    turtle.turnleft();
            //    //    k++;
            //    //}
            //turtle.move(100); // движение и повороты на 60 град.
            //turtle.Turn(60);
        }
    }
}
