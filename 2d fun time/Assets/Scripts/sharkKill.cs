using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sharkKill : MonoBehaviour {

    public PlayerController targetPlayer;
    

	// Use this for initialization
	void Start () {
        targetPlayer = GameObject.FindObjectOfType(typeof(PlayerController)) as PlayerController;

    }
	
	// Update is called once per frame
	void Update () {

   
	}
    void OnTriggerEnter(Collider other)
    {
        print("Object Collided");
    }
}
