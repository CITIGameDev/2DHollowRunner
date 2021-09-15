﻿using UnityEngine;
public class BackgroundScript : MonoBehaviour
{
	[Header("Background")]
	public Renderer Background;
	public float speedBG;

	private float startPosX;
	private Transform cameraMain;

	void Start()
	{
        cameraMain = Camera.main.transform;
		startPosX = cameraMain.position.x;
		Background.sortingOrder = -5;
	}

	void Update()
	{
		float x = cameraMain.position.x - startPosX;

		if (Background != null)
		{
			float offset = (x * speedBG) % 1;
			Background.material.mainTextureOffset = new Vector2(offset, Background.material.mainTextureOffset.y);
		}
	}
}

