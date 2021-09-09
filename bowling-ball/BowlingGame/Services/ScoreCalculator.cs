using System.Collections.Generic;
using BowlingGame.Models;

namespace BowlingGame.Services
{
    public class ScoreCalculator : IScoreCalculator
    {
        public int CalculateScore(List<FrameBase> frames)
        {
            int score = 0;
            for (int i = 0; i < frames.Count; i++)
            {
                score += frames[i].Score + CalculateBonus(frames, i);
            }

            return score;
        }
        
        private int CalculateBonus(List<FrameBase> frames, int index)
        {
            var frame = frames[index];
            if (frame is LastFrame) return 0;

            switch (frame.RollType)
            {
                case RollType.Normal:
                    return 0;
                case RollType.Spare:
                    return frames[index + 1].Rolls[0];
                case RollType.Strike:
                    return frames[index + 1].Rolls.Count > 1
                        ? frames[index + 1].Rolls[0] + frames[index + 1].Rolls[1]
                        : frames[index + 1].Rolls[0] + frames[index + 2].Rolls[0];
            }

            return 0;
        }
    }
}
