using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InventoryClick : MonoBehaviour, IPointerDownHandler
{
    public ItemSO apple;
    public ItemSO sausage;
    public ItemSO tabaco;
    public ItemSO pill;
    public ItemSO hamburger;

    public void OnPointerDown(PointerEventData eventData)
    {
        if (this.gameObject.GetComponent<ItemUI>().curItem == null)
            return;
        if(this.gameObject.GetComponent<ItemUI>().curItem.ItemData == apple)
        {
            if(GameManager.Instance.hunger < 100)
            {
                GameManager.Instance.invenSO.Remove(this.gameObject.GetComponent<ItemUI>().curItem.ItemData, 1);

                GameManager.Instance.hunger += 5;
            }            
        }
        if (this.gameObject.GetComponent<ItemUI>().curItem.ItemData == sausage)
        {
            if (GameManager.Instance.hunger < 100)
            {
                GameManager.Instance.invenSO.Remove(this.gameObject.GetComponent<ItemUI>().curItem.ItemData, 1);

                GameManager.Instance.hunger += 15;
            }
                
        }
        if (this.gameObject.GetComponent<ItemUI>().curItem.ItemData == tabaco)
        {
            if (GameManager.Instance.mental < 100)
            {
                GameManager.Instance.invenSO.Remove(this.gameObject.GetComponent<ItemUI>().curItem.ItemData, 1);

                GameManager.Instance.mental += 5;
            }           
        }
        if (this.gameObject.GetComponent<ItemUI>().curItem.ItemData == pill)
        {
            if (GameManager.Instance.health < 100)
            {
                GameManager.Instance.invenSO.Remove(this.gameObject.GetComponent<ItemUI>().curItem.ItemData, 1);

                GameManager.Instance.health += 10;
            }
                
        }
        GameManager.Instance.inventory.UpdateInventory();

    }
}
