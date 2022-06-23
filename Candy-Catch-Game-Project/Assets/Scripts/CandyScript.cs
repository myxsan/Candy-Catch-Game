using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyScript : MonoBehaviour
{    
    private void OnTriggerEnter2D(Collider2D other) {

        if(other.tag == "Player")
        {
            Destroy(gameObject);

            GameManager.instance.IncrementScore();
        }

        else if(other.tag == "Boundary")
        {
            Destroy(gameObject);

            GameManager.instance.DecreaseLife();
        }
    }
}
