
using FrameWorkDesign.Example.Command;
using UnityEngine;

namespace FrameWorkDesign.Example
{
    public class Enemy : MonoBehaviour
    {
        public GameObject gamePassPanel;
        
        private void OnMouseDown()
        {
            Destroy(gameObject);
            new KillEnemyCommand().Execute();

        }
    }
}

