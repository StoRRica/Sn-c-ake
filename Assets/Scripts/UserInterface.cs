﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UserInterface : MonoBehaviour {

    public Button exitButton;
    public Canvas menuCanvas;
    public Canvas uiCanvas;
    public Canvas gamePausedCanvas;
    public Button playButton;
    public Button continueButton;
    public Text continueText;
    public Text playText;

    public GameObject snakeObject;
    public Snake snakeScript;
    public GameObject backgroundObject;
    public AddPortal addPortalScript;
    public StartMenu startMenuScript;

    public AudioSource audioSource;

    void Start () {
        exitButton = exitButton.GetComponent<Button>();
        menuCanvas = menuCanvas.GetComponent<Canvas>();
        uiCanvas = uiCanvas.GetComponent<Canvas>();
        gamePausedCanvas = gamePausedCanvas.GetComponent<Canvas>();
        playButton = playButton.GetComponent<Button>();
        continueButton = continueButton.GetComponent<Button>();
        continueText = continueText.GetComponent<Text>();
        playText = playText.GetComponent<Text>();

        snakeObject = GameObject.FindGameObjectWithTag("Snake");
        snakeScript = snakeObject.GetComponent<Snake>();
        backgroundObject = GameObject.FindGameObjectWithTag("Background");
        addPortalScript = backgroundObject.GetComponent<AddPortal>();
        GameObject startmenu = GameObject.FindGameObjectWithTag("Startmenu");
        startMenuScript = startmenu.GetComponent<StartMenu>();

        uiCanvas.enabled = false;
    }

    // Update is called once per frame

    public void ExitGame()
    {
        playButton.enabled = false;
        continueButton.enabled = true;
        continueText.enabled = true;
        playText.enabled = false;
        startMenuScript.swithMusic();

        gamePausedCanvas.enabled = false;
        snakeScript.setPause(true);
        snakeScript.setInMenu(true);
        addPortalScript.setPause(true);
        addPortalScript.setInMenu(true);
        menuCanvas.enabled = true;
        uiCanvas.enabled = false;
        snakeScript.setInMenu(true);
        snakeScript.setPause(true);
        addPortalScript.setInMenu(true);
        addPortalScript.setPause(true);
    }
}
