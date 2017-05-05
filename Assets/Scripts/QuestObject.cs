﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestObject : MonoBehaviour {

    public int questNumber;
    public QuestManager questManager;

    public string[] startText;
    public string[] endText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StartQuest()
    {
        questManager.showQuestText(startText);

    }

    public void EndQuest()
    {
        questManager.showQuestText(endText);
        questManager.questCompleted[questNumber] = true;
        this.gameObject.SetActive(false);
    }
}