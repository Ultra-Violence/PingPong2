using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XBall : MonoBehaviour
{
    public GameObject ball;
    public ColliderBall ColliderBall;
        
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "ball"){
            GameObject newBall = Instantiate(ball, new Vector3(0, 0, 0) , transform.rotation) as GameObject;
            newBall.transform.SetParent(GameObject.FindGameObjectWithTag("convas").transform, false);

            ColliderBall.balls_inGame++; 
        }
          
    }
}
