using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CORE : MonoBehaviour
{
    private static bool munchMode = false;
    public static float timeRemaining = 10;

    public static bool getMunchMode()
    {
        return CORE.munchMode;
    }

    public static void setMunchMode(bool b)
    {
        CORE.munchMode = b;
    }

    // Start is called before the first frame update
    void Start()
    {
        CORE.timeRemaining = 10;
    }

    /// Update is called once per frame
    void Update()
    {
        if(munchMode == true && timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            print("time is: " + timeRemaining);
        }
        else if(munchMode == true && timeRemaining <= 0)
        {
            print("Power Pellet is back off");
            CORE.munchMode = false;
            CORE.timeRemaining = 10;
            
        }
    }
}
