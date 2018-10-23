using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    private scoreManager theScoreManager;

	// Use this for initialization
	void Start () {

        theScoreManager = FindObjectOfType<scoreManager>();

        theScoreManager.scoreCount = 0;
        theScoreManager.scoreIncreasing = true;
    }
	
	// Update is called once per frame
	void Update () {
        
	}
}
