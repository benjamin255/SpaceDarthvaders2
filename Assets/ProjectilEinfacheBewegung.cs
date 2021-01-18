using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectilEinfacheBewegung : MonoBehaviour
{

    private Rigidbody2D Projectil;
    public float ProjectilSpeed = 5f;


    // Start is called before the first frame update
    void Start()
    {
        Projectil = GetComponent<Rigidbody2D>();
        Projectil.velocity = new Vector2(0, ProjectilSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.transform.parent.gameObject);
            Destroy(gameObject);
            //Siegbedingung

                
                
        }
       
    }
}
