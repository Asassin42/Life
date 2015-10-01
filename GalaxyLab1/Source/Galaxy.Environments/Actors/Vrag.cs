#region using

using System;
using System.Diagnostics;
using System.Windows;
using Galaxy.Core.Actors;
using Galaxy.Core.Environment;
using Point = System.Drawing.Point;
using Size = System.Drawing.Size;

#endregion

namespace Galaxy.Environments.Actors
{
    public class Vrag : Ship
    {
        public override void Load()
        {
            InitTimer();
            Load(@"Assets\Vrag.png");
        }

        public Vrag(ILevelInfo info) : base(info)
        {
            Width = 30;
            Height = 30;
            ActorType = ActorType.Enemy;
        }
    }
}
