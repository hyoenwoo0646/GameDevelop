using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class TimerUI : MonoBehaviour
{
    GameManager gameManager;
    TextMeshProUGUI timerText;

    private string hourText;
    private string minuteText;

    void Start()
    {
        timerText = GetComponent<TextMeshProUGUI>();
        gameManager = GameManager.Instance;

    }

    // Update is called once per frame
    void Update()
    {
        hourText = gameManager.hourText;
        minuteText = gameManager.minuteText;


        timerText.text = hourText + " : " + minuteText;
    }

}
