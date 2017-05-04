using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueHolder : MonoBehaviour {

    public string[] dialogue;

    private bool canTalk = false;

    private DialogueManager dialogManager;

	// Use this for initialization
	void Start () {
        dialogManager = FindObjectOfType<DialogueManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnGUI()
    {
        if(canTalk)
        {
            GUI.Box(new Rect(Screen.width * 0.5f - (185f * 0.5f), 200, 185, 22), "Press Space to talk.");
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        canTalk = true;

        if (other.tag == "Player" && Input.GetKeyDown(KeyCode.Space) && !dialogManager.isDialogActive())
        {
            dialogManager.ShowBox(dialogue);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        canTalk = false;
    }
}
