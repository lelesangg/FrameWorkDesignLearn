using System;
using FrameWorkDesign.Example.Command;
using FrameWorkDesign.Example.Event;
using UnityEngine;
using UnityEngine.UI;

namespace FrameWorkDesign.Example.UI
{
    public class GameStartPanel : MonoBehaviour
    {
        
        private void Start()
        {
            transform.Find("BtnStart").GetComponent<Button>().onClick.AddListener((() =>
            {
                gameObject.SetActive(false);
                new StartGameCommand().Execute();
            }));
        }
    }
}
