using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class MarketAdventure : MonoBehaviour
{
    public GameObject panel;
    public GameObject bossPanel;
    public TextMeshProUGUI adText;
    public TextMeshProUGUI countText;
    public Button btn;
    public Image helperImg;

    public Button helpbtn;
    public Button dhelpbtn;

    public Button homebtn;

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
                adText.text = "소시지 1개를 얻었다.";
                GameManager.Instance.sausagecount = 1;
                break;
            case 2:
                adText.text = "소시지 3개를 얻었다.";
                GameManager.Instance.sausagecount = 4;
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
                adText.text = "담배 2개를 얻었다.";
                GameManager.Instance.tabacocount = 2;
                break;
            case 7:
                adText.text = "앞에 비명소리가 들린다.\n 어떤 사람이 괴물에게 공격받고 있다.\n 도와줄까?";
                btn.gameObject.SetActive(false);
                helpbtn.gameObject.SetActive(true);
                dhelpbtn.gameObject.SetActive(true);
                break;
            case 8:
                if(SaveData.endflag1 == true)
                {
                    bossPanel.SetActive(true);
                    helpbtn.gameObject.SetActive(false);
                    dhelpbtn.gameObject.SetActive(false);
                    count++;
                }
                else if(SaveData.endflag1 == false)
                {
                    adText.text = "일단 도망쳤다.\n이곳은 위험해 보이니 집으로\n돌아가자.";
                    helpbtn.gameObject.SetActive(false);
                    dhelpbtn.gameObject.SetActive(false);
                    homebtn.gameObject.SetActive(true);
                    SaveData.marketflag = false;
                }
                break;
            case 9:
                adText.text = "도와주셔서 감사합니다.\n답례로 이걸 드릴게요.\n소시지 2개를 얻었다.\n사과 3개를 얻었다.";
                if(bossPanel.activeSelf == false)
                {
                    helperImg.gameObject.SetActive(true);
                }
                GameManager.Instance.sausagecount = 6;
                GameManager.Instance.applecount = 5;
                if(bossPanel.activeSelf == false)
                {
                    btn.gameObject.SetActive(true);
                }
                break;
            case 10:
                adText.text = "언젠가 다시 만날 수\n있으면 좋겠네요.\n조심히 돌아가세요.";
                break;
            case 11:
                adText.text = "다 둘러본듯 하다.\n집으로 돌아가자.";
                helperImg.gameObject.SetActive(false);
                break;
            case 12:
                SceneManager.LoadScene("SampleScene");
                SaveData.flag2 = false;
                SaveData.marketflag = false;
                break;
        }
    }

    public void CountUpdate()
    {
        countText.text = count + " / 12";
    }

    public void CountUp()
    {
        GameManager.Instance.minutePlus();
        GameManager.Instance.health -= 3;
        GameManager.Instance.mental -= 3;
        GameManager.Instance.hunger -= 5;
        count++;
    }

    public void Help()
    {
        SaveData.endflag1 = true;
        count++;
    }

    public void DontHelp()
    {
        SaveData.endflag1 = false;
        count++;
    }

    public void GoHome()
    {
        SaveData.flag2 = false;
        GameManager.Instance.minutePlus();
        SceneManager.LoadScene("SampleScene");
    }
}
