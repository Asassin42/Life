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
  public class Vrag2 : Ship
  {
    public Vrag2(ILevelInfo info):base(info)
    {
      Width = 30;
      Height = 30;
      ActorType = ActorType.Enemy;
    }
    public override void Load()
    {
        InitTimer();
        Load(@"Assets\Vrag2.png");
    }
 
  }
}
