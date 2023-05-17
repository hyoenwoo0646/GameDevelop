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
                adText.text = "������ ��Ÿ����!";
                panel.SetActive(true);
                btn.gameObject.SetActive(false);
                count++;
                break;
            case 3:
                adText.text = "������ ��Ÿ����!";
                panel2.SetActive(true);
                btn.gameObject.SetActive(false);
                count++;
                break;
            case 5:
                adText.text = "������ ��Ÿ����!";
                panel3.SetActive(true);
                btn.gameObject.SetActive(false);
                count++;
                break;
            case 7:
                adText.text = "������ ��Ÿ����!";
                panel4.SetActive(true);
                btn.gameObject.SetActive(false);
                count++;
                break;
            case 9:
                adText.text = "���忡 ���� �����ߴ�.";
                break;
            case 10:
                if (SaveData.endflag2 == true)
                {
                    adText.text = "�� �Ʒ��� ���� ���ϵ���\n�־��. ���� ���������.";
                    helperImg.gameObject.SetActive(true);
                }
                else if (SaveData.endflag2 == false)
                {
                    adText.text = "ȥ�� ���� ſ�� ������ ����\nã�� ���ߴ�. ������ ��濡��\n�������� �ִ�. ���� ���ΰ� ����.";
                    btn.gameObject.SetActive(false);
                    GameoverBtn.gameObject.SetActive(true);
                }
                break;
            case 11:
                if(SaveData.saveflag == true)
                {
                    adText.text = "�ű� ��, ��� ���纼��?";
                    helperImg.gameObject.SetActive(false);
                    enemyImg.gameObject.SetActive(true);
                }
                else if(SaveData.saveflag == false)
                {
                    adText.text = "������ �ȴ� ���� ���� ���� ������.\n �� ������ ���� �� ������ ���ڴ�.";
                    helperImg.gameObject.SetActive(false);
                    ClearBtn.gameObject.SetActive(true);
                    btn.gameObject.SetActive(false);
                }
                break;
            case 12:
                adText.text = "������ ����ذ� ����ذŰ�,\n�츮�� ������ ������ ����\nġ��߰���?";
                break;
            case 13:
                adText.text = "� ����. �������� �ۿ��� \n��ٸ��� ���ݾƿ�.";
                enemyImg.gameObject.SetActive(false);
                helperImg.gameObject.SetActive(true);
                break;
            case 14:
                adText.text = "���� ��� �ؾ� ����?\n���� ����ġ�� �� ���ڰ� �װ�,\n���� ����ġ�� ������ ����\n�������� �𸥴�.";
                helperImg.gameObject.SetActive(false);
                sacriBtn.gameObject.SetActive(true);
                liveBtn.gameObject.SetActive(true);
                btn.gameObject.SetActive(false);
                break;
            case 15:
                if(SaveData.sacriflag == true)
                {
                    adText.text = "� ������. ���� ���� ��Ե�\n�ϰ� ���󰡰ڽ��ϴ�.";
                    sacriBtn.gameObject.SetActive(false);
                    liveBtn.gameObject.SetActive(false);
                    normalBtn.gameObject.SetActive(true);
                }
                else if(SaveData.sacriflag == false)
                {
                    adText.text = "���� �̾��մϴ�. �ۿ��� ��ٸ���\n�ְڽ��ϴ�.";
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
