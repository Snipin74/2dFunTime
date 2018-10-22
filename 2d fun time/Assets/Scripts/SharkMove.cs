using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkMove : MonoBehaviour {

    public int moveShark = 10;
    [SerializeField] private float speed;

    public Transform target;
    public Transform target1;

    // Use this for initialization
    void Start() {

    }

	// Update is called once per frame
	void Update () {

        float step = speed * Time.deltaTime;
    
         transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        
    }
}


