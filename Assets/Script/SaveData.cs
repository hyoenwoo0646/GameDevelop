using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable][CreateAssetMenu(fileName = "SaveData", menuName = "Data/SaveData")]
public class SaveData : ScriptableObject
{
    public static bool flag = true;
    public static bool flag2 = true;
    public static bool flag3 = true;

    public static bool houseflag = true;
    public static bool gasflag = true;
    public static bool marketflag = true;
    public static bool npcflag = false;
    public static bool hospitalflag = true;

    public static bool bedflag = true;

    public static bool endflag1 = false;
    public static bool endflag2 = false;
    public static bool foodflag = false;
    public static bool saveflag = false;

    public static bool sacriflag = false;
}
