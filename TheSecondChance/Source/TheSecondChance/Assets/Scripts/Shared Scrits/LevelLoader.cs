﻿using UnityEngine;
using System.Collections;

public class LevelLoader : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void LoadFirstLevel()
	{
		Application.LoadLevel(3);
	}
}
