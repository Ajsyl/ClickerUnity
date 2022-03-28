using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ClickerUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI counterText;

    public void UpdateUi(int amount)
    {
        counterText.text = $"Points: {amount}";

    }

}
