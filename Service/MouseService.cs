using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Mouse_Simulator.Service
{
    public class MouseService
    {
        public MouseService()
        {
        }
        public Mouse CreateMouse()
        {
            var mouse = new Mouse()
            {

                Name = new Name()
                {
                    Mouse_name = "Tom"
                },

                Light = new Light()
                {
                    Brightness = "50",
                    Color = "Red"
                },

                Buttons = new List<Button>()
                {
                    new Button()
                    {
                        Shape = new Shape()
                        {
                            Width = "2",
                            Height = "5"
                        },
                        Type = "left"
                    },

                    new Button()
                    {
                       Shape = new Shape()
                       {
                           Width = "2",
                           Height = "5"
                       },
                       Type = "right"
                    }
                },

                Scrolls = new List<Scroll>()
                {
                    new Scroll()
                    {
                        Shape = new Shape(),
                        Type = "up"
                    },
                    
                    new Scroll()
                    {
                        Shape = new Shape(),
                        Type = "down"
                    }
                },
                    Position = new Position()
                    {
                        X = 0,
                        Y = 0
                    }
            };
            return mouse;
        }
        public Position MoveMouse(Mouse mouse, int x, int y)
        {
            if (x < 0 || y < 0)
            {
                throw new ArgumentException("Coordinates must be non-negative.");
            }

            // Calculate the new position
            var newX = mouse.Position.X + x;
            var newY = mouse.Position.Y + y;

            var newPosition = new Position { X = newX, Y = newY };

            // Update the mouse position
            mouse.Position = newPosition;

            return newPosition;
        }


    }
}













