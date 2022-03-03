using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

     private Ball ball;
 
     [SerializeField] float movementSpeed;
 
     void Start ()
     {
         ball = FindObjectOfType<Ball>();
     }
     
     void Update ()
     {
         Vector2 ballPosition = ball.transform.position;
         Vector2 paddlePosition = this.transform.position;

         
         if(paddlePosition.y > ballPosition.y)
         {
             paddlePosition.y -= movementSpeed;
         }
         else if(paddlePosition.y < ballPosition.y)
         {
             paddlePosition.y += movementSpeed;
         }
 
         transform.position = paddlePosition;
     }
}


