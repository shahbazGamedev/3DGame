﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UIFocus : MonoBehaviour 
{

	public GameObject canvasGroup;

	public GameObject button;

	float totalTime = 0f;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (EventSystem.current.currentSelectedGameObject == null)
		{
			totalTime += Time.deltaTime;
			float time = Time.deltaTime;
			if (time >= 5) 
			{
				EventSystem.current.SetSelectedGameObject (button, new BaseEventData (EventSystem.current));
			}
		}
	}
}
