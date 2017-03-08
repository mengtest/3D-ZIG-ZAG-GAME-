using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//to use text and ui elements
using UnityEngine.SceneManagement;//to reload the scene

public class UiManager : MonoBehaviour {
    public static UiManager instance;
    public GameObject zigzagPanel;
    public GameObject gameOverPanel;
    public GameObject tapText;
    public Text finalScore;
    public Text highScore1;
    public Text highScore2;
    public Text score;

    void Awake()//called before Start()
    {
        if (instance == null) { instance = this; }
    }
    // Use this for initialization
    void Start () {
        highScore1.text ="High Score: "+ PlayerPrefs.GetInt("highScore").ToString();
    }
    public void GameStart()
    {
        tapText.SetActive(false);
        zigzagPanel.GetComponent<Animator>().Play("panelUp");
    }
    public void GameOver()
    {
        finalScore.text = PlayerPrefs.GetInt("score").ToString();
        highScore2.text = PlayerPrefs.GetInt("highScore").ToString();
        gameOverPanel.SetActive(true);
    }

    public void Reset() {
        SceneManager.LoadScene(0);
            }

    // Update is called once per frame
    void Update () {
		score.text= PlayerPrefs.GetInt("score").ToString();
    }
}
