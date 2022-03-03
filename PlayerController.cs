using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject Ball;
    private Ball BallScript;


    void Update()
    {
        float moveVertical = Input.GetAxis("Vertical");

        gameObject.transform.Translate(0.0f, moveVertical * 0.05f, 0.0f);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "P2")
        {   
             BallScript = Ball.GetComponent<Ball>();
             BallScript.forceX = -5; 
        }
    }
}
