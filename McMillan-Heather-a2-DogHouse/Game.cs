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

            DrawHouse(400, 150);

            //make dog smaller higher up and bigger lower on screen?

            if (Input.IsMouseButtonDown(MouseInput.Left))
            {
                DrawDog2(Input.GetMouseX(), Input.GetMouseY());
            }
            else
            {
                DrawDog1(Input.GetMouseX(), Input.GetMouseY());
            }

            //Trees
            Draw.LineSize = 1;
            Draw.LineColor = Black;
            Draw.FillColor = DarkBrown;
            Draw.Rectangle(50, 300, 100, 300);
            Draw.Rectangle(650, 300, 100, 300);
            //leaves
            // use loop to draw leaves left tree
                DrawLeaves(DarkGreen, 380, 30, 40, 6, 40, 20);
                DrawLeaves(Green,     380, 30, 40, 6, 40, 0);
                DrawLeaves(Green,     360, 30, 40, 6, 40, 20);
                DrawLeaves(DarkGreen, 360, 30, 40, 6, 40, 0);
                DrawLeaves(DarkGreen, 340, 30, 40, 7, 40, 20);
                DrawLeaves(Green,     340, 30, 40, 7, 40, 0);
                DrawLeaves(Green,     320, 30, 40, 7, 40, 20);
                DrawLeaves(DarkGreen, 320, 30, 40, 7, 40, 0);
                DrawLeaves(DarkGreen, 300, 30, 40, 7, 40, 20);
                DrawLeaves(Green,     300, 30, 40, 7, 40, 0);
                DrawLeaves(Green,     280, 30, 40, 7, 40, 20);
                DrawLeaves(DarkGreen, 280, 30, 40, 7, 40, 0);
                DrawLeaves(DarkGreen, 260, 30, 40, 7, 40, 20);
                DrawLeaves(Green,     260, 30, 40, 7, 40, 0);
                DrawLeaves(Green,     240, 30, 40, 7, 40, 20);
                DrawLeaves(DarkGreen, 240, 30, 40, 7, 40, 0);
                DrawLeaves(DarkGreen, 220, 30, 40, 7, 40, 20);
                DrawLeaves(Green,     220, 30, 40, 7, 40, 0);
                DrawLeaves(Green,     200, 30, 40, 7, 40, 20);
                DrawLeaves(DarkGreen, 200, 30, 40, 7, 40, 0);
                DrawLeaves(DarkGreen, 180, 30, 40, 6, 40, 20);
                DrawLeaves(Green,     180, 30, 40, 6, 40, 0);
                DrawLeaves(Green,     160, 30, 40, 6, 40, 20);
                DrawLeaves(DarkGreen, 160, 30, 40, 6, 40, 0);
                DrawLeaves(DarkGreen, 140, 30, 40, 5, 40, 20);
                DrawLeaves(Green,     140, 30, 40, 5, 40, 0);
            //Right tree
            DrawLeaves(Green,    380, 30, 40, 7, 40, 20 + 560);
            DrawLeaves(DarkGreen,380, 30, 40, 7, 40, 0 + 560);
            DrawLeaves(DarkGreen,360, 30, 40, 8, 40, 20 + 540);
            DrawLeaves(Green,    360, 30, 40, 8, 40, 0 + 540);
            DrawLeaves(Green,    340, 30, 40, 9, 40, 20 + 520);
            DrawLeaves(DarkGreen,340, 30, 40, 9, 40, 0 + 520);
            DrawLeaves(DarkGreen,320, 30, 40, 9, 40, 20 + 520);
            DrawLeaves(Green,    320, 30, 40, 9, 40, 0 + 520);
            DrawLeaves(Green,    300, 30, 40, 9, 40, 20 + 520);
            DrawLeaves(DarkGreen,300, 30, 40, 9, 40, 0 + 520);
            DrawLeaves(DarkGreen,280, 30, 40, 9, 40, 20 + 520);
            DrawLeaves(Green,    280, 30, 40, 9, 40, 0 + 520);
            DrawLeaves(Green,    260, 30, 40, 9, 40, 20 + 520);
            DrawLeaves(DarkGreen,260, 30, 40, 9, 40, 0 + 520);
            DrawLeaves(DarkGreen,240, 30, 40, 9, 40, 20 + 520);
            DrawLeaves(Green,    240, 30, 40, 9, 40, 0 + 520);
            DrawLeaves(Green,    220, 30, 40, 9, 40, 20 + 520);
            DrawLeaves(DarkGreen,220, 30, 40, 9, 40, 0 + 520);
            DrawLeaves(DarkGreen,200, 30, 40, 9, 40, 20 + 520);
            DrawLeaves(Green,    200, 30, 40, 9, 40, 0 + 520);
            DrawLeaves(Green,    180, 30, 40, 8, 40, 20 + 540);
            DrawLeaves(DarkGreen,180, 30, 40, 8, 40, 0 + 540);
            DrawLeaves(DarkGreen,160, 30, 40, 7, 40, 20 + 560);
            DrawLeaves(Green,    160, 30, 40, 7, 40, 0 + 560);
            DrawLeaves(Green,    140, 30, 40, 6, 40, 20 + 580);
            DrawLeaves(DarkGreen,140, 30, 40, 6, 40, 0 + 580);


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
        } void DrawHouse(float x, float y)
        {
            //main house
            Draw.LineSize = 1;
            Draw.LineColor = Black;
            Draw.FillColor = LightBrown;
            Draw.Rectangle(250, 80, 300, 170);
            //roof
            Draw.LineSize = 1;
            Draw.LineColor = Black;
            Draw.FillColor = Orange;
            Draw.Triangle(250, 80, 400, 0, 550, 80);
            //Door
            Draw.LineSize = 1;
            Draw.LineColor = Black;
            Draw.FillColor = DarkBrown;
            Draw.Rectangle(370, 180, 60, 70);
            //Doorknob
            Draw.LineSize = 1;
            Draw.LineColor = Black;
            Draw.FillColor = Black;
            Draw.Circle(420, 220, 5);
            //Windows
            Draw.LineSize = 1;
            Draw.LineColor = Black;
            Draw.FillColor = Yellow;
            Draw.Square(290,110,40);
            Draw.Square(470,110,40);
            //window lines
            Draw.LineSize = 1;
            Draw.LineColor = Black;
            Draw.FillColor = Black;
            Draw.Line(290, 130, 330, 130);
            Draw.Line(470, 130, 510, 130);
            Draw.Line(310, 110, 310, 150);
            Draw.Line(490, 110, 490, 150);
            //grass
            Draw.LineSize = 1;
            Draw.LineColor = LimeGreen;
            Draw.FillColor = LimeGreen;
            Draw.Rectangle(0, 250, 800, 350);
        }
        void DrawLeaves(Color LeafColor, int y, int w, int h, float count, int distance, int delay)
        {
            Draw.FillColor = LeafColor;
            Draw.LineSize = 0;
            for (int i = 0; i < count; i++)
            {
                Draw.Ellipse(distance * i + delay, y, w, h);
            }

        }

    }

}