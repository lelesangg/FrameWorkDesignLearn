using FrameWorkDesign.Example.Model;
using FrameWorkDesign.Framework.Architecture;
using FrameWorkDesign.Framework.IOC;

namespace FrameWorkDesign.Example
{
    public class PointGame: Architecture<PointGame>
    {
        protected override void Init()
        {
            Register(new GameModel());
        }
    }
}