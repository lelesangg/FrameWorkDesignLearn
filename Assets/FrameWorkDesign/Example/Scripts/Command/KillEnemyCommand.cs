using FrameWorkDesign.Example.Event;
using FrameWorkDesign.Example.Model;
using FrameWorkDesign.Framework;
using FrameWorkDesign.Framework.Command;

namespace FrameWorkDesign.Example.Command
{
    public struct KillEnemyCommand:ICommand
    {
        public void Execute()
        {
            var gameModel = PointGame.Get<GameModel>();
            gameModel.KillCount.Value++;
            if (gameModel.KillCount.Value == 3)
            {
                GamePassEvent.Trigger();
            }
        }
    }
}