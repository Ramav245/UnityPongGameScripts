using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 


public class Points : MonoBehaviour
{

    public Text Enemy_Points; 
    public int Enemy_Score = 0; 

    public Text Player_Points; 
    public int Player_Score = 0; 
    
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "left")
        {
            Enemy_Score += 1; 
            Enemy_Points.text = Enemy_Score.ToString(); 
        }
        else if(col.gameObject.tag == "right")
        {
            Player_Score += 1; 
            Player_Points.text = Player_Score.ToString(); 
        }
    }












}
