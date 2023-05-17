using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OnclickAdd : MonoBehaviour
{
    Button Invenbtn;
    Button Advenbtn;
    public ItemSO wood;
    public ItemSO apple;
    public ItemSO gas;
    public ItemSO iron;
    public ItemSO sausage;
    public ItemSO tabaco;
    public ItemSO pill;
    public ItemSO vaccine;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {       
        if (GameManager.Instance.invenPanel == null)
        {
            GameManager.Instance.invenPanel = GameObject.Find("Canvas").transform.Find("mainUI").transform.Find("Inventory").gameObject;
            GameManager.Instance.inventory = GameManager.Instance.invenPanel.GetComponent<InventoryUI>();
        }

        if (SaveData.flag2 == false)
        {
            GameManager.Instance.inventory.Init();
            Invenbtn = GameObject.Find("InvenOn").GetComponent<Button>();
            Advenbtn = GameObject.Find("Adventure").GetComponent<Button>();
            Invenbtn.onClick.AddListener(InvenOn);
            Advenbtn.onClick.AddListener(GoAdventure);
            Debug.Log("on");
            AddItem();

            SaveData.flag2 = true;
        }
    }

    public void InvenOn()
    {
        GameManager.Instance.inventory.UpdateInventory();
        GameManager.Instance.invenPanel.SetActive(true);
    }

    void AddItem()
    {
        GameManager.Instance.invenSO.Add(wood, GameManager.Instance.woodcount);
        GameManager.Instance.invenSO.Add(apple, GameManager.Instance.applecount);
        GameManager.Instance.invenSO.Add(gas, GameManager.Instance.gascount);
        GameManager.Instance.invenSO.Add(iron, GameManager.Instance.ironcount);
        GameManager.Instance.invenSO.Add(sausage, GameManager.Instance.sausagecount);
        GameManager.Instance.invenSO.Add(tabaco, GameManager.Instance.tabacocount);
        GameManager.Instance.invenSO.Add(pill, GameManager.Instance.pillcount);
        GameManager.Instance.invenSO.Add(vaccine, GameManager.Instance.vaccinecount);

        GameManager.Instance.woodcount = 0;
        GameManager.Instance.applecount = 0;
        GameManager.Instance.gascount = 0;
        GameManager.Instance.ironcount = 0;
        GameManager.Instance.sausagecount = 0;
        GameManager.Instance.tabacocount = 0;
        GameManager.Instance.pillcount = 0;
        GameManager.Instance.vaccinecount = 0;
    }

    void GoAdventure()
    {
        SceneManager.LoadScene("Adventure");
    }
}
