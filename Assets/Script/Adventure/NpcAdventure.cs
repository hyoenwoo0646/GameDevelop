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
                adText.text = "낯선 장소에 도착해보니,\n저번에 도와준 사람이 서있다.\n가까이 가보자.";
                break;
            case 2:
                adText.text = "안녕하세요, 또 뵙네요.";
                helperImg.gameObject.SetActive(true);
                break;
            case 3:
                adText.text = "사실 다시 만나면 전해주고\n싶은 이야기가 있었어요.";
                break;
            case 4:
                adText.text = "마을 끄트머리에 공장에 가면\n봉쇄선을 뚫고 밖으로 나갈 수\n있다는 소문이 생존자들 사이에서\n돌고 있더라구요.";
                break;
            case 5:
                adText.text = "근데 혼자 가기엔 위험할 것\n같은데.. 혹시 같이 가실\n생각 있으세요?";
                btn.gameObject.SetActive(false);
                withbtn.gameObject.SetActive(true);
                solobtn.gameObject.SetActive(true);
                break;
            case 6:
                if (SaveData.endflag2 == true)
                {
                    adText.text = "고마워요. 그럼 공장에서 봐요.";
                    withbtn.gameObject.SetActive(false);
                    solobtn.gameObject.SetActive(false);
                    btn.gameObject.SetActive(true);
                }
                else if(SaveData.endflag2 == false)
                {
                    adText.text = "어쩔 수 없죠. 조심히 가세요.";
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
