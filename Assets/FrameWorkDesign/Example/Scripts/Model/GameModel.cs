using FrameWorkDesign.Framework;
using FrameWorkDesign.Framework.BindableProperty;
using FrameWorkDesign.Framework.Singleton;

namespace FrameWorkDesign.Example.Model
{
    
    public class GameModel
    {
        public  BindableProperty<int> KillCount=new BindableProperty<int>()
        {
            Value = 0
        };
        public  BindableProperty<int> Gold = new BindableProperty<int>()
        {
            Value = 0
        };
        public  BindableProperty<int> Score = new BindableProperty<int>()
        {
            Value = 0
        };
        public  BindableProperty<int> BestScore = new BindableProperty<int>()
        {
            Value = 0
        };
    }
}