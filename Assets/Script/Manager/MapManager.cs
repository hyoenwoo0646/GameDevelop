using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapManager : MonoBehaviour
{
    public GameObject houseInfo;
    public GameObject gasInfo;
    public GameObject facInfo;
    public GameObject marketInfo;
    public GameObject npcInfo;
    public GameObject hospitalInfo;

    public GameObject housebtn;
    public GameObject gasbtn;
    public GameObject marketbtn;
    public GameObject npcbtn;
    public GameObject facbtn;
    public GameObject hospitalbtn;

    public GameObject textPanel;

    // Start is called before the first frame update
    void Start()
    {
        if(SaveData.flag3 == true)
        {
            textPanel.SetActive(true);
        }
        if(SaveData.houseflag == false)
        {
            housebtn.SetActive(false);
        } 
        if(SaveData.gasflag == false)
        {
            gasbtn.SetActive(false);
        }
        if(SaveData.marketflag == false)
        {
            marketbtn.SetActive(false);
        }
        if(SaveData.hospitalflag == false)
        {
            hospitalbtn.SetActive(false);
        }

        if(SaveData.endflag1 == true && GameManager.Instance.date >= 6)
        {
            npcbtn.SetActive(true);
        }

        if(SaveData.npcflag == true)
        {
            facbtn.SetActive(true);
        }
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //가정집
    public void OnHouseInfo()
    {
        houseInfo.SetActive(true);
    }
    public void OffHouseInfo()
    {
        houseInfo.SetActive(false);
    }

    public void GoHouse()
    {
        GameManager.Instance.hourPlus();

        SceneManager.LoadScene("House");
    }

    //주유소
    public void OnGasInfo()
    {
        gasInfo.SetActive(true);
    }
    public void OffGasInfo()
    {
        gasInfo.SetActive(false);
    }

    public void GoGas()
    {
        GameManager.Instance.hourPlus();
        GameManager.Instance.minutePlus();

        SceneManager.LoadScene("GasStation");
    }

    
    //공장
    public void OnFacInfo()
    {
        facInfo.SetActive(true);
    }
    public void OffFacInfo()
    {
        facInfo.SetActive(false);
    }
    public void GoFactory()
    {
        GameManager.Instance.hourPlus();
        GameManager.Instance.hourPlus();
        GameManager.Instance.hourPlus();
        GameManager.Instance.hourPlus();

        SceneManager.LoadScene("Factory");
    }


    //마켓
    public void OnMarketInfo()
    {
        marketInfo.SetActive(true);
    }
    public void OffMarketInfo()
    {
        marketInfo.SetActive(false);
    }
    public void GoMarket()
    {
        GameManager.Instance.minutePlus();

        SceneManager.LoadScene("Market");
    }


    //NPC
    public void OnNpcInfo()
    {
        npcInfo.SetActive(true);
    }
    public void OffNpcInfo()
    {
        npcInfo.SetActive(false);
    }
    public void GoNpc()
    {
        GameManager.Instance.hourPlus();
        GameManager.Instance.hourPlus();

        SceneManager.LoadScene("NpcScene");
    }

    //병원
    public void OnHospitalInfo()
    {
        hospitalInfo.SetActive(true);
    }
    public void OffHospitalInfo()
    {
        hospitalInfo.SetActive(false);
    }
    public void GoHospital()
    {
        GameManager.Instance.hourPlus();
        GameManager.Instance.hourPlus();
        GameManager.Instance.minutePlus();

        SceneManager.LoadScene("Hospital");
    }


    public void textEnd()
    {
        SaveData.flag3 = false;
        textPanel.SetActive(false);
    }
}
