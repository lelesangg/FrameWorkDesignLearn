using System;
using FrameWorkDesign.Example.Event;
using UnityEngine;

namespace FrameWorkDesign.Example.UI
{
    public class UI : MonoBehaviour
    {
        private void Start()
        {
            GamePassEvent.Register(OnGamePass);
        }

        private void OnGamePass()
        {
            transform.Find("Canvas/GamePassPanel").gameObject.SetActive(true);
        }

        private void OnDestroy()
        {
            GamePassEvent.UnRegister(OnGamePass);
        }
    }
}