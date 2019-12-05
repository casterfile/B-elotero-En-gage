using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneWhenClick : MonoBehaviour {

    public void LoadA(string scenename)
    {
        Debug.Log("sceneName to load: " + scenename);
        SceneManager.LoadScene(scenename);
    }

    public void LoadRan()
    {
        int DataRan = Random.Range(0, 9);
        if(DataRan > 5)
        {
            SceneManager.LoadScene("Scene03_1");
        }
        else
        {
            SceneManager.LoadScene("Scene03_2");
        }
        
    }
}
