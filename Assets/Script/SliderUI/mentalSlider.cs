using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mentalSlider : MonoBehaviour
{
    Slider mentalbar;
    GameManager gameManager;
    private int mental;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameManager.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        
        mentalbar = GameObject.Find("Mental").GetComponent<Slider>();
        mentalChange();
        mentalbar.onValueChanged.AddListener(delegate { mentalChange(); });
    }

    void mentalChange()
    {
        mental = gameManager.mental;
        mentalbar.value = mental;
    }
}
