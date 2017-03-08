using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {
    public static ScoreManager instance;
    public int score;
    public int highScore;
    void Awake() {
        if (instance == null) {//to create a singleton instance of ScoreManager
            instance = this;
        }
    }
	// Use this for initialization
	void Start () {
        score = 0;
        PlayerPrefs.SetInt("score", score);//save the value as key value in the machine
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void incrementScore() {
        score += 1;
    }
    public void startScore()
    {
        InvokeRepetin("incrementScore", 0.1f, 0.5f);//call it after 0.1sec and after  that repeately ech 0.5 sec.
    }
    public void StopScore()
    {
        CancelInvoke("startScore");
        PlayerPrefs.SetInt("score", score);
        if (PlayerPrefs.HasKey("highScore"))
        {
            if (score > PlayerPrefs.GetInt("highScore")) {
                PlayerPrefs.SetInt("highScore", score);
            }
        }else
        {
            PlayerPrefs.SetInt("highScore", score);        }
    }
}
