using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClicerManager : MonoBehaviour
{
    [SerializeField] private ClickerUI clicerUi;
    [SerializeField] private Button clickerButton;

    private int pointsCounter = 0;

    private void Start()
    {
        clicerUi.UpdateUi(pointsCounter);
        clickerButton.onClick.AddListener(AddPoints);
    }

    private void AddPoints()
    {
        pointsCounter += 1;
        clicerUi.UpdateUi(pointsCounter);
    }
}
