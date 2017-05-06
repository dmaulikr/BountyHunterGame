using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestTrigger : MonoBehaviour {

    private QuestManager questManager;

    public int questNumber;

    public bool startQuest;
    public bool endQuest;

    private bool canTalk = false;
    
    // Use this for initialization
    void Start () {
        questManager = FindObjectOfType<QuestManager>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnGUI()
    {
        if (canTalk)
        {
            GUI.Box(new Rect(Screen.width * 0.5f - (185f * 0.5f), 200, 185, 22), "Press Space to talk.");
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if(other.tag == "Player" && !questManager.quests[questNumber].gameObject.activeSelf)
        {
            canTalk = true;
        }

        if (other.tag == "Player" && !questManager.questCompleted[questNumber] && Input.GetKeyDown(KeyCode.Space))
        {
            //Debug.Log("Can talk to quest assigner when the quest haven't been completed");
            if (startQuest && !questManager.quests[questNumber].gameObject.activeSelf)
            {
                Debug.Log("It is the starting quest trigger and the quest isn't active");
                questManager.quests[questNumber].gameObject.SetActive(true);
                questManager.quests[questNumber].StartQuest();
            }

            if(endQuest && questManager.quests[questNumber].gameObject.activeSelf)
            {
                Debug.Log("It is the ending quest trigger and the quest is active");
                questManager.quests[questNumber].gameObject.SetActive(false);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        canTalk = false;
    }
}
