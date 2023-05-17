using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyPanel : MonoBehaviour
{
    private static DontDestroyPanel instance = null;

    public static DontDestroyPanel Instance
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


    }
}
