using FrameWorkDesign.Framework;
using FrameWorkDesign.Framework.Command;

namespace CounterApp.Scripts
{
    public struct AddCountCommand:ICommand //struct 有更好的性能
    {
        public void Execute()
        {
            CounterApp.Get<CounterModel>().Count.Value++;
        }
    }
}