using System.Linq;

namespace BowlingGame.Models
{
    public class LastFrame: FrameBase
    {
        public override bool IsFrameCompleted()
        {
            return RollType == RollType.Normal && Rolls.Count == 2
                   || RollType == RollType.Spare && Rolls.Count == 3
                   || RollType == RollType.Strike && Rolls.Count == 3;
        }


        public override RollType RollType => Rolls.Any() && Rolls[0] == 10 ?
                                    RollType.Strike : Rolls.Sum() == 10 ?
                                    RollType.Spare : RollType.Normal;
    }
}
