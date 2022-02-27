using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour
{
    public static int badgeCount = 0;
    public GameObject AutoAnts;
    public AudioSource playSound;


    public void StartAutoAnt()
    {
        playSound.Play();
        AutoAnts.SetActive(true);
        GlobalCash.CashCount -= GlobalClicker.antValue;
        GlobalClicker.antValue *= 2;
        GlobalClicker.turnOffButton = true;
        GlobalClicker.antPerSec += 1;
        GlobalClicker.numOfAnts += 1;
        badgeCount += 1;
    }
}
