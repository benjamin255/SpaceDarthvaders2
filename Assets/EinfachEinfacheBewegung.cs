using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EinfachEinfacheBewegung : MonoBehaviour

{ 

    public float movementSpeed = 0.5f;
    private Vector3 movevector;

    private Rigidbody2D player;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    
       
        {
        if (Input.GetAxis("Horizontal") < 0 && transform.position.x > -8.5)
        {
            player.velocity = new Vector3(-movementSpeed, 0, 0); 

        }
        else if(Input.GetAxis("Horizontal") > 0 && transform.position.x < 8.5)
        {
            player.velocity = new Vector3(movementSpeed, 0, 0);
        }
        else
        {
            player.velocity = Vector2.zero;
        }
          
        }
    }

