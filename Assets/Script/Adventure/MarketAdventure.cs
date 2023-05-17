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
                adText.text = "�ҽ��� 1���� �����.";
                GameManager.Instance.sausagecount = 1;
                break;
            case 2:
                adText.text = "�ҽ��� 3���� �����.";
                GameManager.Instance.sausagecount = 4;
                break;
            case 3:
                adText.text = "��� 2���� �����.";
                GameManager.Instance.applecount = 2;
                break;
            case 4:
                adText.text = "������ ��Ÿ����!";
                panel.SetActive(true);
                btn.gameObject.SetActive(false);
                count++;
                break;
            case 6:
                adText.text = "��� 2���� �����.";
                GameManager.Instance.tabacocount = 2;
                break;
            case 7:
                adText.text = "�տ� ���Ҹ��� �鸰��.\n � ����� �������� ���ݹް� �ִ�.\n �����ٱ�?";
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
                    adText.text = "�ϴ� �����ƴ�.\n�̰��� ������ ���̴� ������\n���ư���.";
                    helpbtn.gameObject.SetActive(false);
                    dhelpbtn.gameObject.SetActive(false);
                    homebtn.gameObject.SetActive(true);
                    SaveData.marketflag = false;
                }
                break;
            case 9:
                adText.text = "�����ּż� �����մϴ�.\n��ʷ� �̰� �帱�Կ�.\n�ҽ��� 2���� �����.\n��� 3���� �����.";
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
                adText.text = "������ �ٽ� ���� ��\n������ ���ڳ׿�.\n������ ���ư�����.";
                break;
            case 11:
                adText.text = "�� �ѷ����� �ϴ�.\n������ ���ư���.";
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
