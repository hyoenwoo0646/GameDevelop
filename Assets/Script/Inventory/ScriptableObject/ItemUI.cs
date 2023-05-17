using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemUI : MonoBehaviour
{
    [SerializeField] private Image icon;
    [SerializeField] private TextMeshProUGUI count;


    [SerializeField] public Item curItem;
    
    public void Init()
    {
        icon.color = new Color(255, 255, 255, 0);
        count.text = " ";

        curItem = null;
    }

    public void DrawUI(Item item = null)
    {
        if(item != null)
        {
            curItem = item;

        }

        icon.color = new Color(255, 255, 255, 255);
        icon.sprite = curItem.ItemData.Icon;

        count.text = curItem.Amount.ToString();
    }
}
