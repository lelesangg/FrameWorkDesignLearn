using FrameWorkDesign.Framework;
using FrameWorkDesign.Framework.Command;

namespace CounterApp.Scripts
{
    public struct SubCountCommand:ICommand
    {
        public void Execute()
        {
            CounterApp.Get<CounterModel>().Count.Value--;
        }
    }
}