﻿using System.Text;
using Matrix.Xml.Parser;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;

namespace Matrix.Xml.Tests
{
    [TestClass]
    public class ByteBufferTests
    {
        [TestMethod]
        public void TestByteBuffer()
        {
            var b1 = Encoding.UTF8.GetBytes("Hello");
            var b2 = Encoding.UTF8.GetBytes(" ");
            var b3 = Encoding.UTF8.GetBytes("World");

            var concat123 = Encoding.UTF8.GetBytes("Hello World");
            var clear3 = Encoding.UTF8.GetBytes("lo World");
            var clear32 = Encoding.UTF8.GetBytes("World");
            var buf = new ByteBuffer();

            buf.Write(b1);
            buf.Write(b2);
            buf.Write(b3);


            buf.GetBuffer().ShouldBe(concat123);

            buf.RemoveFirst(3);
            buf.GetBuffer().ShouldBe(clear3);
            buf.RemoveFirst(3);
            buf.GetBuffer().ShouldBe(clear32);
            buf.RemoveFirst(5);
            buf.RemoveFirst(100);
         }   
    }
}
