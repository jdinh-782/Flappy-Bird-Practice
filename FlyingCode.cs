using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingCode : MonoBehaviour
{
    public GameManager gameManager;
    
    public float velocity = 1;

    private Rigidbody2D _obj;
    
    // Start is called before the first frame update
    void Start()
    {
        _obj = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //start the flying motion of the bird (left mouse click)
        if (Input.GetMouseButtonDown(0))
        {
            _obj.velocity = Vector2.up * velocity;
        }
    }

    //call when object hits a pipe to show the game over method
    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.GameOver();
    }
}
