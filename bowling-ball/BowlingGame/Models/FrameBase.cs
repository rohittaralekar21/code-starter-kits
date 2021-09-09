using System.Collections.Generic;
using System.Linq;

namespace BowlingGame.Models
{
    public abstract class FrameBase
    {
        protected FrameBase()
        {
            Rolls = new List<int>();
        }

        public List<int> Rolls { get; set; }

        public abstract bool IsFrameCompleted();

        public virtual RollType RollType { get; } = RollType.Normal;
        public int Score {
            get
            {
                return Rolls.Sum();
            }
        }

        public void AddRolls(int pins)
        {
            Rolls.Add(pins);
        }

    }
}
