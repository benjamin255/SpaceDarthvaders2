using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{

    float input;
    public float movementSpeed = 5f;

    public string axisName = "Horizontal";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       input = Input.GetAxisRaw(axisName);
    }

    public float GetInput()
    {
        return input;
    }

}
