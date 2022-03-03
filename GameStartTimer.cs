using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 


public class GameStartTimer : MonoBehaviour
{

    public float targetTime = 60.0f;
    

    public Text GameText; 
    public int counter = 5; 

    public float timeRemaining = 5;

    void Update()
    {
        if (timeRemaining > -1)
        {
            timeRemaining -= Time.deltaTime;

            GameText.text = timeRemaining.ToString("0"); 
        }



        if(timeRemaining <= -1 )
        {
            GameText.gameObject.SetActive(false);
        }














    }
}
