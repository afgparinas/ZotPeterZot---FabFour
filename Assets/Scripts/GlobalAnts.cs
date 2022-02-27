using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalAnts : MonoBehaviour
{
    public static int AntCount;
    public GameObject AntDisplay;
    public int InternalAnt;

    void Update()
    {
        InternalAnt = AntCount;
        AntDisplay.GetComponent<Text>().text = ": " + InternalAnt;
    }
   
}
