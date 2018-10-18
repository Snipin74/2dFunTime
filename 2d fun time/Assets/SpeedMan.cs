using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedMan : MonoBehaviour {

    public int speed;
    public static SpeedMan instance;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);

        //Initialize the default values
        if (instance != null && instance != this)
        {
            //Another instance of game manager already exists, destroy this and return
            Destroy(gameObject);
            return;
        }
        else
        {
           instance = this;
        }
    }
}
