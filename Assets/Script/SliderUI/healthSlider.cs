using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthSlider : MonoBehaviour
{
    Slider healthbar;
    GameManager gameManager;
    private int health;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameManager.Instance;
    }

    // Update is called once per frame
    void Update()
    {

        healthbar = GameObject.Find("Health").GetComponent<Slider>();
        healthChange();
        healthbar.onValueChanged.AddListener(delegate { healthChange(); });
    }

    void healthChange()
    {
        health = gameManager.health;
        healthbar.value = health;
    }
}
