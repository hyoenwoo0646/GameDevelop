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
                adText.text = "���� 1���� �����.";
                GameManager.Instance.woodcount = 1;
                break;
            case 2:
                adText.text = "�� �濣 �ƹ��͵� ����.";
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
                adText.text = "�� �濣 �ƹ��͵� ����.";
                break;
            case 7:
                adText.text = "��� 2���� ȹ���ߴ�.\n�� �ѷ��� �� �ϴ�. \n������ ���ư���.";
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
