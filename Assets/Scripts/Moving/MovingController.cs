using UnityEngine;

namespace DefaultNamespace
{
    public class MovingController : MonoBehaviour
    {
        public float speed = 5;
        public float speedForward = 10;
        public float speedForwardCounter = 5;
        public Personage player;
        public float MaxHeight;

        public GameController Controller;
        protected float speedForwardCount = 5f;
        protected float count = 0;


        public float CountReset
        {
            set { count = value; }
            get { return count; }
        }

        void Update()
        {
            if (!Controller.GameStarted || Controller.GameOver)
                return;

            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) && Mathf.Abs(MaxHeight) > Mathf.Abs(player.transform.position.y))
            {
                player.transform.position += player.transform.up * speed * Time.deltaTime;
            }

            if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            {
                player.transform.position -= player.transform.up * speed * Time.deltaTime;
            }

            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                player.transform.position += player.transform.right * speed * Time.deltaTime;
            }

            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                player.transform.position -= player.transform.right * speed * Time.deltaTime;
            }
        }

        public void CastMove()
        {
            player.transform.position += player.transform.forward * speedForward * Time.deltaTime;
            count += Time.deltaTime;
            if (count > speedForwardCount)
            {
                count = 0;
                speedForward += speedForwardCounter;
                speed += 0.5f;
            }
        }
    }
}