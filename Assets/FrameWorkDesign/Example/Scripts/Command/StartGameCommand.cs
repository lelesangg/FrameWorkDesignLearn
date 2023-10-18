using FrameWorkDesign.Example.Event;
using FrameWorkDesign.Framework;
using FrameWorkDesign.Framework.Command;

namespace FrameWorkDesign.Example.Command
{
    public class StartGameCommand:ICommand
    {
        public void Execute()
        {
            GameStartEvent.Trigger();
        }
    }

   
}