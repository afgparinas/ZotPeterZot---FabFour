using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalClicker : MonoBehaviour
{
    public GameObject fakeClicker;
    public GameObject fakeText;
    public GameObject realClicker;
    public GameObject realText;
    public int currentCash;
    public static int antValue = 10;
    public static bool turnOffButton = false;
    public GameObject antStats;
    public static int numOfAnts;
    public static int antPerSec;

    // try
    public GameObject[] hidefood;
    public GameObject[] showfood;
    public static int peterFoodCount;
    public static int counter;

    void Start()
    {
        
    }

    void Update()
    {
        currentCash = GlobalCash.CashCount;
        antStats.GetComponent<Text>().text = "Ants: " + numOfAnts + " @ " + antPerSec + " Per Second";
        fakeText.GetComponent<Text>().text = "- $" + antValue;
        realText.GetComponent<Text>().text = "- $" + antValue;

        if (PurchaseLog.badgeCount == 1)
        {
            hidefood[0].SetActive(false);
            showfood[0].SetActive(true);
        }

        if (PurchaseLog.badgeCount == 2)
        {
            hidefood[1].SetActive(false);
            showfood[1].SetActive(true);
        }

        if (PurchaseLog.badgeCount == 3)
        {
            hidefood[2].SetActive(false);
            showfood[2].SetActive(true);
        }

        if (PurchaseLog.badgeCount == 4)
        {
            hidefood[3].SetActive(false);
            showfood[3].SetActive(true);
        }

        if (PurchaseLog.badgeCount == 5)
        {
            hidefood[4].SetActive(false);
            showfood[4].SetActive(true);
        }

        if (PurchaseLog.badgeCount == 6)
        {
            hidefood[5].SetActive(false);
            showfood[5].SetActive(true);
        }

        if (currentCash >= antValue)
        {
            fakeClicker.SetActive(false);
            realClicker.SetActive(true);
        }

        if (turnOffButton == true)
        {
            realClicker.SetActive(false);
            fakeClicker.SetActive(true);
           
            turnOffButton = false;

        }
    }
}
