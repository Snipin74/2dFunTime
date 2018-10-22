using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkDestroyer : MonoBehaviour {

    public GameObject SharkDestructionPoint;

	// Use this for initialization
	void Start () {

        SharkDestructionPoint = GameObject.Find("SharkDestructionPoint");
	}
	
	// Update is called once per frame
	void Update () {

        if(transform.position.x < SharkDestructionPoint.transform.position.x)
        {
            Destroy(gameObject);
        }
		
	}
}
