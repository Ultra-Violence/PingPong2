using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panel : MonoBehaviour
{
    public Score_script score;
    private void OnCollisionEnter2D(Collision2D other) {
        Destroy(gameObject);
        score.score += 1;
    }
}
