using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chompMove : MonoBehaviour
{
//    private Player thePlayer;
    private Rigidbody rb;
    public float speed = 2f;

    // Start is called before the first frame update
    void Start()
    {
//        CORE.setPlayer(thePlayer);
        rb = this.gameObject.GetComponent<Rigidbody>();
    }

//    public void display()
//    {
//        print("Player Script Display");
//    }

    void OnCollisionEnter(Collision collision)
    {
        this.speed = 0;
//        if(collision.gameObject.tag.Equals("enemy"))
//        {
//            //Destroy(CORE.getRoom());
//            count++;
//            if(count == 3)
//            {
//                this.thePlayer.addKill();
//                print("Kill Count: " + this.thePlayer.getKillCount());
//            }
//        }
    }

    
    // Update is called once per frame
    void Update()
    {
        //print(thePlayer.getName());
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
}
