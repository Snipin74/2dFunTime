using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour {

    public Text scoreText;
    public Text hiScoreText;

    public float scoreCount;
    public float hiScoreCount;

    public float pointsPerSecond;
    public bool scoreIncreasing;

    private scoreManager theScoreManager;

    // Use this for initialization
    void Start () {
        theScoreManager = FindObjectOfType<scoreManager>();
    }
	
	// Update is called once per frame
	void Update () {

      //  if (scoreIncreasing)
       // {
            scoreCount += pointsPerSecond * Time.deltaTime;
       // }

       // if (scoreCount > hiScoreCount)
        //{
       //     hiScoreCount = scoreCount;
        //}
        scoreText.text = "Score: " + Mathf.Round (scoreCount);
        //hiScoreText.text = "High Score: " + Mathf.Round (hiScoreCount); 
	}

    public void addScore(int pointsToAdd)
    {
        scoreCount += pointsToAdd;
    }
}
