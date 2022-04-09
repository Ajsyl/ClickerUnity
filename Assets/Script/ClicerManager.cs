using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClicerManager : MonoBehaviour
{
    [SerializeField] private ClickerUI clicerUi;
    [SerializeField] private Button clickerButton;

    private int pointsCounter; 

    private void Start()
    {
        pointsCounter = PlayerPrefs.GetInt("pointsCounter", 0);
        clicerUi.UpdateUi(pointsCounter);
        clickerButton.onClick.AddListener(AddPoints);
    }

    private void AddPoints()
    {
        pointsCounter += 1;
        PlayerPrefs.SetInt("pointsCounter",pointsCounter);
        clicerUi.UpdateUi(pointsCounter);
    }
}
