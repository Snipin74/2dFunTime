using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScreen : MonoBehaviour {

    public string playGameLevel;

    public void playGame()
    {
        Application.LoadLevel(playGameLevel);
    }
}
