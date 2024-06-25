using System;
using System.Collections.Generic;

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
                        Type = "left",
                        State = "IsNotPressed"
                    },

                    new Button()
                    {
                        Shape = new Shape()
                        {
                            Width = "2",
                            Height = "5"
                        },
                        Type = "right",
                        State = "IsNotPressed"

                    },
                       new Button()
                    {
                        Shape = new Shape()
                        {
                            Width = "2",
                            Height = "5"
                        },
                        Type = "forward"
                    },
                          new Button()
                    {
                        Shape = new Shape()
                        {
                            Width = "2",
                            Height = "5"
                        },
                        Type = "backward"
                          },
                          new Button()
                            {
                        Shape = new Shape()
                        {
                            Width = "2",
                            Height = "5"
                        },
                        Type = "middle"
                    }
                },

                Scrolls = new List<Scroll>()
            {
                new Scroll()
                {
                    Shape = new Shape(),
                    Type = "up",
                    State = "still"
                },

                new Scroll()
                {
                    Shape = new Shape(),
                    Type = "down",
                    State = "still"
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
        public Button PressButton(Button button)
        {
            // Update the button state (you can modify the existing button or return a new one)
            button.State = "IsPressed";
            return button;
        }
        public Scroll ScrollUp(Scroll scroll)
        {
            // Update the button state (you can modify the existing button or return a new one)
            scroll.State = "RolledUp";
            return scroll;
        }
        public Scroll ScrollDown(Scroll scroll)
        {
            // Update the button state (you can modify the existing button or return a new one)
            scroll.State = "RolledDown";
            return scroll;
        }
    }
}





















































