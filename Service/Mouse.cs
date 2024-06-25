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
        public List<Scroll> Scrolls { get; set; }
        public Position Position { get; set; }
        internal Name Name { get; set; }
    }
}