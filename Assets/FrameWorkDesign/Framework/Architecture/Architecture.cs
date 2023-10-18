using FrameWorkDesign.Framework.IOC;

namespace FrameWorkDesign.Framework.Architecture
{
   
    public abstract class Architecture<T> where T: Architecture<T>, new()
    {
        private static T mArchitecture;

        static void MakeSureArchitecture()
        {
            if (mArchitecture==null)
            {
                mArchitecture = new T();
                mArchitecture.Init();
            }
        }
        // 将 Init交给每个子类去实现 然后给子类提供必备的注册方法
        protected abstract void Init();

        private IOCContainer mContainer = new IOCContainer();
        public static T Get<T>() where T: class
        {
            MakeSureArchitecture();
            
            return mArchitecture.mContainer.Get<T>();
        }

        public void Register<T>(T instance)
        {
            MakeSureArchitecture();
            
            mArchitecture.mContainer.Register<T>(instance);
        }

    }
}