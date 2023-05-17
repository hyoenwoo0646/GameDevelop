using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class FactoryAdventure : MonoBehaviour
{
    public GameObject panel;
    public GameObject panel2;
    public GameObject panel3;
    public GameObject panel4;
    public TextMeshProUGUI adText;
    public TextMeshProUGUI countText;
    public Button btn;
    public Button GameoverBtn;
    public Button ClearBtn;
    public Image helperImg;
    public Image enemyImg;

    public Button sacriBtn;
    public Button liveBtn;
    public Button normalBtn;

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
                adText.text = "괴물이 나타났다!";
                panel.SetActive(true);
                btn.gameObject.SetActive(false);
                count++;
                break;
            case 3:
                adText.text = "괴물이 나타났다!";
                panel2.SetActive(true);
                btn.gameObject.SetActive(false);
                count++;
                break;
            case 5:
                adText.text = "괴물이 나타났다!";
                panel3.SetActive(true);
                btn.gameObject.SetActive(false);
                count++;
                break;
            case 7:
                adText.text = "괴물이 나타났다!";
                panel4.SetActive(true);
                btn.gameObject.SetActive(false);
                count++;
                break;
            case 9:
                adText.text = "공장에 끝에 도착했다.";
                break;
            case 10:
                if (SaveData.endflag2 == true)
                {
                    adText.text = "이 아래로 가면 지하도가\n있어요. 저를 따라오세요.";
                    helperImg.gameObject.SetActive(true);
                }
                else if (SaveData.endflag2 == false)
                {
                    adText.text = "혼자 오는 탓에 나가는 길을\n찾지 못했다. 괴물이 사방에서\n몰려오고 있다. 이제 끝인것 같다.";
                    btn.gameObject.SetActive(false);
                    GameoverBtn.gameObject.SetActive(true);
                }
                break;
            case 11:
                if(SaveData.saveflag == true)
                {
                    adText.text = "거기 둘, 잠깐 멈춰볼까?";
                    helperImg.gameObject.SetActive(false);
                    enemyImg.gameObject.SetActive(true);
                }
                else if(SaveData.saveflag == false)
                {
                    adText.text = "한참을 걷다 보니 작은 빛이 보였다.\n 얼른 가족을 만날 수 있으면 좋겠다.";
                    helperImg.gameObject.SetActive(false);
                    ClearBtn.gameObject.SetActive(true);
                    btn.gameObject.SetActive(false);
                }
                break;
            case 12:
                adText.text = "저번에 살려준건 살려준거고,\n우리의 물건을 가져간 값은\n치뤄야겠지?";
                break;
            case 13:
                adText.text = "어서 가요. 가족들이 밖에서 \n기다리고 있잖아요.";
                enemyImg.gameObject.SetActive(false);
                helperImg.gameObject.SetActive(true);
                break;
            case 14:
                adText.text = "나는 어떻게 해야 하지?\n지금 도망치면 저 여자가 죽고,\n지금 도망치지 않으면 내가\n죽을지도 모른다.";
                helperImg.gameObject.SetActive(false);
                sacriBtn.gameObject.SetActive(true);
                liveBtn.gameObject.SetActive(true);
                btn.gameObject.SetActive(false);
                break;
            case 15:
                if(SaveData.sacriflag == true)
                {
                    adText.text = "어서 가세요. 여긴 제가 어떻게든\n하고 따라가겠습니다.";
                    sacriBtn.gameObject.SetActive(false);
                    liveBtn.gameObject.SetActive(false);
                    normalBtn.gameObject.SetActive(true);
                }
                else if(SaveData.sacriflag == false)
                {
                    adText.text = "정말 미안합니다. 밖에서 기다리고\n있겠습니다.";
                    sacriBtn.gameObject.SetActive(false);
                    liveBtn.gameObject.SetActive(false);
                    normalBtn.gameObject.SetActive(true);
                }
                break;
            case 16:

                break;
        }
    }

    public void CountUpdate()
    {
        countText.text = count + " / 15";
    }

    public void CountUp()
    {
        GameManager.Instance.minutePlus();
        GameManager.Instance.health -= 3;
        GameManager.Instance.mental -= 3;
        GameManager.Instance.hunger -= 5;
        count++;
    }

    public void GameOver()
    { 
        SceneManager.LoadScene("Bad End1");
    }

    public void Clear()
    {
        if(SaveData.foodflag == true)
        {
            SceneManager.LoadScene("True End");

        }
        else if(SaveData.foodflag == false)
        {
            SceneManager.LoadScene("Bad End2");
        }
    }

    public void normalEnd()
    {
        if(SaveData.sacriflag == true)
        {
            SceneManager.LoadScene("Normal End2");
        }
        else if(SaveData.sacriflag == false)
        {
            SceneManager.LoadScene("Normal End1");
        }
    }

    public void Sacrifice()
    {
        SaveData.sacriflag = true;
        count++;
    }

    public void Live()
    {
        SaveData.sacriflag = false;
        count++;
    }
}
