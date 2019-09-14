using UnityEngine;
using UnityEngine.Analytics;

namespace DefaultNamespace
{
    public class SunTimer:MonoBehaviour
    {
        public GameObject Sun;
        public Vector3 StartPosition;
        public float Timer;
        public float BaseSpeed;
        public GameController Controller;
        protected float currentTime = 0;
        
        public void Start()
        {
            Sun.transform.position = StartPosition;
            currentTime = Timer;
        }

        void Update()
        {
           if (Controller.GameStarted && !Controller.GameOver)
           {
               Sun.transform.position += -Sun.transform.up * BaseSpeed * Time.deltaTime;
               currentTime -= Time.deltaTime;
               if (currentTime <= 0)
               {
                   Controller.GameStarted = false;
                   Controller.GameOver = true;
               }
           }
        }
    }
}