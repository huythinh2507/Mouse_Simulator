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
                Scroll = CreateScroll(),
                
                // Set initial position
                Position = new Position { X = 0, Y = 0 }
            };
            return mouse;
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
                CreateButton("left", _defaultState),
                CreateButton("right", _defaultState),
                CreateButton("forward", _defaultState),
                CreateButton("backward", _defaultState),
                CreateButton("middle", _defaultState)
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

        private Scroll CreateScroll()
        {
            var scroll = CreateScroll(_defaultState);
            return scroll;
        }

        private Scroll CreateScroll(string state)
        {
            return new Scroll
            {
                Shape = new Shape() 
                { 
                    Width = 2, 
                    Height = 5
                },
                State = state,
                Position = new Position() 
                { 
                    X = 0 
                }
            };
        }
    }
}