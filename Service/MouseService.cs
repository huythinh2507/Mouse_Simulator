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
        private readonly string _defaultColor = "red";
        private readonly string _defaultState = "Still";
        private readonly int _defaultBrightness = 50;

        public MouseService()
        {
        }
        public Mouse CreateMouse(string name, string color)
        {
            var mouse = new Mouse
            {
                // Set mouse name
                Name = CreateMouseName(name),

                // Add buttons
                Buttons = CreateButtons(),

                // Set light properties
                Light = CreateLight(color ?? _defaultColor, _defaultBrightness),

                // Initialize scroll properties (assuming empty shapes for now)
                Scroll = CreateScroll(_defaultState),

                Position = new Position { X = 0, Y = 0 }
            };
            

                return mouse;
        }

        private Scroll CreateScroll(string defaultState)
        {
            return new Scroll
            {
                Shape = new Shape
                {
                    Width = 2,
                    Height = 5
                },
                State = defaultState,
                Position = new Position { X = 0}
            };
        }



        // Helper functions
        private Name CreateMouseName(string name)
        {
            return new Name 
            { 
                Mouse_name = name 
            };
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
                Shape = new Shape 
                { 
                    Width = 2, 
                    Height = 5 
                },
                Type = type,
                State = state
            };
        }

        private Light CreateLight(string color, int brightness)
        {
            return new Light 
            { 
                Color = color, 
                Brightness = brightness 
            };
        }

     

        public Button PressButton(Button button)
        {
            // Update the button state (you can modify the existing button or return a new one)
            button.State = "IsPressed";
            return button;
        }
       
    }
}