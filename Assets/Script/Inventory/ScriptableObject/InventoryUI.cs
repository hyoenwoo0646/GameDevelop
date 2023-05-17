using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{

    [SerializeField] public InventorySO inventory;

    [SerializeField] private Transform parent;
    [SerializeField] private int slotsNum;

    [SerializeField] private GameObject slotPrefab;
    [SerializeField] private List<ItemUI> slots = new List<ItemUI>();


    public void Init()
    {
        //�κ��丮 ���� ����
        for(int i= 0; i < slotsNum; i++)
        {
            GameObject go = Instantiate(slotPrefab);
            go.transform.SetParent(parent);

            slots.Add(go.GetComponent<ItemUI>());
        }
    }

    //�κ��丮�� ������ ��Ȳ���� call
    public void UpdateInventory()
    {
        foreach(ItemUI data in slots)
        {
            data.Init();
        }

        int i = 0;
        foreach (Item data in inventory.Items)
        {
            slots[i].DrawUI(data);
            i++;
        }
    }

    public void InvenOff()
    {
        this.gameObject.SetActive(false);
    }
}
