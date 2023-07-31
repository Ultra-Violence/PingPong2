using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public void Awake()
    {
        int random = Random.Range(1,4);
        if(random == 1){
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector3(1, 1, 0) * 3);
        }
        else if(random == 2){
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, 1, 0) * 3);
        }
        else if(random == 3){
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector3(-1, -1, 0) * 3);
        }
        else if(random == 4){
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector3(1, -1, 0) * 3);
        }

        

    }

    
}
