using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour
{
    public int id;
    public string nickName;    
    public int type;
    public int hp;
    public int power;
    public int lvl;
    public bool isActive;

    private Text hpText;

    void Start() 
    {
        hpText = gameObject.transform.GetChild(0).gameObject.GetComponent<Text>();
    }

    void Update() 
    {
        if(isActive == true)
        {
        hpText.text = hp.ToString();
        }
    }

    
}
