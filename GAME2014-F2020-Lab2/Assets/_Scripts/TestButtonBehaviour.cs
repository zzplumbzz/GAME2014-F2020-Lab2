﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class TestButtonBehaviour : MonoBehaviour
{
    public TMP_Text SceneLabel;
    public TMP_Text LivesLabel;
    public TMP_Text ScoreLabel;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTestButtonPressed()
    {
        Debug.Log("TestButton Pressed");
        SceneLabel.text = "Test";
        LivesLabel.rectTransform.anchoredPosition = new Vector2(370.0f, -105f);
        ScoreLabel.rectTransform.anchoredPosition = new Vector2(-349.0f, -105f);
    }
}
