using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public float forceX = 10; 
    public float forceY = 10; 
    public Rigidbody2D rb; 

    public float speed; 
    public float acceleration; 

    public GameObject StartingTimer;

    public bool timerBool = false; 




    void Start()
    {
       
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0,0);
    }







    void Update()
    {
        acceleration *= speed + Time.deltaTime; 
        GameStartTimer script = StartingTimer.GetComponent<GameStartTimer>();


        if (script.timeRemaining <= 0.0f)  
        {

            if(timerBool == false)
            {
                rb.velocity = new Vector2(forceX,forceY);
                timerBool = true;
            }
         
        }
    }



}   
