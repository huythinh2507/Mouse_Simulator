using System;
using System.Collections.Generic;

namespace Mouse_Simulator.Service
{
    public class Mouse
    {

        public Mouse()
        {
        }

        public Light Light { get; set; }
        public List<Button> Buttons { get; set; }
        public Scroll Scroll { get; set; }
        public Position Position { get; set; }
        internal Name Name { get; set; }

        public Position MoveMouse(Mouse mouse, int x, int y)
        {
            // Calculate the new position
            var newX = mouse.Position.X + Math.Max(0, x);
            var newY = mouse.Position.Y + Math.Max(0, y);

            var newPosition = new Position { X = newX, Y = newY };

            // Update the mouse position
            mouse.Position = newPosition;

            return newPosition;
        }

        
        
        public Button PressButton(Button button)
        {
            // Update the button state (you can modify the existing button or return a new one)
            button.State = "IsPressed";
            return button;
        }

       
    }
}