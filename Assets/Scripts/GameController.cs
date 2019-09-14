using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class GameController : MonoBehaviour
    {
        public bool GameStarted = false;
        public bool GameOver = false;
        public Personage player;
        public GameObject PanelStart;
        public GameObject PanelOver;
        public Personage Rersonage;
        public SunTimer Sun;

        private void Start()
        {
            PanelStart.SetActive(true);
            GameStarted = false;
            GameOver = false;
            
        }

        public void Update()
        {
            if (!GameStarted && GameOver)
            {
                PanelOver.SetActive(true);
                GameOver = false;
                return;
            }

            if (!GameStarted || GameOver)
                return;
            
            player.Moving();
        }

        public void StartGame()
        {
            GameStarted = true;
            GameOver = false;
            Rersonage.Start();
            Sun.Start();
        }
    }
}