using System;
using System.Reflection;

namespace FrameWorkDesign.Framework.Singleton
{
    public class Singleton<T> where T: Singleton<T>
    {
        private static T mInstance;

        public static T Instance
        {
            get
            {
                if (mInstance == null)// 反射
                {
                    var type = typeof(T);
                    //获取所有的实例构造函数或者非公共的构造函数
                    var ctors = type.GetConstructors(BindingFlags.Instance | BindingFlags.NonPublic);
                    var ctor = Array.Find(ctors, c => c.GetParameters().Length == 0);
                    if (ctor==null)
                    {
                        throw new Exception("Non Public Constructor Not Found in " + type.Name);
                    }
                    //使用 构造函数的Invoke方法来创建实例

                    mInstance= ctor.Invoke(null) as T;
                    
                }

                return mInstance;
            }
            
        }
    }
}