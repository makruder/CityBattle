using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Defenders : MonoBehaviour
{
    public string nameDef;
    public int typeDef; // 0 - shield, 1 - freeze, 2 - vampire
    public int countDef;
    public bool isActive;

    private Text countText;

    public Defenders(string name, int type, int count, bool active)
    {
        nameDef = name;
        typeDef = type;
        countDef = count;
        isActive = active;
    }

    public Defenders()
    {
        
    }

    void Start() 
    {
        if(typeDef == 0)
        {
        countText = gameObject.transform.GetChild(0).gameObject.GetComponent<Text>();
        }
    }

    void Update() 
    {
        if(typeDef == 0)
        {
        countText.text = countDef.ToString();
        }
    }
}
