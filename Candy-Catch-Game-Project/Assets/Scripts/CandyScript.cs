using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter2D(Collider2D other) {

        if(other.tag == "Player")
        {
            Destroy(gameObject);

            GameManager.instance.IncrementScore();
            Debug.Log($"{this.name} Eaten");
        }

        else if(other.tag == "Boundary")
        {
            Destroy(gameObject);
            Debug.Log("Destroyed");
        }
    }
}
