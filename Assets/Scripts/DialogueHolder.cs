using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueHolder : MonoBehaviour {

    public string[] dialogue;

    private DialogueManager dialogManager;

	// Use this for initialization
	void Start () {
        dialogManager = FindObjectOfType<DialogueManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerStay2D(Collider2D other)
    {
        if(other.tag == "Player" && Input.GetKeyDown(KeyCode.Space) && !dialogManager.isDialogActive())
        {
            dialogManager.ShowBox(dialogue);
        }
    }
}
