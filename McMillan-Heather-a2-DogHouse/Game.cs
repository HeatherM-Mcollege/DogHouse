// Include the namespaces (code libraries) you need below.
using MohawkGame2D;
using Raylib_cs;
using System;
using System.Net.Quic;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here

        Color[] hexColors = [
           new Color("#010005"), //Black
           new Color("#73bed3"), //LightBlue
           new Color("#1a027a"), //DarkBlue
           new Color("#ad7757"), //LightBrown
           new Color("#602c2c"), //DarkBrown
           new Color("#017865"), //Green
           new Color("#75a743"), //LimeGreen
           new Color("#104539"), //DarkGreen
           new Color("#cf573c"), //Orange
           new Color("#801e01"), //Red
           new Color("#666551"), //Tan
           new Color("#525140"), //DarkTan
           new Color("#dab42b") //Yellow
        ];

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
            Window.ClearBackground(hexColors[2]);

            //declare random integers for star size
            int IntegerSize = Random.Integer(2);

            DrawStars(10,200,IntegerSize);
            DrawStars(70,70,IntegerSize);
            DrawStars(35,350,IntegerSize);
            DrawStars(40,100,IntegerSize);
            DrawStars(50,500,IntegerSize);

            

            //if button pressed light on, else light off
            
            if (Input.IsMouseButtonDown(MouseInput.Left))
            {
                DrawHouseAwake(400, 150);
            }
            else
            {
                DrawHouseAsleep(400, 150);
            }

            //Make Dog Bark on click
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
            Draw.LineColor = hexColors[0];
            Draw.FillColor = hexColors[4];
            Draw.Rectangle(50, 300, 100, 300);
            Draw.Rectangle(650, 300, 100, 300);
           
            //leaves
            // use loop to draw leaves left tree
            DrawLeaves(hexColors[7], 380, 30, 40, 6, 40, 20);
            DrawLeaves(hexColors[5], 380, 30, 40, 6, 40, 0);
            DrawLeaves(hexColors[5], 360, 30, 40, 6, 40, 20);
            DrawLeaves(hexColors[7], 360, 30, 40, 6, 40, 0);
            DrawLeaves(hexColors[7], 340, 30, 40, 7, 40, 20);
            DrawLeaves(hexColors[5], 340, 30, 40, 7, 40, 0);
            DrawLeaves(hexColors[5], 320, 30, 40, 7, 40, 20);
            DrawLeaves(hexColors[7], 320, 30, 40, 7, 40, 0);
            DrawLeaves(hexColors[7], 300, 30, 40, 7, 40, 20);
            DrawLeaves(hexColors[5], 300, 30, 40, 7, 40, 0);
            DrawLeaves(hexColors[5], 280, 30, 40, 7, 40, 20);
            DrawLeaves(hexColors[7], 280, 30, 40, 7, 40, 0);
            DrawLeaves(hexColors[7], 260, 30, 40, 7, 40, 20);
            DrawLeaves(hexColors[5], 260, 30, 40, 7, 40, 0);
            DrawLeaves(hexColors[5], 240, 30, 40, 7, 40, 20);
            DrawLeaves(hexColors[7], 240, 30, 40, 7, 40, 0);
            DrawLeaves(hexColors[7], 220, 30, 40, 7, 40, 20);
            DrawLeaves(hexColors[5], 220, 30, 40, 7, 40, 0);
            DrawLeaves(hexColors[5], 200, 30, 40, 7, 40, 20);
            DrawLeaves(hexColors[7], 200, 30, 40, 7, 40, 0);
            DrawLeaves(hexColors[7], 180, 30, 40, 6, 40, 20);
            DrawLeaves(hexColors[5], 180, 30, 40, 6, 40, 0);
            DrawLeaves(hexColors[5], 160, 30, 40, 6, 40, 20);
            DrawLeaves(hexColors[7], 160, 30, 40, 6, 40, 0);
            DrawLeaves(hexColors[7], 140, 30, 40, 5, 40, 20);
            DrawLeaves(hexColors[5], 140, 30, 40, 5, 40, 0);
            //Right tree
            DrawLeaves(hexColors[5],380, 30, 40, 7, 40, 20 + 560);
            DrawLeaves(hexColors[7],380, 30, 40, 7, 40, 0 + 560);
            DrawLeaves(hexColors[7],360, 30, 40, 8, 40, 20 + 540);
            DrawLeaves(hexColors[5],360, 30, 40, 8, 40, 0 + 540);
            DrawLeaves(hexColors[5],340, 30, 40, 9, 40, 20 + 520);
            DrawLeaves(hexColors[7],340, 30, 40, 9, 40, 0 + 520);
            DrawLeaves(hexColors[7],320, 30, 40, 9, 40, 20 + 520);
            DrawLeaves(hexColors[5],320, 30, 40, 9, 40, 0 + 520);
            DrawLeaves(hexColors[5],300, 30, 40, 9, 40, 20 + 520);
            DrawLeaves(hexColors[7],300, 30, 40, 9, 40, 0 + 520);
            DrawLeaves(hexColors[7],280, 30, 40, 9, 40, 20 + 520);
            DrawLeaves(hexColors[5],280, 30, 40, 9, 40, 0 + 520);
            DrawLeaves(hexColors[5],260, 30, 40, 9, 40, 20 + 520);
            DrawLeaves(hexColors[7],260, 30, 40, 9, 40, 0 + 520);
            DrawLeaves(hexColors[7],240, 30, 40, 9, 40, 20 + 520);
            DrawLeaves(hexColors[5],240, 30, 40, 9, 40, 0 + 520);
            DrawLeaves(hexColors[5],220, 30, 40, 9, 40, 20 + 520);
            DrawLeaves(hexColors[7],220, 30, 40, 9, 40, 0 + 520);
            DrawLeaves(hexColors[7],200, 30, 40, 9, 40, 20 + 520);
            DrawLeaves(hexColors[5],200, 30, 40, 9, 40, 0 + 520);
            DrawLeaves(hexColors[5],180, 30, 40, 8, 40, 20 + 540);
            DrawLeaves(hexColors[7],180, 30, 40, 8, 40, 0 + 540);
            DrawLeaves(hexColors[7],160, 30, 40, 7, 40, 20 + 560);
            DrawLeaves(hexColors[5],160, 30, 40, 7, 40, 0 + 560);
            DrawLeaves(hexColors[5],140, 30, 40, 6, 40, 20 + 580);
            DrawLeaves(hexColors[7],140, 30, 40, 6, 40, 0 + 580);


                //normal Dog
            void DrawDog1(float x, float y)
                {
                       //Draw Back left leg
                    Draw.LineColor = hexColors[11];
                    Draw.LineSize = 1;
                    Draw.FillColor = hexColors[11];
                    Draw.Rectangle(x - 40, y + 15, 20, 50);
                       //Draw back right leg
                    Draw.LineColor = hexColors[11];
                    Draw.LineSize = 1;
                    Draw.Quad(x + 40, y + 15, x + 70, y + 55, x + 50, y + 65, x + 20, y + 25);
                       //Draw tail
                    Draw.LineColor = hexColors[10];
                    Draw.LineSize = 1;
                    Draw.FillColor = hexColors[10];
                    Draw.Triangle(x + 30, y - 25, x + 70, y - 45, x + 50, y - 5);
                       //draw body
                    Draw.LineColor = hexColors[10];
                    Draw.LineSize = 1;
                    Draw.FillColor = hexColors[10];
                       //subtract half values of length and height to put mouse in center of body
                    Draw.Rectangle(x - 50, y - 25, 100, 50);
                       //draw front left leg
                    Draw.LineColor = hexColors[10];
                    Draw.LineSize = 1;
                    Draw.FillColor = hexColors[10];
                    Draw.Quad(x - 40, y + 15, x - 70, y + 55, x - 50, y + 65, x - 20, y + 25);
                       //draw front right leg
                    Draw.LineColor = hexColors[10];
                    Draw.LineSize = 1;
                    Draw.FillColor = hexColors[10];
                    Draw.Rectangle(x + 20, y + 15, 20, 50);
                       //draw left ear
                    Draw.LineColor = hexColors[10];
                    Draw.LineSize = 1;
                    Draw.FillColor = hexColors[10];
                    Draw.Triangle(x - 70, y - 45, x - 60, y - 65, x - 50, y - 45);
                       //draw right ear
                    Draw.LineColor = hexColors[10];
                    Draw.LineSize = 1;
                    Draw.FillColor = hexColors[10];
                    Draw.Triangle(x - 40, y - 45, x - 30, y - 65, x - 20, y - 45);
                       //draw head
                    Draw.LineColor = hexColors[10];
                    Draw.LineSize = 1;
                    Draw.FillColor = hexColors[10];
                    Draw.Square(x - 70, y - 45, 50);
                       //draw left eye
                    Draw.LineColor = hexColors[0];
                    Draw.LineSize = 1;
                    Draw.FillColor = hexColors[0];
                    Draw.Rectangle(x - 70, y - 30, 10, 5);
                       //draw right eye
                    Draw.LineColor = hexColors[0];
                    Draw.LineSize = 1;
                    Draw.FillColor = hexColors[0];
                    Draw.Rectangle(x - 50, y - 30, 10, 5);
                       //Draw top of mouth
                    Draw.LineColor = hexColors[10];
                    Draw.LineSize = 1;
                    Draw.FillColor = hexColors[10];
                    Draw.Rectangle(x - 90, y - 25, 40, 20);
                       //draw bottom of mouth
                    Draw.LineColor = hexColors[10];
                    Draw.LineSize = 1;
                    Draw.FillColor = hexColors[10];
                    Draw.Rectangle(x - 90, y - 10, 40, 15);
                       //draw nose
                    Draw.LineColor = hexColors[0];
                    Draw.LineSize = 1;
                    Draw.FillColor = hexColors[0];
                    Draw.Square(x - 90, y - 25, 10);
                }
            
                // barking dog
            void DrawDog2(float x, float y)
            {
                   //Draw Back left leg
                Draw.LineColor = hexColors[11];
                Draw.LineSize = 1;
                Draw.FillColor = hexColors[11];
                Draw.Rectangle(x - 40, y + 15, 20, 50);
                   //Draw back right leg
                Draw.LineColor = hexColors[11];
                Draw.LineSize = 1;
                Draw.Quad(x + 40, y + 15, x + 70, y + 55, x + 50, y + 65, x + 20, y + 25);
                   //Draw tail
                Draw.LineColor = hexColors[10];
                Draw.LineSize = 1;
                Draw.FillColor = hexColors[10];
                Draw.Triangle(x + 30, y - 25, x + 70, y - 45, x + 50, y - 5);
                   //draw body
                Draw.LineColor = hexColors[10];
                Draw.LineSize = 1;
                Draw.FillColor = hexColors[10];
                   //subtract half values of length and height to put mouse in center of body
                Draw.Rectangle(x - 50, y - 25, 100, 50);
                   //draw front left leg
                Draw.LineColor = hexColors[10];
                Draw.LineSize = 1;
                Draw.FillColor = hexColors[10];
                Draw.Quad(x - 40, y + 15, x - 70, y + 55, x - 50, y + 65, x - 20, y + 25);
                   //draw front right leg
                Draw.LineColor = hexColors[10];
                Draw.LineSize = 1;
                Draw.FillColor = hexColors[10];
                Draw.Rectangle(x + 20, y + 15, 20, 50);
                   //draw left ear
                Draw.LineColor = hexColors[10];
                Draw.LineSize = 1;
                Draw.FillColor = hexColors[10];
                Draw.Triangle(x - 70, y - 45, x - 60, y - 65, x - 50, y - 45);
                   //draw right ear
                Draw.LineColor = hexColors[10];
                Draw.LineSize = 1;
                Draw.FillColor = hexColors[10];
                Draw.Triangle(x - 40, y - 45, x - 30, y - 65, x - 20, y - 45);
                   //draw head
                Draw.LineColor = hexColors[10];
                Draw.LineSize = 1;
                Draw.FillColor = hexColors[10];
                Draw.Square(x - 70, y - 45, 50);
                   //draw left eye
                Draw.LineColor = hexColors[0];
                Draw.LineSize = 1;
                Draw.FillColor = hexColors[0];
                Draw.Quad(x - 65, y - 38, x - 65, y - 33, x - 55, y - 30, x - 55, y - 25);
                   //draw right eye
                Draw.LineColor = hexColors[0];
                Draw.LineSize = 1;
                Draw.FillColor = hexColors[0];
                Draw.Quad(x - 45, y - 25, x - 45, y - 30, x - 35, y - 33, x - 35, y - 38);
                   //Draw top of mouth
                Draw.LineColor = hexColors[10];
                Draw.LineSize = 1;
                Draw.FillColor = hexColors[10];
                Draw.Quad(x - 85, y - 35, x - 90, y - 15, x - 50, y - 25, x - 50, y - 5);
                   //draw bottom of mouth
                Draw.LineColor = hexColors[10];
                Draw.LineSize = 1;
                Draw.FillColor = hexColors[10];
                Draw.Quad(x - 90, y - 5, x - 85, y + 10, x - 50, y - 5, x - 50, y + 5);
                   //draw nose
                Draw.LineColor = hexColors[0];
                Draw.LineSize = 1;
                Draw.FillColor = hexColors[0];
                Draw.Quad(x - 85, y - 35, x - 87, y - 25, x - 75, y - 32, x - 77, y - 22);
            }
        } 
            //House Lights Off
        void DrawHouseAsleep(float x, float y)
        {
               //main house
            Draw.LineSize = 1;
            Draw.LineColor = hexColors[0];
            Draw.FillColor = hexColors[3];
            Draw.Rectangle(250, 80, 300, 170);
               //roof
            Draw.LineSize = 1;
            Draw.LineColor = hexColors[0];
            Draw.FillColor = hexColors[8];
            Draw.Triangle(250, 80, 400, 0, 550, 80);
               //Door
            Draw.LineSize = 1;
            Draw.LineColor = hexColors[0];
            Draw.FillColor = hexColors[4];
            Draw.Rectangle(370, 180, 60, 70);
               //Doorknob
            Draw.LineSize = 1;
            Draw.LineColor = hexColors[0];
            Draw.FillColor = hexColors[0];
            Draw.Circle(420, 220, 5);
               //Windows
            Draw.LineSize = 1;
            Draw.LineColor = hexColors[0];
            Draw.FillColor = hexColors[0];
            Draw.Square(290,110,40);
            Draw.Square(470,110,40);
               //window lines
            Draw.LineSize = 1;
            Draw.LineColor = hexColors[0];
            Draw.FillColor = hexColors[0];
            Draw.Line(290, 130, 330, 130);
            Draw.Line(470, 130, 510, 130);
            Draw.Line(310, 110, 310, 150);
            Draw.Line(490, 110, 490, 150);
               //grass
            Draw.LineSize = 1;
            Draw.LineColor = hexColors[6];
            Draw.FillColor = hexColors[6];
            Draw.Rectangle(0, 250, 800, 350);
        }
             //Draw House Lights On
        void DrawHouseAwake(float x, float y)
        {
               //main house
            Draw.LineSize = 1;
            Draw.LineColor = hexColors[0];
            Draw.FillColor = hexColors[3];
            Draw.Rectangle(250, 80, 300, 170);
               //roof
            Draw.LineSize = 1;
            Draw.LineColor = hexColors[0];
            Draw.FillColor = hexColors[8];
            Draw.Triangle(250, 80, 400, 0, 550, 80);
               //Door
            Draw.LineSize = 1;
            Draw.LineColor = hexColors[0];
            Draw.FillColor = hexColors[4];
            Draw.Rectangle(370, 180, 60, 70);
               //Doorknob
            Draw.LineSize = 1;
            Draw.LineColor = hexColors[0];
            Draw.FillColor = hexColors[0];
            Draw.Circle(420, 220, 5);
               //Windows
            Draw.LineSize = 1;
            Draw.LineColor = hexColors[0];
            Draw.FillColor = hexColors[12];
            Draw.Square(290, 110, 40);
            Draw.Square(470, 110, 40);
               //window lines
            Draw.LineSize = 1;
            Draw.LineColor = hexColors[0];
            Draw.FillColor = hexColors[0];
            Draw.Line(290, 130, 330, 130);
            Draw.Line(470, 130, 510, 130);
            Draw.Line(310, 110, 310, 150);
            Draw.Line(490, 110, 490, 150);
               //grass
            Draw.LineSize = 1;
            Draw.LineColor = hexColors[6];
            Draw.FillColor = hexColors[6];
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
        void DrawStars (int y, int distance, int r)
        {
            for (int i = 0; i < 50; i++)
            {
                Draw.LineSize = 0;
                Draw.FillColor = hexColors[1];
                Draw.Circle(distance * i, y * i, r);
            }
        }

    }

}