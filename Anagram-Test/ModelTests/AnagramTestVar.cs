using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Anagram.Models;

namespace Anagram.Tests
{
    [TestClass]
    public class AnagramTest
    {
        [TestMethod]
        public void GetAnagram_ReturnsString_String()
        {
            AnagramModel anagramVar = new AnagramModel();
            string userInput = "chatmandu";
            string testInput = "hatcl";

            Assert.AreEqual(true, anagramVar.CheckAnagram(userInput, testInput));
        }
    }
}
