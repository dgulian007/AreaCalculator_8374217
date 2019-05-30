using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Area_Calculator;
using NUnit.Framework;

namespace Rectangle_Calculator_Test
{
    [TestFixture]
    public class RectangleTest
    {

        [Test]
        public void TestGetLength() //Method: GetLength()
        {
            int length = 5, width = 5;
            Rectangle rect = new Rectangle(length, width);
            Assert.AreEqual(rect.GetLength(), 5);
        }

        [Test]
        public void TestGetWidth() //Method: GetWidth()
        {
            int length = 9, width = 8;
            Rectangle rect = new Rectangle(length, width);
            Assert.AreEqual(rect.GetWidth(), 8);
        }

        [Test]
        public void TestSetLength() //Method: SetLength()
        {
            int length = 9, width = 2;
            Rectangle rect = new Rectangle(length, width);
            Assert.AreEqual(rect.SetLength(length), 9);
        }

        [Test]
        public void TestSetWidth() //Method: SetWidth()
        {
            int length = 10, width = 12;
            Rectangle rect = new Rectangle(length, width);
            Assert.AreEqual(rect.SetWidth(width), 12);
        }

        [Test]
        public void TestGetPerimeter() //Method: GetPerimeter()
        {
            int length = 2, width = 2;
            Rectangle rect = new Rectangle(length, width);
            Assert.AreEqual(rect.GetPerimeter(), 8);
        }

        [Test]
        public void TestGetArea() //Method: GetArea()
        {
            int length = 3, width = 9;
            Rectangle rect = new Rectangle(length, width);
            Assert.AreEqual(rect.GetArea(), 27);
        }

    }
}