using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public GameObject pausePanel;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                pausePanel.SetActive(true);
            }
            else
            {
                Time.timeScale = 1;
                pausePanel.SetActive(false);
            }
        }
    }

    public void unPause()
    {
        Time.timeScale = 1;
        pausePanel.SetActive(false);
    }
}
