using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggers : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
//        PacMacScript.incrimentScore();
//        print("trigger!");
//        PacMacScript.theScoreTextMesh.text = "whack";
        if(this.gameObject.tag.Equals("PowerPellet") && other.gameObject.tag.Equals("Player"))
        {
            Destroy(this.gameObject);
            print("PowerPellet eaten by player");
//            count++;
        }
        else if(this.gameObject.tag.Equals("LeftTeleport") && other.gameObject.tag.Equals("Player"))
        {
            other.gameObject.transform.position = new Vector3 (8.0f, 0.5f, 0.5f);
            print("Player entered Left Teleporter");
        }
        else if(this.gameObject.tag.Equals("RightTeleport") && other.gameObject.tag.Equals("Player"))
        {
            other.gameObject.transform.position = new Vector3 (-8.0f, 0.5f, 0.5f);
            print("Player entered Right Teleporter");
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
