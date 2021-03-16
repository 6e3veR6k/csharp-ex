using System;
using NUnit.Framework;
using codewars_katas;

namespace test.codewars_katas
{
    [TestFixture]
    public class FireFighter_Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("Boat Rudder Mast Boat Hull Water ~~ Boat Deck Hull ~~ Propeller Deck ~~ Deck Boat Mast", FireFighter.FireFight("Boat Rudder Mast Boat Hull Water Fire Boat Deck Hull Fire Propeller Deck Fire Deck Boat Mast"));
            Assert.AreEqual("Mast Deck Engine Water ~~", FireFighter.FireFight("Mast Deck Engine Water Fire"));
            Assert.AreEqual("~~ Deck Engine Sail Deck ~~ ~~ ~~ Rudder ~~ Boat ~~ ~~ Captain", FireFighter.FireFight("Fire Deck Engine Sail Deck Fire Fire Fire Rudder Fire Boat Fire Fire Captain"));
        }

    }
}