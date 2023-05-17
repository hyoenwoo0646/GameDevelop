using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class HospitalAdventure : MonoBehaviour
{
    public GameObject panel;
    public GameObject panel2;
    //public GameObject panel3;
    public TextMeshProUGUI adText;
    public TextMeshProUGUI countText;
    public Button btn;
    public Button helpBtn;
    public Button nohelpBtn;
    public Image doctorImg;

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
                adText.text = "약 1개를 얻었다.";
                GameManager.Instance.pillcount = 1;
                break;
            case 2:
                adText.text = "약 2개를 얻었다.";
                GameManager.Instance.pillcount = 3;
                break;
            case 3:
                adText.text = "약 3개를 얻었다.";
                GameManager.Instance.pillcount = 6;
                break;
            case 4:
                adText.text = "괴물이 나타났다!";
                panel.SetActive(true);
                btn.gameObject.SetActive(false);
                count++;
                break;
            case 6:
                adText.text = "약 2개를 얻었다.";
                GameManager.Instance.pillcount = 8;
                break;
            case 7:
                adText.text = "약 2개를 획득했다.";
                GameManager.Instance.pillcount = 10;
                break;
            case 8:
                adText.text = "담배 3개를 획득했다.";
                GameManager.Instance.tabacocount = 3;
                break;
            case 9:
                adText.text = "저기 죄송하지만 음식을\n좀 나눠주실 수 있으실까요?";
                helpBtn.gameObject.SetActive(true);
                nohelpBtn.gameObject.SetActive(true);
                doctorImg.gameObject.SetActive(true);
                btn.gameObject.SetActive(false);
                break;
            case 10:
                if(SaveData.foodflag == true)
                {
                    adText.text = "감사합니다. 보답으로 이걸 \n드리겠습니다.\n백신을 획득했다.";
                    helpBtn.gameObject.SetActive(false);
                    nohelpBtn.gameObject.SetActive(false);
                    GameManager.Instance.vaccinecount = 1;
                    btn.gameObject.SetActive(true);
                }
                else if(SaveData.foodflag == false)
                {
                    adText.text = "어쩔수 없죠 이런 세상에..\n고민이라도 감사합니다.";
                    helpBtn.gameObject.SetActive(false);
                    nohelpBtn.gameObject.SetActive(false);
                    btn.gameObject.SetActive(true);
                }
                break;
            case 11:
                adText.text = "괴물이 나타났다!";
                doctorImg.gameObject.SetActive(false);
                panel2.SetActive(true);
                btn.gameObject.SetActive(false);
                count++;
                break;
            case 13:
                adText.text = "담배 2개를 획득했다\n다 둘러본듯 하다.\n이제 돌아가자.";
                break;
            case 14:
                SceneManager.LoadScene("SampleScene");
                SaveData.flag2 = false;
                SaveData.hospitalflag = false;
                GameManager.Instance.hourPlus();
                GameManager.Instance.hourPlus();
                GameManager.Instance.minutePlus();
                break;
        }
    }

    public void CountUpdate()
    {
        countText.text = count + " / 14";
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
        SaveData.foodflag = true;
        count++;
    }

    public void DontHelp()
    {
        SaveData.foodflag = false;
        count++;
    }
}
