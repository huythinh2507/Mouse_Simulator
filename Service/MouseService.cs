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
            var mouse = new Mouse();

            // Set mouse name
            mouse.Name = CreateMouseName("Tom");

            // Add buttons
            mouse.Buttons = CreateButtons();

            // Set light properties
            mouse.Light = CreateLight("Red", "50");

            // Initialize scroll properties (assuming empty shapes for now)
            mouse.Scrolls = new List<Scroll>
            {
                CreateScroll("up", "Still"),
                CreateScroll("down", "Still")
            };

            // Set initial position
            mouse.Position = new Position { X = 0, Y = 0 };

            return mouse;
        }

        // Helper functions
        private Name CreateMouseName(string name)
        {
            return new Name { Mouse_name = name };
        }

        private List<Button> CreateButtons()
        {
            return new List<Button>
        {
            CreateButton("left", "Still"),
            CreateButton("right", "Still"),
            CreateButton("forward", "Still"),
            CreateButton("backward", "Still"),
            CreateButton("middle", "Still")
        };
        }

        private Button CreateButton(string type, string state)
        {
            return new Button
            {
                Shape = new Shape { Width = "2", Height = "5" },
                Type = type,
                State = state
            };
        }

        private Light CreateLight(string color, string brightness)
        {
            return new Light { Color = color, Brightness = brightness };
        }

        private Scroll CreateScroll(string type, string state)
        {
            return new Scroll
            {
                Shape = new Shape(), // Assuming empty shape for now
                Type = type,
                State = state
            };
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





















































