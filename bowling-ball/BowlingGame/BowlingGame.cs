using System.Collections.Generic;
using System.Linq;
using BowlingGame.Factory;
using BowlingGame.Models;
using BowlingGame.Services;

namespace BowlingGame
{
    public class BowlingGame
    {
        private readonly IScoreCalculator _scoreCalculator;
        private readonly BaseFrameFactory _frameFactory;
        private List<FrameBase> _frames { get; }

        public BowlingGame()
        {
            _frames = new List<FrameBase>();
            _scoreCalculator = new ScoreCalculator();
            _frameFactory = new FrameFactory();
        }

        public void Roll(int pins)
        {
            if (_frames.Any() && !_frames.Last().IsFrameCompleted())
            {
                _frames.Last().AddRolls(pins);
            }
            else
            {
                var frame = _frameFactory.GetFrame(_frames.Count);
                frame.AddRolls(pins);
                _frames.Add(frame);
            }
        }

        public int GetScore()
        {
            return _scoreCalculator.CalculateScore(_frames);
        }
    }
}
