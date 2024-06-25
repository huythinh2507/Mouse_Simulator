using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mouse_Simulator.Service;
using System.Linq;

namespace Mouse_Simulator
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_initial_mouse()
        {
            var mouse = new MouseService().CreateMouse();
            Assert.IsNotNull(mouse);
        }

        [TestMethod]
        public void Test_mouse_name()
        {
            // Arrange
            var mouse = new MouseService().CreateMouse();

            // Act
            var mouseName = mouse.Name.Mouse_name;

            // Assert
            Assert.AreEqual("Tom", mouseName);
        }

        [TestMethod]
        public void Move_Mouse()
        {
            var mouse = new MouseService().CreateMouse();
            var newPosition = new MouseService().MoveMouse(mouse, 1, 4);

            // Assert the X and Y coordinates separately
            Assert.AreEqual(1, newPosition.X);
            Assert.AreEqual(4, newPosition.Y);
        }
      

        [TestMethod]
        public void Test_mouse_light()
        {
            // Arrange
            var mouse = new MouseService().CreateMouse();

            // Act
            var brightness = mouse.Light.Brightness;
            var color = mouse.Light.Color;

            // Assert
            Assert.AreEqual("50", brightness);
            Assert.AreEqual("Red", color);
        }

        [TestMethod]
        public void Test_buttons()
        {
            // Arrange
            var mouse = new MouseService().CreateMouse();

            // Act
            var leftButton = mouse.Buttons.FirstOrDefault(b => b.Type == "left");
            var rightButton = mouse.Buttons.FirstOrDefault(b => b.Type == "right");

            // Assert
            Assert.IsNotNull(leftButton);
            Assert.IsNotNull(rightButton);
            Assert.AreEqual("2", leftButton.Shape.Width);
            Assert.AreEqual("5", leftButton.Shape.Height);
            Assert.AreEqual("2", rightButton.Shape.Width);
            Assert.AreEqual("5", rightButton.Shape.Height);
        }

        [TestMethod]
        public void Test_Scroll()
        {
            // Arrange
            var mouse = new MouseService().CreateMouse();

            // Act
            var upScroll = mouse.Scrolls.FirstOrDefault(s => s.Type == "up");
            var downScroll = mouse.Scrolls.FirstOrDefault(s => s.Type == "down");

            // Assert
            Assert.IsNotNull(upScroll);
            Assert.IsNotNull(downScroll);
        }

        [TestMethod]
        public void Test_Ini_Position()
        {
            // Arrange
            var mouse = new MouseService().CreateMouse();

            // Act
            var initialX = mouse.Position.X;
            var initialY = mouse.Position.Y;

            // Assert
            Assert.AreEqual(0, initialX);
            Assert.AreEqual(0, initialY);
        }
    }

}




