using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 




public class GameOver : MonoBehaviour
{

    



    public GameObject Ball;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Points pointsScript = Ball.GetComponent<Points>();
        Ball ballScript = Ball.GetComponent<Ball>();


        if(pointsScript.Player_Score  >= 5 || pointsScript.Player_Score >= 5)
        {
            SceneManager.LoadScene("MainMenu"); 
        }














    }
}   
