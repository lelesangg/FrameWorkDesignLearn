using FrameWorkDesign.Framework.Architecture;
using FrameWorkDesign.Framework.IOC;

namespace CounterApp.Scripts
{
    public class CounterApp : Architecture<CounterApp>
    {
        protected override void Init()
        {
            Register(new CounterModel());
        }
    }
}