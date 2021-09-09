using System;
using System.Collections.Generic;
using System.Text;
using BowlingGame.Models;

namespace BowlingGame.Factory
{
    public abstract class BaseFrameFactory
    {
        public abstract FrameBase GetFrame(int index);
    }
}
