using System;
using FrameWorkDesign.Framework;
using FrameWorkDesign.Framework.BindableProperty;
using FrameWorkDesign.Framework.Singleton;
using UnityEngine;
using UnityEngine.UI;

namespace CounterApp.Scripts
{
    public class CounterViewController : MonoBehaviour
    {
        private CounterModel mCounterModel;
        private void Start()
        {
            mCounterModel = CounterApp.Get<CounterModel>();
            
            mCounterModel.Count.OnValueChanged += OnCountChange;
            
            OnCountChange(mCounterModel.Count.Value);
            transform.Find("BtnAdd").GetComponent<Button>().onClick.AddListener((() =>
            {
                new AddCountCommand().Execute();
                
            }));
            transform.Find("BtnSub").GetComponent<Button>().onClick.AddListener((() =>
            {
                new SubCountCommand().Execute();
                
               
            }));
            
        }

        private void OnCountChange(int newCount)
        {
            transform.Find("CounterText").GetComponent<Text>().text = newCount.ToString();
        }

        

        private void OnDestroy()
        {
            mCounterModel.Count.OnValueChanged -= OnCountChange;
            mCounterModel = null;
        }
    }
    public class CounterModel
    {
        
        public BindableProperty<int> Count = new BindableProperty<int>()
        {
            Value = 0
        };
    }

   
   
}