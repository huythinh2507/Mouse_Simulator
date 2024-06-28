using Microsoft.VisualStudio.TestTools.UnitTesting;
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
                        Type = "left",
                        State = "Still"
                    },

                    new Button()
                    {
                        Shape = new Shape()
                        {
                            Width = "2",
                            Height = "5"
                        },
                        Type = "right",
                        State = "Still"
                    }, 

                    new Button()
                    {
                       Shape = new Shape()
                       {
                           Width = "2",
                           Height = "5"
                       },
                        Type = "forward",
                        State = "Still"
                    },
                          new Button()
                    {
                        Shape = new Shape()
                        {
                            Width = "2",
                            Height = "5"
                        },
                        Type = "backward",
                        State = "Still"
                     },
                          new Button()
                     {
                        Shape = new Shape()
                        {
                            Width = "2",
                            Height = "5"
                        },
                        Type = "middle",
                        State = "Still"
                    }
                },

                Scrolls = new List<Scroll>()
                {
                    new Scroll()
                    {
                        Shape = new Shape(),
                    Type = "up",
                    State = "Still"
                    },
                    
                    new Scroll()
                    {
                        Shape = new Shape(),
                    Type = "down",
                    State = "Still"
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





















































