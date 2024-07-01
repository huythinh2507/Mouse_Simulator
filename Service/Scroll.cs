using System;

namespace Mouse_Simulator.Service
{
    public class Scroll
    {
        public Shape Shape { get; set; }
        public string State { get; internal set; }
        public Position Position { get; internal set; }

        public Scroll ScrollUp(Scroll scroll, int v)
        {
            scroll.State = "Up";
            int v1 = scroll.Position.X + v;
            scroll.Position.X = v1;
            return scroll;
        }

        public Scroll ScrollDown(Scroll scroll, int v)
        {
            // Update the button state (you can modify the existing button or return a new one)
            scroll.State = "Down";
            int v1 = scroll.Position.X - v;
            scroll.Position.X = v1;
            return scroll;
        }
    }
}