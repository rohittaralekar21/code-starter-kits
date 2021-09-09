using System;
using NUnit.Framework;

namespace BowlingGame.Tests
{
    [TestFixture]
    public class BowlingGameTests
    {

        [TestCase(187, new[] { 10, 9, 1, 5, 5, 7, 2, 10, 10, 10, 9, 0, 8, 2, 9, 1, 10 }, TestName = "Problem Statement")]
        [TestCase(300, new[] { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 }, TestName = "All Strikes")]
        [TestCase(148, new[] { 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 3 }, TestName = "All Spares")]
        [TestCase(0, new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, TestName = "All Zeros")]
        [TestCase(20, new[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, TestName = "All One")]
        public void BowlingGame_IfRoll_ThenShouldCalculateExpectedResult(int expectedScore, params int[] ballScores)
        {
            BowlingGame bowlingGame = new BowlingGame();
            for (int i = 0; i < ballScores.Length; i++)
            {
                bowlingGame.Roll(ballScores[i]);
            }
            Assert.AreEqual(expectedScore, bowlingGame.GetScore());
        }
    }
}
