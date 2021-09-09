using System.Linq;

namespace BowlingGame.Models
{
    public class Frame: FrameBase
    {
        public override bool IsFrameCompleted()
        {
            bool isStrike = RollType == RollType.Strike;

            bool isSpare = RollType == RollType.Spare;

            var isNormalFrame = Rolls.Count == 2;


            return isStrike
                   || isSpare
                   || isNormalFrame;
        }


        public override RollType RollType => Rolls.Any() && Rolls[0] == 10 ?
                                    RollType.Strike : Rolls.Sum() == 10 ?
                                    RollType.Spare : RollType.Normal;
        
    }
}
