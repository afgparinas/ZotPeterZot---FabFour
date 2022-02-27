using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoAnts : MonoBehaviour
{

    public bool CreatingAnts = false;
    public static int AntIncrease = 1;
    public int InternalIncrease;
    
    void Update()
    {
        AntIncrease = GlobalClicker.antPerSec;
        InternalIncrease = AntIncrease;
        if (CreatingAnts == false)
        {
            CreatingAnts = true;
            StartCoroutine(CreateTheAnt());

        }
    }

    IEnumerator CreateTheAnt()
    {
        GlobalAnts.AntCount += InternalIncrease;
        yield return new WaitForSeconds(1);

        CreatingAnts = false;
    }
}
