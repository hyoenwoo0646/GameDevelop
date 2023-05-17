using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class AdventureMananger : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject panel;
    public TextMeshProUGUI adText;
    public TextMeshProUGUI countText;
    public Button btn;

    int count = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CountUpdate();
        TextUpdate();
    }

    public void TextUpdate()
    {
        switch (count)
        {
            case 1:
                adText.text = "나무 1개를 얻었다.";
                GameManager.Instance.woodcount = 1;
                break;
            case 2:
                adText.text = "이 방엔 아무것도 없다.";
                break;
            case 3:
                adText.text = "사과 2개를 얻었다.";
                GameManager.Instance.applecount = 2;
                break;
            case 4:
                adText.text = "괴물이 나타났다!";
                panel.SetActive(true);
                btn.gameObject.SetActive(false);
                count++;
                break;
            case 6:
                adText.text = "이 방엔 아무것도 없다.";
                break;
            case 7:
                adText.text = "사과 2개를 획득했다.\n다 둘러본 듯 하다. \n집으로 돌아가자.";
                GameManager.Instance.applecount = 4;

                break;
            case 8:
                SceneManager.LoadScene("SampleScene");
                SaveData.flag2 = false;
                SaveData.houseflag = false;
                GameManager.Instance.hourPlus();
                break;
        }
    }

    public void CountUpdate()
    {
        countText.text = count + " / 8";
    }

    public void CountUp()
    {
        GameManager.Instance.minutePlus();
        GameManager.Instance.health -= 3;
        GameManager.Instance.mental -= 3;
        GameManager.Instance.hunger -= 5;
        count++;
    }
}
