using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftManager : MonoBehaviour
{
    public GameObject CraftPanel;
    public GameObject Bedbtn;


    public ItemSO wood;
    public ItemSO apple;
    public ItemSO gas;
    public ItemSO iron;
    public ItemSO Axe;
    public ItemSO bed;
    public ItemSO bread;
    public ItemSO meat;
    public ItemSO hamburger;

    public void Start()
    {
        if(SaveData.bedflag == true)
        {
            Bedbtn.SetActive(true);
        }
    }

    public void CraftOn()
    {
        CraftPanel.SetActive(true);
    }

    public void CraftOff()
    {
        CraftPanel.SetActive(false);
    }

    public void CraftAxe()
    {
        if(GameManager.Instance.invenSO.GetAmount(wood) >= 1 && GameManager.Instance.invenSO.GetAmount(iron) >= 1)
        {
            GameManager.Instance.invenSO.Remove(wood, 1);
            GameManager.Instance.invenSO.Remove(iron, 1);
            GameManager.Instance.invenSO.Add(Axe, 1);
            GameManager.Instance.inventory.UpdateInventory();
        }
    }

    public void CraftBed()
    {
        if (GameManager.Instance.invenSO.GetAmount(wood) >= 3)
        {
            GameManager.Instance.invenSO.Remove(wood, 3);
            Bedbtn.SetActive(true);
            SaveData.bedflag = true;
            GameManager.Instance.inventory.UpdateInventory();
        }
    }

    public void CraftHamburger()
    {
        if(GameManager.Instance.invenSO.GetAmount(meat) >= 1 && GameManager.Instance.invenSO.GetAmount(bread) >= 1)
        {
            GameManager.Instance.invenSO.Remove(meat, 1);
            GameManager.Instance.invenSO.Remove(bread, 1);
            GameManager.Instance.invenSO.Add(hamburger, 1);
            GameManager.Instance.inventory.UpdateInventory();
        }
    }

    public void Sleep()
    {
        GameManager.Instance.mental += 20;
        GameManager.Instance.health += 30;
        GameManager.Instance.hourPlus();
        GameManager.Instance.hourPlus();
        GameManager.Instance.hourPlus();
        GameManager.Instance.hourPlus();
        GameManager.Instance.hourPlus();
        GameManager.Instance.hourPlus();
        GameManager.Instance.hourPlus();
        GameManager.Instance.hourPlus();
        GameManager.Instance.hourPlus();
    }
}
