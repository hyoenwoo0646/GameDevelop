using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class NpcAdventure : MonoBehaviour
{
    public TextMeshProUGUI adText;
    public TextMeshProUGUI countText;
    public Button btn;
    public Image helperImg;

    public Button withbtn;
    public Button solobtn;

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
                adText.text = "���� ��ҿ� �����غ���,\n������ ������ ����� ���ִ�.\n������ ������.";
                break;
            case 2:
                adText.text = "�ȳ��ϼ���, �� �˳׿�.";
                helperImg.gameObject.SetActive(true);
                break;
            case 3:
                adText.text = "��� �ٽ� ������ �����ְ�\n���� �̾߱Ⱑ �־����.";
                break;
            case 4:
                adText.text = "���� ��Ʈ�Ӹ��� ���忡 ����\n���⼱�� �հ� ������ ���� ��\n�ִٴ� �ҹ��� �����ڵ� ���̿���\n���� �ִ��󱸿�.";
                break;
            case 5:
                adText.text = "�ٵ� ȥ�� ���⿣ ������ ��\n������.. Ȥ�� ���� ����\n���� ��������?";
                btn.gameObject.SetActive(false);
                withbtn.gameObject.SetActive(true);
                solobtn.gameObject.SetActive(true);
                break;
            case 6:
                if (SaveData.endflag2 == true)
                {
                    adText.text = "������. �׷� ���忡�� ����.";
                    withbtn.gameObject.SetActive(false);
                    solobtn.gameObject.SetActive(false);
                    btn.gameObject.SetActive(true);
                }
                else if(SaveData.endflag2 == false)
                {
                    adText.text = "��¿ �� ����. ������ ������.";
                    withbtn.gameObject.SetActive(false);
                    solobtn.gameObject.SetActive(false);
                    btn.gameObject.SetActive(true);
                }
                break;
            case 7:
                helperImg.gameObject.SetActive(false);
                SceneManager.LoadScene("SampleScene");
                SaveData.flag2 = false;
                SaveData.npcflag = true;
                break;

        }
    }

    public void CountUpdate()
    {
        countText.text = count + " / 7";
    }

    public void CountUp()
    {
        GameManager.Instance.minutePlus();
        count++;
    }

    public void SelectWith()
    {
        SaveData.endflag2 = true;
        count++;
    }

    public void SelectSolo()
    {
        SaveData.endflag2 = false;
        count++;
    }
}
