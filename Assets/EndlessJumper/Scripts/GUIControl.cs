﻿using UnityEngine;
using System.Collections;
using System;

public class GUIControl: MonoBehaviour {


	public GameManager Game;
	public GameObject StartPanel;
	public GameObject GameOverPanel;

	// Use this for initialization
	void Start () {
		StartPanel.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void showGameOverScreen()
	{
		//show panel
		GameOverPanel.SetActive(true);
	}

	public void Action(string nameOfButton)
	{
		//this is the main function - that checks which button was pressed
		if(nameOfButton == "playBtn")
		{
			Game.resumeGame();
			StartPanel.SetActive(false);
		}

		if(nameOfButton == "restartBtn")
		{
			Application.LoadLevel(Application.loadedLevel);
		}
		else
		{
			Debug.Log("No Action defined for " + nameOfButton);
		}
	}
}
