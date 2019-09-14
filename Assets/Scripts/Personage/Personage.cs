using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class Personage : MonoBehaviour
    {
        public float Points = 0;
        public GameController Controller;
        public MovingController MoveController;
   //     public float rayDistance = 5;
        public Text textField;
        public Text textFieldFinal;
        public Vector3 StartPosition;

        public void Start()
        {
            Points = 0;
            textField.text = Points.ToString();
            transform.position = StartPosition;

            MoveController.speedForward = 10;
            MoveController.speed = 5;
            MoveController.CountReset = 0;
        }

        public void Update()
        {
            if (Controller.GameOver || !Controller.GameStarted)
                return;

            Points += 1f;
            textField.text = Points.ToString();
            textFieldFinal.text = Points.ToString();
//
//            var position = transform.position;
//            Ray rayDown = new Ray(position, -Vector3.up);
//            Ray rayUp = new Ray(position, Vector3.up);
//            Ray rayLeft = new Ray(position, -Vector3.right);
//            Ray rayRight = new Ray(position, Vector3.right);
//            
//            RaycastHit rayHit;
//
//            List<RaycastHit> rayHitMany = new List<RaycastHit>();
//
//            bool hittedDown = Physics.Raycast(rayDown.origin, rayDown.direction, out rayHit, rayDistance);
//            rayHitMany.Add(rayHit);
//            bool hittedUp = Physics.Raycast(rayUp.origin, rayUp.direction, out rayHit, rayDistance);
//            rayHitMany.Add(rayHit);
//
//            bool hittedLeft = Physics.Raycast(rayLeft.origin, rayLeft.direction, out rayHit, rayDistance);
//            rayHitMany.Add(rayHit);
//
//            bool hittedRight = Physics.Raycast(rayRight.origin, rayRight.direction, out rayHit, rayDistance);
//            rayHitMany.Add(rayHit);
//
//            //Debug.LogError(hittedDown + " " + hittedUp + " " + hittedLeft + " " + hittedRight);
//            if (hittedDown || hittedUp || hittedLeft || hittedRight)
//            {
//                Controller.GameOver = true;
//                Controller.GameStarted = false;
//            }
        }

//        private void OnTriggerEnter(Collider other)
//        {
//            Debug.LogError("OnTriggerEnter");
//            Controller.GameOver = true;
//            Controller.GameStarted = false;
//        }
//        
//        private void OnTriggerStay(Collider other)
//        {
//            Debug.LogError("OnTriggerStay");
//            Controller.GameOver = true;
//            Controller.GameStarted = false;
//        }
//        
//        private void OnTriggerExit(Collider other)
//        {
//            Debug.LogError("OnTriggerExit");
//            Controller.GameOver = true;
//            Controller.GameStarted = false;
//        }

        private void OnCollisionEnter(Collision other)
        {
            {
               // Debug.LogError("OnColliderEnter");

                Controller.GameOver = true;
                Controller.GameStarted = false;
            }
        }

        
//        private void OnCollisionStay(Collision other)
//        {
//            {
//                Debug.LogError("OnCollisionStay");
//
//                Controller.GameOver = true;
//                Controller.GameStarted = false;
//            }
//        }
        
//        private void OnCollisionExit(Collision other)
//        {
//            {
//                Debug.LogError("OnCollisionExit");
//
//                Controller.GameOver = true;
//                Controller.GameStarted = false;
//            }
//        }
        public void Moving()
        {
            MoveController.CastMove();
        }
    }
}