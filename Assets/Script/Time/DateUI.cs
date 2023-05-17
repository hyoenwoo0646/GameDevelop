using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DateUI : MonoBehaviour
{

    GameManager gameManager;
    TextMeshProUGUI timerText;

    private string dateText;

    // Start is called before the first frame update
    void Start()
    {
        timerText = GetComponent<TextMeshProUGUI>();
        gameManager = GameManager.Instance;

    }

    // Update is called once per frame
    void Update()
    {
        dateText = gameManager.dateText;

        timerText.text = "Day : " + dateText;
    }
}
