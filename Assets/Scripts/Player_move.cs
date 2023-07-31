using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_move : MonoBehaviour
{   
    public Transform left;
    public Transform right;

    void Update()
    {
        if(Input.mousePosition.x > left.position.x + 60 & Input.mousePosition.x < right.position.x - 60)
        gameObject.GetComponent<Transform>().position = new Vector3(Input.mousePosition.x, 15, 0);

    }

    
}
