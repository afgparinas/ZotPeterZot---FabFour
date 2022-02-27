using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SellAnts : MonoBehaviour
{

    public GameObject textBox;
    public GameObject statusBox;
    public AudioSource playSound;

    public void ClickTheButton()
    {

        if (GlobalAnts.AntCount == 0)
        {
            statusBox.GetComponent<Text>().text = "Not enough ants to sell.";
            statusBox.GetComponent<Animation>().Play("StatusAnimation");
        }
        else
        {
            playSound.Play();
            GlobalCash.CashCount += GlobalAnts.AntCount;
            GlobalAnts.AntCount = 0;
        }
    }

}
