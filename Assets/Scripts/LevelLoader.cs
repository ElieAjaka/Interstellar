﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelLoader : MonoBehaviour {

	Scene scene;

	void Start () {
		scene = SceneManager.GetActiveScene();
	}
	public void Restart()
	{
		
		SceneManager.LoadScene (scene.name);
	}
	// Update is called once per frame
	void Update () {
		
	}
}
