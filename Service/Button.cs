using System;

namespace Mouse_Simulator.Service
{
    public class Button
    {
        public Shape Shape { get; internal set; }
        public string Type { get; internal set; }
        public string State { get; internal set; }

        internal void Press()
        {
            throw new NotImplementedException();
        }

        internal void Release()
        {
            throw new NotImplementedException();
        }
    }
}