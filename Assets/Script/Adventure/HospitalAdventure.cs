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
                adText.text = "�� 1���� �����.";
                GameManager.Instance.pillcount = 1;
                break;
            case 2:
                adText.text = "�� 2���� �����.";
                GameManager.Instance.pillcount = 3;
                break;
            case 3:
                adText.text = "�� 3���� �����.";
                GameManager.Instance.pillcount = 6;
                break;
            case 4:
                adText.text = "������ ��Ÿ����!";
                panel.SetActive(true);
                btn.gameObject.SetActive(false);
                count++;
                break;
            case 6:
                adText.text = "�� 2���� �����.";
                GameManager.Instance.pillcount = 8;
                break;
            case 7:
                adText.text = "�� 2���� ȹ���ߴ�.";
                GameManager.Instance.pillcount = 10;
                break;
            case 8:
                adText.text = "��� 3���� ȹ���ߴ�.";
                GameManager.Instance.tabacocount = 3;
                break;
            case 9:
                adText.text = "���� �˼������� ������\n�� �����ֽ� �� �����Ǳ��?";
                helpBtn.gameObject.SetActive(true);
                nohelpBtn.gameObject.SetActive(true);
                doctorImg.gameObject.SetActive(true);
                btn.gameObject.SetActive(false);
                break;
            case 10:
                if(SaveData.foodflag == true)
                {
                    adText.text = "�����մϴ�. �������� �̰� \n�帮�ڽ��ϴ�.\n����� ȹ���ߴ�.";
                    helpBtn.gameObject.SetActive(false);
                    nohelpBtn.gameObject.SetActive(false);
                    GameManager.Instance.vaccinecount = 1;
                    btn.gameObject.SetActive(true);
                }
                else if(SaveData.foodflag == false)
                {
                    adText.text = "��¿�� ���� �̷� ����..\n����̶� �����մϴ�.";
                    helpBtn.gameObject.SetActive(false);
                    nohelpBtn.gameObject.SetActive(false);
                    btn.gameObject.SetActive(true);
                }
                break;
            case 11:
                adText.text = "������ ��Ÿ����!";
                doctorImg.gameObject.SetActive(false);
                panel2.SetActive(true);
                btn.gameObject.SetActive(false);
                count++;
                break;
            case 13:
                adText.text = "��� 2���� ȹ���ߴ�\n�� �ѷ����� �ϴ�.\n���� ���ư���.";
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
