// Include the namespaces (code libraries) you need below.
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
        int count = 100;

        // declaring empty arrays for x and y positions, with 100 slots
        float[] xCoords;
        float[] yCoords;

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Loop Test");
            Window.SetSize(400, 400);
            Window.TargetFPS = 60;

            count = 5;

            // define arrays of size "count"
            xCoords = new float[count];
            yCoords = new float[count];

            // generate 100 x,y pairs of positions
            for (int i = 0; i < count; i++)
            {
                xCoords[i] = Random.Float(0, 400);
                yCoords[i] = Random.Float(0, 400);
            }
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.White);

            // and drawing 100 circles
            for (int i = 0; i < count; i++)
            {
                Draw.FillColor = Color.Blue;

                xCoords[i] += 10.0f * Time.DeltaTime;

                float x = xCoords[i];   // 25, 75, 125
                float y = yCoords[i];   // 300, 200, 100

                Draw.Circle(x, y, 25.0f);
            }

        }
    }

}
