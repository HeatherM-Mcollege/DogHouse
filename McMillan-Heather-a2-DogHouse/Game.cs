// Include the namespaces (code libraries) you need below.
using MohawkGame2D;
using Raylib_cs;
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
        Color Tan = new Color("#666551");
        Color DarkTan = new Color ("#525140");
        Color Black = new Color("#010005");
        Color DarkBrown = new Color("#602c2c");
        Color LightBrown = new Color("#ad7757");
        Color Orange = new Color("#cf573c");
        Color DarkGreen = new Color("#104539");
        Color Green = new Color("#017865");
        Color LimeGreen = new Color("#75a743");
        Color DarkBlue = new Color("#1a027a");
        Color LightBlue = new Color("#73bed3");
        Color Red = new Color("#801e01");
        Color Yellow = new Color("#dab42b");
         

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("DogHouse");
            Window.SetSize(800, 600);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(LightBlue);

            if (Input.IsMouseButtonDown(MouseInput.Left))
            {
                DrawDog2(Input.GetMouseX(), Input.GetMouseY());
            }
            else
            {
                DrawDog1(Input.GetMouseX(), Input.GetMouseY());
            }

                void DrawDog1(float x, float y)
                {
                    //Draw Back left leg
                    Draw.LineColor = DarkTan;
                    Draw.LineSize = 1;
                    Draw.FillColor = DarkTan;
                    Draw.Rectangle(x - 40, y + 15, 20, 50);
                    //Draw back right leg
                    Draw.LineColor = DarkTan;
                    Draw.LineSize = 1;
                    Draw.Quad(x + 40, y + 15, x + 70, y + 55, x + 50, y + 65, x + 20, y + 25);
                    //Draw tail
                    Draw.LineColor = Tan;
                    Draw.LineSize = 1;
                    Draw.FillColor = Tan;
                    Draw.Triangle(x + 30, y - 25, x + 70, y - 45, x + 50, y - 5);
                    //draw body
                    Draw.LineColor = Tan;
                    Draw.LineSize = 1;
                    Draw.FillColor = Tan;
                    //subtract half values of length and height to put mouse in center of body
                    Draw.Rectangle(x - 50, y - 25, 100, 50);
                    //draw front left leg
                    Draw.LineColor = Tan;
                    Draw.LineSize = 1;
                    Draw.FillColor = Tan;
                    Draw.Quad(x - 40, y + 15, x - 70, y + 55, x - 50, y + 65, x - 20, y + 25);
                    //draw front right leg
                    Draw.LineColor = Tan;
                    Draw.LineSize = 1;
                    Draw.FillColor = Tan;
                    Draw.Rectangle(x + 20, y + 15, 20, 50);
                    //draw left ear
                    Draw.LineColor = Tan;
                    Draw.LineSize = 1;
                    Draw.FillColor = Tan;
                    Draw.Triangle(x - 70, y - 45, x - 60, y - 65, x - 50, y - 45);
                    //draw right ear
                    Draw.LineColor = Tan;
                    Draw.LineSize = 1;
                    Draw.FillColor = Tan;
                    Draw.Triangle(x - 40, y - 45, x - 30, y - 65, x - 20, y - 45);
                    //draw head
                    Draw.LineColor = Tan;
                    Draw.LineSize = 1;
                    Draw.FillColor = Tan;
                    Draw.Square(x - 70, y - 45, 50);
                    //draw left eye
                    Draw.LineColor = Black;
                    Draw.LineSize = 1;
                    Draw.FillColor = Black;
                    Draw.Rectangle(x - 70, y - 30, 10, 5);
                    //draw right eye
                    Draw.LineColor = Black;
                    Draw.LineSize = 1;
                    Draw.FillColor = Black;
                    Draw.Rectangle(x - 50, y - 30, 10, 5);
                    //Draw top of mouth
                    Draw.LineColor = Tan;
                    Draw.LineSize = 1;
                    Draw.FillColor = Tan;
                    Draw.Rectangle(x - 90, y - 25, 40, 20);
                    //draw bottom of mouth
                    Draw.LineColor = Tan;
                    Draw.LineSize = 1;
                    Draw.FillColor = Tan;
                    Draw.Rectangle(x - 90, y - 10, 40, 15);
                    //draw nose
                    Draw.LineColor = Black;
                    Draw.LineSize = 1;
                    Draw.FillColor = Black;
                    Draw.Square(x - 90, y - 25, 10);

                    //Reverse legs for walking
                    //Draw Back left leg
                    //raw.LineColor = DarkTan;
                    //raw.LineSize = 1;
                    //raw.FillColor = DarkTan;
                    //raw.Quad(x - 40, y + 15, x - 70, y + 55, x - 50, y + 65, x - 20, y + 25);
                    //draw back right leg
                    //raw.LineColor = DarkTan;
                    //raw.LineSize = 1;
                    //raw.FillColor = DarkTan;
                    //raw.Rectangle(x + 20, y + 15, 20, 50);
                    //Draw frontleft leg
                    //raw.LineColor = Tan;
                    //raw.LineSize = 1;
                    //raw.FillColor = Tan;
                    //raw.Rectangle(x - 40, y + 15, 20, 50);
                    //Draw front right leg
                    //raw.LineColor = Tan;
                    //raw.LineSize = 1;
                    //raw.FillColor = Tan;
                    //raw.Quad(x + 40, y + 15, x + 70, y + 55, x + 50, y + 65, x + 20, y + 25);
                }
            void DrawDog2(float x, float y)
            {
                //Draw Back left leg
                Draw.LineColor = DarkTan;
                Draw.LineSize = 1;
                Draw.FillColor = DarkTan;
                Draw.Rectangle(x - 40, y + 15, 20, 50);
                //Draw back right leg
                Draw.LineColor = DarkTan;
                Draw.LineSize = 1;
                Draw.Quad(x + 40, y + 15, x + 70, y + 55, x + 50, y + 65, x + 20, y + 25);
                //Draw tail
                Draw.LineColor = Tan;
                Draw.LineSize = 1;
                Draw.FillColor = Tan;
                Draw.Triangle(x + 30, y - 25, x + 70, y - 45, x + 50, y - 5);
                //draw body
                Draw.LineColor = Tan;
                Draw.LineSize = 1;
                Draw.FillColor = Tan;
                //subtract half values of length and height to put mouse in center of body
                Draw.Rectangle(x - 50, y - 25, 100, 50);
                //draw front left leg
                Draw.LineColor = Tan;
                Draw.LineSize = 1;
                Draw.FillColor = Tan;
                Draw.Quad(x - 40, y + 15, x - 70, y + 55, x - 50, y + 65, x - 20, y + 25);
                //draw front right leg
                Draw.LineColor = Tan;
                Draw.LineSize = 1;
                Draw.FillColor = Tan;
                Draw.Rectangle(x + 20, y + 15, 20, 50);
                //draw left ear
                Draw.LineColor = Tan;
                Draw.LineSize = 1;
                Draw.FillColor = Tan;
                Draw.Triangle(x - 70, y - 45, x - 60, y - 65, x - 50, y - 45);
                //draw right ear
                Draw.LineColor = Tan;
                Draw.LineSize = 1;
                Draw.FillColor = Tan;
                Draw.Triangle(x - 40, y - 45, x - 30, y - 65, x - 20, y - 45);
                //draw head
                Draw.LineColor = Tan;
                Draw.LineSize = 1;
                Draw.FillColor = Tan;
                Draw.Square(x - 70, y - 45, 50);
                //draw left eye
                Draw.LineColor = Black;
                Draw.LineSize = 1;
                Draw.FillColor = Black;
                Draw.Quad(x - 65, y - 38, x - 65, y - 33, x - 55, y - 30, x - 55, y - 25);
                //draw right eye
                Draw.LineColor = Black;
                Draw.LineSize = 1;
                Draw.FillColor = Black;
                Draw.Quad(x - 45, y - 25, x - 45, y - 30, x - 35, y - 33, x - 35, y - 38);
                //Draw top of mouth
                Draw.LineColor = Tan;
                Draw.LineSize = 1;
                Draw.FillColor = Tan;
                Draw.Quad(x - 85, y - 35, x - 90, y - 15, x - 50, y - 25, x - 50, y - 5);
                //draw bottom of mouth
                Draw.LineColor = Tan;
                Draw.LineSize = 1;
                Draw.FillColor = Tan;
                Draw.Quad(x - 90, y - 5, x - 85, y + 10, x - 50, y - 5, x - 50, y + 5);
                //draw nose
                Draw.LineColor = Black;
                Draw.LineSize = 1;
                Draw.FillColor = Black;
                Draw.Quad(x - 85, y - 35, x - 87, y - 25, x - 75, y - 32, x - 77, y - 22);
            }
        }
    }

}