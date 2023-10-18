using System;

namespace FrameWorkDesign.Framework.BindableProperty
{
    public class BindableProperty<T> where T: IEquatable<T>//限制 T为可比较的
    {
        private T mValue = default(T);

        public Action<T> OnValueChanged;

        public T Value
        {
            get => mValue;

            set
            {
                if (!value.Equals(mValue))
                {
                    mValue = value;
                    OnValueChanged?.Invoke(value);
                }
            }
        }


    }
}
