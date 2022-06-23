using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool canMove = true;
    [SerializeField] private float speed = 10f;
    [SerializeField] private float maxPos = 5f;

    void Start()
    {
        
    }

    void Update()
    {
        if(canMove)
        {
            Move();
        }
        
    }

    private void Move()
    {
        float inputX = Input.GetAxis("Horizontal");


        transform.Translate(inputX * speed * Time.deltaTime, 0f, 0f);
        float xPos = Mathf.Clamp(transform.position.x, -maxPos, maxPos);
        transform.position = new Vector3(xPos, transform.position.y, transform.position.z);
    }
}
