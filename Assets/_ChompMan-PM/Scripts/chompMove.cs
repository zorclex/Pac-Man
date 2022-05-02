using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chompMove : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
    }


    void OnCollisionEnter(Collision collision)
    {
        this.speed = 0f;
        rb.velocity = Vector3.forward * speed;
    }

    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("up"))
        {
            rb.velocity = Vector3.forward * speed;
        }
        else if (Input.GetKeyDown("down"))
        {
            rb.velocity = Vector3.back * speed;
        }
        else if (Input.GetKeyDown("left"))
        {
            rb.velocity = Vector3.left * speed;
        }
        else if (Input.GetKeyDown("right"))
        {
            rb.velocity = Vector3.right * speed;
        }
        else if (Input.GetKeyDown("space"))
        {
            rb.velocity = Vector3.up * speed;
        }
    }
    //cabbage
}
