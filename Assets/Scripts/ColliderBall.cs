using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderBall : MonoBehaviour
{

    public bool inGame = true;
    public int balls_gone = 0;
    public int balls_inGame = 0;
    //public Collider2D collider;

    

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "ball"){
            balls_gone++;
        }

        if(balls_gone == balls_inGame){
            inGame = false;
        }
        
    }
    
}
