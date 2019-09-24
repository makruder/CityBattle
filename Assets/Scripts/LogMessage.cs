using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogMessage : MonoBehaviour
{
    static Text text;
    void Start()
    {
        text = GameObject.Find("LogText").GetComponent<Text>();
    }

  
    public static void Log(string message)
    {
        string tmp = text.text;
       text.text = DateTime.Now.ToLongTimeString() +" " + message+"\n"+tmp;
    }
}
