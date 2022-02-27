using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainButtonClick : MonoBehaviour
{
    public GameObject textBox;
    public AudioSource playSound;
    public AudioSource playSound2;
    public AudioSource playSound3;
    public int generateTone;

    public void ClickTheButton()
    {
        generateTone = Random.Range(1, 6);
        if (generateTone == 1)
        {
            playSound.Play();
        }
        if (generateTone == 2)
        {
            playSound.Play();
        }
        if (generateTone == 3)
        {
            playSound.Play();
        }
        if (generateTone == 4)
        {
            playSound3.Play();
        }
        if (generateTone == 5)
        {
            playSound2.Play();
        }
        GlobalAnts.AntCount += 1;
    }
}
