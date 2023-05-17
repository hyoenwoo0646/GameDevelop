using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BossCatch : MonoBehaviour
{
    GameManager gameManager;
    RectTransform pos;
    Vector2 value;
    int count;
    int attackCount = 0;
    public GameObject panel;
    public TextMeshProUGUI adText;
    public Button btn;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameManager.Instance;
        pos = GetComponent<RectTransform>();
        count = 1;
        InvokeRepeating("valueChange", 0, 0.0001f);
    }

    // Update is called once per frame
    void Update()
    {
        AttackSuccess();
        if (pos.anchoredPosition.x <= -267)
        {
            count = 0;
        }

        else if (pos.anchoredPosition.x >= 267)
        {
            count = 1;
        }

        Catch();
    }

    void valueChange()
    {
        if (count == 0)
        {
            if (gameObject.activeSelf == true)
            {
                value.x += 2;
                pos.anchoredPosition = value;
            }

        }

        else if (count == 1)
        {
            if (gameObject.activeSelf == true)
            {
                value.x -= 2;
                pos.anchoredPosition = value;
            }

        }


    }

    void AttackSuccess()
    {
        if (pos.anchoredPosition.x >= -60 && pos.anchoredPosition.x <= 60)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                gameManager.hunger = gameManager.hunger - 3;
                Debug.Log("���� ����!");
                attackCount++;
            }
        }

        else
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                gameManager.hunger = gameManager.hunger - 3;
                gameManager.health = gameManager.health - 7;

                Debug.Log("���� ����!");
            }
        }
    }

    void Catch()
    {
        if (attackCount == 5)
        {
            btn.gameObject.SetActive(true);
            adText.text = "������ óġ�ߴ�. \n���� 2���� ȹ���ߴ�.";
            panel.SetActive(false);
        }
    }
}
