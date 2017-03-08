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
    public Text score;
    public Text highScore1;
    public Text highScore2;

    void Awake()//called before Start()
    {
        if (instance == null) { instance = this; }
    }
    // Use this for initialization
    void Start () {
		
	}
    public void GameStart()
    {
        tapText.SetActive(false);
        zigzagPanel.GetComponent<Animator>().Play("panelUp");
    }
    public void GameOver()
    {
        gameOverPanel.SetActive(true);
    }

    public void Reset() {
        SceneManager.LoadScene(0);
            }

    // Update is called once per frame
    void Update () {
		
	}
}
