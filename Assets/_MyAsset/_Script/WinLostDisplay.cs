using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLostDisplay : MonoBehaviour {
    public GameObject YLost, YWin;
    // Use this for initialization
    void Start () {
        YLost.SetActive(false);
        YWin.SetActive(false);
        if (GVar.isWin == false)
        {
            YLost.SetActive(true);
            YWin.SetActive(false);
        }
        else
        {
            YLost.SetActive(false);
            YWin.SetActive(true);
        }
	}
	
}
