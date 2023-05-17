using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextManager : MonoBehaviour
{
    public GameObject textPanel;
    public GameObject startPanel;
    
    void Start()
    {
        if(SaveData.flag == true)
        {
            textPanel.SetActive(true);
            startPanel.SetActive(true);
        }

        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void textEnd()
    {
        SaveData.flag = false;
        textPanel.SetActive(false);
    }

    public void gameStart()
    {
        startPanel.SetActive(false);
    }
}
