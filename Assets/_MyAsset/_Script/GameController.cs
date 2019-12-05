using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
    float timeLeft = 60.0f, ScoreNum  = 00.0f;
    public Text CountD , TxtScoreNum;
    public GameObject PT1, PT2, PT3, btnWrongTouch, btnTouch01;
    
    // Use this for initialization
    void Start () {
        ReloadGame();


    }
	
	// Update is called once per frame
	void Update () {

        timeLeft -= Time.deltaTime;
        int CDownInt = (int)timeLeft;
        CountD.text = CDownInt + "";
        if (timeLeft < 0)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        print("GameOver");
        GVar.isWin = false;
        SceneManager.LoadScene("Scene04");
    }

    public void ClickWinGame()
    {
        print("Game Win");
        
        SceneManager.LoadScene("Scene04");
    }

    public void Touch01Win()
    {
        TxtScoreNum.text = "10";
        GVar.isWin = true;
        PT1.SetActive(false);
        PT2.SetActive(false);
        PT3.SetActive(true);
        btnWrongTouch.SetActive(false);
        btnTouch01.SetActive(false);
    }

    public void WrongTouch()
    {
        GVar.isWin = false;
        PT1.SetActive(false);
        PT2.SetActive(true);
        PT3.SetActive(false);
        btnWrongTouch.SetActive(false);
        btnTouch01.SetActive(false);
    }

    public void ReloadGame()
    {
        timeLeft = 61.0f;
        ScoreNum = 0f;
        TxtScoreNum.text = ScoreNum + "0";
        GVar.isWin = false;

        PT1.SetActive(true);
        PT2.SetActive(false);
        PT3.SetActive(false);
        btnWrongTouch.SetActive(true);
        btnTouch01.SetActive(true);
    }
}
