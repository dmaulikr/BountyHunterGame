using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

    public GameObject dialogBox;
    public Text dialogText;

    private bool dialogActive;
    private string[] dialogLines;
    private int currentLine;
    private bool startingDialogue;

	// Use this for initialization
	void Start () {
        dialogActive = false;
        currentLine = 0;
        dialogLines = new string[0];
	}
	
	// Update is called once per frame
	void Update () {
        if(dialogActive)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if(startingDialogue)
                {
                    startingDialogue = false;
                }
                else
                {
                    currentLine++;
                }
            }

            if (currentLine >= dialogLines.Length)
            {
                dialogBox.SetActive(false);
                dialogActive = false;

                currentLine = 0;
            }

            if (currentLine < dialogLines.Length)
            {
                dialogText.text = dialogLines[currentLine];
            }
        }
    }

    public void ShowBox(string[] dialogue)
    {
        dialogLines = dialogue;
        currentLine = 0;

        dialogActive = true;
        dialogBox.SetActive(true);
        
        startingDialogue = true;
    }

    public bool isDialogActive()
    {
        return dialogActive;
    }
}
