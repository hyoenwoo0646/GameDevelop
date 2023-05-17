using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager instance = null;
    public GameObject invenPanel;

    public InventoryUI inventory;
    public InventorySO invenSO;

    public int hour;
    public int minute;
    public int date;

    public string hourText;
    public string minuteText;
    public string dateText;

    public int mental;
    public int health;
    public int hunger;

    public int woodcount = 0;
    public int applecount = 0;
    public int gascount = 0;
    public int ironcount = 0;
    public int Axecount = 0;
    public int sausagecount = 0;
    public int tabacocount = 0;
    public int pillcount = 0;
    public int vaccinecount = 0;

    public SaveData savedata;

    public static GameManager Instance
    {
        get
        {
            return instance;
        }
    }

    private void Awake()
    {
        
        if (instance)
        {
            Destroy(this.gameObject);
            return;
        }

        instance = this;

        DontDestroyOnLoad(this.gameObject);
        SaveData.flag = true;
        SaveData.flag2 = true;
        SaveData.bedflag = false;
    }

    // Start is called before the first frame update
    void Start()
    {

        inventory.Init();

    
        hour = 9;
        minute = 0;
        date = 1;

        mental = 100;
        health = 100;
        hunger = 100;
    }

    // Update is called once per frame
    void Update()
    {      
        timePrint();
        if(mental > 100)
        {
            mental = 100;
        }
        if(health > 100)
        {
            health = 100;
        }
        if(hunger > 100)
        {
            hunger = 100;
        }
        
    }

    void timePrint()
    {
        switch (hour)
        {
            case 0:
                hourText = "00";
                break;
            case 1:
                hourText = "01";
                break;
            case 2:
                hourText = "02";
                break;
            case 3:
                hourText = "03";
                break;
            case 4:
                hourText = "04";
                break;
            case 5:
                hourText = "05";
                break;
            case 6:
                hourText = "06";
                break;
            case 7:
                hourText = "07";
                break;
            case 8:
                hourText = "08";
                break;
            case 9:
                hourText = "09";
                break;
            case 10:
                hourText = "10";
                break;
            case 11:
                hourText = "11";
                break;
            case 12:
                hourText = "12";
                break;
            case 13:
                hourText = "13";
                break;
            case 14:
                hourText = "14";
                break;
            case 15:
                hourText = "15";
                break;
            case 16:
                hourText = "16";
                break;
            case 17:
                hourText = "17";
                break;
            case 18:
                hourText = "18";
                break;
            case 19:
                hourText = "19";
                break;
            case 20:
                hourText = "20";
                break;
            case 21:
                hourText = "21";
                break;
            case 22:
                hourText = "22";
                break;
            case 23:
                hourText = "23";
                break;
        }
        switch (minute)
        {
            case 0:
                minuteText = "00";
                break;
            case 1:
                minuteText = "30";
                break;
        }

        dateText = date.ToString();
    }

    public void hourPlus()
    {
        if (hour == 23)
        {
            date++;
            hour = 0;
            mental = mental - 2;
        }
        else
        {
            hour++;
            mental = mental - 2;
        }
    }

    public void minutePlus()
    {
        if (minute == 0)
        {
            minute++;
            mental--;
        }
        else if (minute == 1)
        {
            minute = 0;
            mental--;
            if(hour == 23)
            {
                date++;
                hour = 0;
            }
            else
            {
                hour++;
            }
            
        }
    }

    public void datePlus()
    {
        date++;
        mental = mental - 24;
    }

    public void Test()
    {
        SceneManager.LoadScene("Adventure");
    }

    public void Hungry()
    {
        hunger = hunger - 20;
    }

    public void StartButton()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void InvenOn()
    {
        inventory.UpdateInventory();
        invenPanel.SetActive(true);
    }
}
