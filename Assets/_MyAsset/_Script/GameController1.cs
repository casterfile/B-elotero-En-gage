using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController1 : MonoBehaviour {
    float timeLeft = 6.0f;
    public Text CountD;
    public GameObject PT1, PT2, PT3, PT4, PT5, PT6, PT7, PT8, PT9, PT10, PT11, PT12;
    
    // Use this for initialization
    void Start () {
        GVar.isWin = false;

        PT1.SetActive(false);
        PT2.SetActive(false);
        PT3.SetActive(false);
        PT4.SetActive(false);
        PT5.SetActive(false);
        PT6.SetActive(false);
        PT7.SetActive(false);
        PT8.SetActive(false);
        PT9.SetActive(false);

        PT10.SetActive(false);
        PT11.SetActive(false);
        PT12.SetActive(false);

        int DataRan = Random.Range(0, 9);
        if (DataRan == 1)
        {
            PT1.SetActive(true);
        }
        else if (DataRan == 2)
        {
            PT2.SetActive(true);
        }
        else if (DataRan == 3)
        {
            PT3.SetActive(true);
        }
        else if (DataRan == 4)
        {
            PT4.SetActive(true);
        }
        else if (DataRan == 5)
        {
            PT5.SetActive(true);
        }
        else if (DataRan == 6)
        {
            PT6.SetActive(true);
        }
        else if (DataRan == 7)
        {
            PT7.SetActive(true);
        }
        else if (DataRan == 8)
        {
            PT8.SetActive(true);
        }
        else if (DataRan == 9)
        {
            PT9.SetActive(true);
        }
        else if (DataRan == 10)
        {
            PT10.SetActive(true);
        }
        else if (DataRan == 11)
        {
            PT11.SetActive(true);
        }
        else
        {
            PT12.SetActive(true);
        }
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
        GVar.isWin = true;
        SceneManager.LoadScene("Scene04");
    }
}
