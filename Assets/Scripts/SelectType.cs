using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectType : MonoBehaviour
{
    public GameObject firstRandom;
    public GameObject secondRandom;
    public GameObject thirdRandom;


    public GameObject characterButton;
    public GameObject defendButton;
    public GameObject attackButton;

    private string oneBox,twoBox,threeBox;
    public bool randFlag = false;

    private int typeInput, firstIcon,secondIcon,threeIcon;

    void Start()
    {
        oneBox ="drone";
        twoBox ="character";
        threeBox = "wolf";

        typeInput = 0;
        firstIcon = 1;
        secondIcon= 1;
        threeIcon= 1;
    }

    public void StopRand()
    {
        
        randFlag = true;
        LogMessage.Log(typeInput.ToString()+":"+ firstIcon.ToString()+"-"+secondIcon.ToString()+"-"+threeIcon.ToString());
        Camera.main.GetComponent<Battle>().GetTurn(typeInput, firstIcon,secondIcon,threeIcon);
    }


    public void Select(string type)
    {

        switch (type)
            {
                case "character":
                    characterButton.transform.localScale = new Vector3(1.2f,1.2f,1.2f);
                    defendButton.transform.localScale = new Vector3(1f,1f,1f);
                    attackButton.transform.localScale = new Vector3(1f,1f,1f);

                    firstRandom.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Icons/drone");
                    secondRandom.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Icons/character");
                    thirdRandom.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Icons/wolf");

                    oneBox ="drone";
                    twoBox ="character";
                    threeBox = "wolf";

                    typeInput = 0;
                    break;
                case "defend":
                    characterButton.transform.localScale = new Vector3(1f,1f,1f);
                    defendButton.transform.localScale = new Vector3(1.2f,1.2f,1.2f);
                    attackButton.transform.localScale = new Vector3(1f,1f,1f);

                    firstRandom.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Icons/health");
                    secondRandom.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Icons/shield");
                    thirdRandom.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Icons/vampire");

                    oneBox ="health";
                    twoBox ="shield";
                    threeBox = "vampire";

                    typeInput = 1;
                    break;
                case "attack":
                    characterButton.transform.localScale = new Vector3(1f,1f,1f);
                    defendButton.transform.localScale = new Vector3(1f,1f,1f);
                    attackButton.transform.localScale = new Vector3(1.2f,1.2f,1.2f);

                    firstRandom.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Icons/attack");
                    secondRandom.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Icons/recruit");
                    thirdRandom.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Icons/poison");

                    oneBox ="attack";
                    twoBox ="recruit";
                    threeBox = "poison";

                    typeInput = 2;
                    break;
                default:
                    characterButton.transform.localScale = new Vector3(1.2f,1.2f,1.2f);
                    defendButton.transform.localScale = new Vector3(1f,1f,1f);
                    attackButton.transform.localScale = new Vector3(1f,1f,1f);

                    firstRandom.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Icons/drone");
                    secondRandom.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Icons/character");
                    thirdRandom.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Icons/wolf");

                    oneBox ="drone";
                    twoBox ="character";
                    threeBox = "wolf";

                    typeInput = 0;
                    break;
            }
        
    }

    // Update is called once per frame
    public void StartRandom()
    {
        
        if (randFlag == false)
        {
        LogMessage.Log("Start Random");   
        randFlag = true;
        StartCoroutine("RandItems1");
        StartCoroutine("RandItems2");
        StartCoroutine("RandItems3");
        }
        else
        {
         randFlag = false;
         StopCoroutine("RandItems1");   
         StopCoroutine("RandItems2"); 
         StopCoroutine("RandItems3");
         LogMessage.Log(typeInput.ToString()+":"+ firstIcon.ToString()+"-"+secondIcon.ToString()+"-"+threeIcon.ToString());
         Camera.main.GetComponent<Battle>().GetTurn(typeInput, firstIcon,secondIcon,threeIcon);
        }
    }

    IEnumerator RandItems1()
    {
        Debug.Log("Start corutine 1");
        var tmp = 0;
        while (tmp<10 && randFlag == true)
        {
        yield return new WaitForSeconds(1f);
        string onestr = oneBox;
        int one = Random.Range(0,3);
        switch (one)
            {
                case 0:
                onestr = oneBox;
                break;

                case 1:
                onestr = twoBox;
                break;

                case 2:
                onestr = threeBox;
                break;

                default:
                onestr = oneBox;
                break;
            }



        firstRandom.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Icons/"+onestr);
        Debug.Log(onestr);
        tmp += 1;
        firstIcon = one;
        
        }
        randFlag = false;
        Debug.Log("End corutine 1");


    }

    IEnumerator RandItems2()
    {
        Debug.Log("Start corutine 2");
        var tmp = 0;
        while (tmp<20 && randFlag == true)
        {
        yield return new WaitForSeconds(.5f);
        string onestr = oneBox;
        int one = Random.Range(0,3);
        switch (one)
            {
                case 0:
                onestr = oneBox;
                break;

                case 1:
                onestr = twoBox;
                break;

                case 2:
                onestr = threeBox;
                break;

                default:
                onestr = oneBox;
                break;
            }



        secondRandom.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Icons/"+onestr);
        Debug.Log(onestr);
        tmp += 1;
        
        secondIcon= one;
        
        }
        randFlag = false;
        Debug.Log("End corutine 2");

    }


    IEnumerator RandItems3()
    {
        Debug.Log("Start corutine 3");
        var tmp = 0;
        while (tmp<100 && randFlag == true)
        {
        yield return new WaitForSeconds(.1f);
        string onestr = oneBox;
        int one = Random.Range(0,3);
        switch (one)
            {
                case 0:
                onestr = oneBox;
                break;

                case 1:
                onestr = twoBox;
                break;

                case 2:
                onestr = threeBox;
                break;

                default:
                onestr = oneBox;
                break;
            }



        thirdRandom.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Icons/"+onestr);
        Debug.Log(onestr);
        tmp += 1;
       
        threeIcon= one;
        }
        randFlag = false;
        Debug.Log("End corutine 3");

    }




}
