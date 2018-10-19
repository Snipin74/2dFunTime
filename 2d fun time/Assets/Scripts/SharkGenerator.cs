using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkGenerator : MonoBehaviour {

    public GameObject theShark;
    public Transform generationPoint;
    public float distanceBetween, min, max;
    public bool spawning = false;
    private float sharkWidth;

	// Use this for initialization
	void Start () {
        sharkWidth = theShark.GetComponent<BoxCollider2D>().size.x;
        theShark = null;
	}
	
	// Update is called once per frame
	void Update () {
        if (!spawning)
        {
            spawning = true;
            StartCoroutine(spawn());
        }
	}

    public IEnumerator spawn()
    {
        yield return new WaitForSecondsRealtime(Random.Range(min, max));
        Instantiate(theShark, transform.position, transform.rotation);
        spawning = false;
    }
}
