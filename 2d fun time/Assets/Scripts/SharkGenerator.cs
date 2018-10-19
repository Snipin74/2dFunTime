using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkGenerator : MonoBehaviour {

    public GameObject theShark;
    public Transform generationPoint;
    public float distanceBetween;

    private float sharkWidth;

	// Use this for initialization
	void Start () {
        sharkWidth = theShark.GetComponent<BoxCollider2D>().size.x;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x < generationPoint.position.x)
        {
            transform.position = new Vector3(transform.position.x + sharkWidth + distanceBetween, transform.position.y, transform.position.z);

            Instantiate(theShark, transform.position, transform.rotation);

            
        }
	}
}
