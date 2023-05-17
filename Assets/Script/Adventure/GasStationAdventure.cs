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
                adText.text = "���� 2���� �����.";
                GameManager.Instance.woodcount = 2;
                break;
            case 2:
                adText.text = "�� �濣 �ƹ��͵� ����.";
                break;
            case 3:
                adText.text = "��� 2���� �����.";
                GameManager.Instance.applecount = 2;
                break;
            case 4:
                adText.text = "�ű� ���. ������ �� ����.";
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
                adText.text = "��..�츮�� �߸��߾�!\n���� �ѹ��� �����!";
                saveBtn.gameObject.SetActive(true);
                killBtn.gameObject.SetActive(true);
                btn.gameObject.SetActive(false);
                break;
            case 8:
                if(SaveData.saveflag == true)
                {
                    adText.text = "����! �ϴ� �̰� ������.\n�ҽ��� 10���� ȹ���ߴ�.";
                    saveBtn.gameObject.SetActive(false);
                    killBtn.gameObject.SetActive(false);
                    GameManager.Instance.sausagecount = 10;
                    btn.gameObject.SetActive(true);
                }
                else if(SaveData.saveflag == false)
                {
                    adText.text = "������ �Ǵ� ������ ��� �׿���.";
                    saveBtn.gameObject.SetActive(false);
                    killBtn.gameObject.SetActive(false);
                    btn.gameObject.SetActive(true);
                    enemy.gameObject.SetActive(false);
                }
                break;
            case 9:
                adText.text = "��ĥ ������ ���̴� �аŸ�����.\n�����ε� �����ϵ��� ����.";
                enemy.gameObject.SetActive(false);
                break;
            case 10:
                adText.text = "���� 3���� �����.";
                GameManager.Instance.woodcount = 5;
                break;
            case 11:
                adText.text = "������ ��Ÿ����!";
                panel.SetActive(true);
                btn.gameObject.SetActive(false);
                count++;
                break;
            case 13:
                adText.text = "�� �濣 �ƹ��͵� ����.";
                break;
            case 14:
                adText.text = "������ ��Ÿ����!";
                panel2.SetActive(true);
                btn.gameObject.SetActive(false);
                count++;
                break;
            case 16:
                adText.text = "�⸧ 3���� ȹ���ߴ�.\n�� �ѷ����� �ϴ�.\n������ ���ư���.";
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
