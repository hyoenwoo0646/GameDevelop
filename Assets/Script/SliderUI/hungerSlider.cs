using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hungerSlider : MonoBehaviour
{
    Slider hungerbar;
    GameManager gameManager;
    private int hunger;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameManager.Instance;
    }

    // Update is called once per frame
    void Update()
    {

        hungerbar = GameObject.Find("Hunger").GetComponent<Slider>();
        hungerChange();
        hungerbar.onValueChanged.AddListener(delegate { hungerChange(); });
    }

    void hungerChange()
    {
        hunger = gameManager.hunger;
        hungerbar.value = hunger;
    }
}
