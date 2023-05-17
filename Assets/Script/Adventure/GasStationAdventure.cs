using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GasStationAdventure : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject panel;
    public GameObject panel2;
    public GameObject enemyPanel;
    public TextMeshProUGUI adText;
    public TextMeshProUGUI countText;
    public Button btn;
    public Button saveBtn;
    public Button killBtn;

    public Image enemy;

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
                adText.text = "나무 2개를 얻었다.";
                GameManager.Instance.woodcount = 2;
                break;
            case 2:
                adText.text = "이 방엔 아무것도 없다.";
                break;
            case 3:
                adText.text = "사과 2개를 얻었다.";
                GameManager.Instance.applecount = 2;
                break;
            case 4:
                adText.text = "거기 잠깐. 가진거 다 내놔.";
                enemy.gameObject.SetActive(true);
                break;
            case 5:
                enemyPanel.SetActive(true);
                enemy.gameObject.SetActive(false);
                btn.gameObject.SetActive(false);
                count++;
                break;
            case 7:
                enemy.gameObject.SetActive(true);
                adText.text = "우..우리가 잘못했어!\n제발 한번만 살려줘!";
                saveBtn.gameObject.SetActive(true);
                killBtn.gameObject.SetActive(true);
                btn.gameObject.SetActive(false);
                break;
            case 8:
                if(SaveData.saveflag == true)
                {
                    adText.text = "고마워! 일단 이걸 가져가.\n소시지 10개를 획득했다.";
                    saveBtn.gameObject.SetActive(false);
                    killBtn.gameObject.SetActive(false);
                    GameManager.Instance.sausagecount = 10;
                    btn.gameObject.SetActive(true);
                }
                else if(SaveData.saveflag == false)
                {
                    adText.text = "위협이 되는 적들을 모두 죽였다.";
                    saveBtn.gameObject.SetActive(false);
                    killBtn.gameObject.SetActive(false);
                    btn.gameObject.SetActive(true);
                    enemy.gameObject.SetActive(false);
                }
                break;
            case 9:
                adText.text = "며칠 전부터 보이던 패거리였다.\n앞으로도 조심하도록 하자.";
                enemy.gameObject.SetActive(false);
                break;
            case 10:
                adText.text = "나무 3개를 얻었다.";
                GameManager.Instance.woodcount = 5;
                break;
            case 11:
                adText.text = "괴물이 나타났다!";
                panel.SetActive(true);
                btn.gameObject.SetActive(false);
                count++;
                break;
            case 13:
                adText.text = "이 방엔 아무것도 없다.";
                break;
            case 14:
                adText.text = "괴물이 나타났다!";
                panel2.SetActive(true);
                btn.gameObject.SetActive(false);
                count++;
                break;
            case 16:
                adText.text = "기름 3개를 획득했다.\n다 둘러본듯 하다.\n집으로 돌아가자.";
                GameManager.Instance.gascount = 3;
                break;
            case 17:
                SceneManager.LoadScene("SampleScene");
                SaveData.flag2 = false;
                SaveData.gasflag = false;
                GameManager.Instance.hourPlus();
                GameManager.Instance.minutePlus();
                break;
        }
    }

    public void CountUpdate()
    {
        countText.text = count + " / 17";
    }

    public void CountUp()
    {
        GameManager.Instance.minutePlus();
        GameManager.Instance.health -= 3;
        GameManager.Instance.mental -= 3;
        GameManager.Instance.hunger -= 5;
        count++;
    }

    public void Save()
    {
        SaveData.saveflag = true;
        count++;
    }

    public void Kill()
    {
        SaveData.saveflag = false;
        count++;
    }
}
