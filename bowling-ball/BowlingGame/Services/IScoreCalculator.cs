using System.Collections.Generic;
using BowlingGame.Models;

namespace BowlingGame.Services
{
    public interface IScoreCalculator
    {
        /// <summary>
        /// Calculate total score
        /// </summary>
        /// <param name="frames"></param>
        /// <returns></returns>
        int CalculateScore(List<FrameBase> frames);
    }
}
