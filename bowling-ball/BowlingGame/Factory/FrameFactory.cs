using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using BowlingGame.Models;

namespace BowlingGame.Factory
{
    public class FrameFactory: BaseFrameFactory
    {
        private const int MaxFrameCount = 10;
        public override FrameBase GetFrame(int index)
        {
            if (index == MaxFrameCount-1)
                return new LastFrame();
            else
                return new Frame();
        }
    }
}
