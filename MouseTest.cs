using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mouse_Simulator.Service;
using System.Linq;

namespace Mouse_Simulator
{
    [TestClass]
    public class MouseTest
    {
        public Mouse Create_Mouse_Named_Tom()
        {
            var mouse = new MouseService().CreateMouse("Tom", "Red");
            return mouse;
        }

        [TestMethod]
        public void Test_initial_mouse()
        {
            var mouse = Create_Mouse_Named_Tom();
            Assert.IsNotNull(mouse);
        }

        [TestMethod]
        public void Test_mouse_name()
        {
            // Arrange
            var mouse = Create_Mouse_Named_Tom();

            // Act
            var mouseName = mouse.Name.Mouse_name;

            // Assert
            Assert.AreEqual("Tom", mouseName);
        }

        [TestMethod]
        public void Move_Mouse()
        {
            var mouse = Create_Mouse_Named_Tom();

            var newPosition = mouse.MoveMouse(mouse, 1, 4);

            // Assert the X and Y coordinates separately
            Assert.AreEqual(1, newPosition.X);
            Assert.AreEqual(4, newPosition.Y);
        }
      

        [TestMethod]
        public void Test_mouse_light()
        {
            // Arrange

            var mouse = Create_Mouse_Named_Tom();

            // Act
            var brightness = mouse.Light.Brightness;
            var color = mouse.Light.Color;

            // Assert
            Assert.AreEqual(50, brightness);
            Assert.AreEqual("Red", color);
        }

        [TestMethod]
        public void Count_buttons()
        {
            // Arrange
            var mouse = Create_Mouse_Named_Tom();
            // Act
            var result = mouse.Buttons.Count;
            // Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Test_buttons()
        {
            // Arrange
            var mouse = Create_Mouse_Named_Tom();

            // Act
            var leftButton = mouse.Buttons.Find(b => b.Type == "left");
            var rightButton = mouse.Buttons.Find(b => b.Type == "right");

            // Assert
            Assert.IsNotNull(leftButton);
            Assert.IsNotNull(rightButton);
            Assert.AreEqual(2, leftButton.Shape.Width);
            Assert.AreEqual(5, leftButton.Shape.Height);
            Assert.AreEqual(2, rightButton.Shape.Width);
            Assert.AreEqual(5, rightButton.Shape.Height);
        }

        [TestMethod]
        public void Test_Scroll()   
        {
            // Arrange
            var mouse = Create_Mouse_Named_Tom();
            // Act
            var Scroll = mouse.Scroll;
            // Assert
            Assert.IsNotNull(Scroll);
        }

        [TestMethod]
        public void Test_Mouse_Ini_Position()
        {
            // Arrange
            var mouse = Create_Mouse_Named_Tom();

            // Act
            var initialX = mouse.Position.X;
            var initialY = mouse.Position.Y;

            // Assert
            Assert.AreEqual(0, initialX);
            Assert.AreEqual(0, initialY);
        }
      

        [TestMethod]
        public void Pressing_Button()
        {
            // Arrange
            var mouse = Create_Mouse_Named_Tom();
            
            var leftButton = mouse.Buttons.Find(b => b.Type == "left");
            var rightButton = mouse.Buttons.Find(b => b.Type == "right");
            // Act
            var pressedleftButton = mouse.PressButton(leftButton);
            var pressedrightButton = mouse.PressButton(rightButton);
            // Assert
            Assert.AreEqual("IsPressed", pressedleftButton.State);
            Assert.AreEqual("IsPressed", pressedrightButton.State);
        }

        [TestMethod]
        public void ScrollUp()
        {
            // Arrange
            var mouse = Create_Mouse_Named_Tom();
            var scroll = mouse.Scroll;
            var scroll_value = 1;
            // Act
            scroll.ScrollUp(scroll, scroll_value);

            // Assert
            Assert.AreEqual("Up", scroll.State);
            Assert.AreEqual(scroll_value, scroll.Position.X);
        }


        [TestMethod]
        public void ScrollDown()
        {
            // Arrange
            var mouse = Create_Mouse_Named_Tom();
            var scroll = mouse.Scroll;
            var scroll_value = 1;
            // Act
            scroll.ScrollDown(scroll, scroll_value);

            // Assert
            Assert.AreEqual("Down", scroll.State);
            Assert.AreEqual(-scroll_value, scroll.Position.X);
        }

        [TestMethod]
        public void InvalidCoordinates_RemainAtInitialPosition()
        {
            var mouse = Create_Mouse_Named_Tom();
            mouse.MoveMouse(mouse, -11, -4);
            Assert.AreEqual(0, mouse.Position.X);
            Assert.AreEqual(0, mouse.Position.Y);
        }

        [TestMethod]
        public void VerifyInitialState_AllButtons_NotPressed()
        {
            var mouse = Create_Mouse_Named_Tom();

            foreach (var button in mouse.Buttons)
            {
                Assert.AreEqual("Still", button.State);
            }
        }


    }

}
