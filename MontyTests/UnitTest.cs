using Microsoft.VisualStudio.TestTools.UnitTesting;
using MontyHallRESTController;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace MontyTests
{
    [TestClass]
    public class UnitTest
    {
        MontyHallProblem test = new();
        int numberOfSimulations = 100000;

        [TestMethod]
        public void CheckThatChanceOfWinningIsNotTheSameIfKeepingOrChangingDoors()
        {
            //1 is switch, 0 is keep                   
            int keptDoor = test.RunGame(numberOfSimulations, 0);
            int switchedDoor = test.RunGame(numberOfSimulations, 1);

            Assert.AreNotEqual(switchedDoor, keptDoor);

        }

        [TestMethod]
        public void CheckThatChanceOfWinningIsHigherIfSwitching()
        {
            //1 is switch, 0 is keep the door
            int keptDoor = test.RunGame(numberOfSimulations, 0);
            int switchedDoor = test.RunGame(numberOfSimulations, 1);

            Assert.That(switchedDoor, Is.GreaterThan(keptDoor));

        }
    }
}