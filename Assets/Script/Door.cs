using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public int lastCharacterInScene = 0;
    public GameObject[] characterArray;


    public void IncreaseCharacterCount(int count)
    {
        for (int i = 0; i < count; i++)
        {

            characterArray[lastCharacterInScene].SetActive(true);
            lastCharacterInScene++;
        }
    }
    public void DecreaseCharacterCount(int count)
    {
        for (int i = count - 1; i >= 0; i--)
        {

            characterArray[i].SetActive(false);
            // lastCharacterInScene++;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "k�p")
        {
            
            IncreaseCharacterCount(other.gameObject.GetComponent<De�er>().sayi);
            other.gameObject.GetComponent<Collider>().enabled = false;


        }


        if (other.gameObject.tag == "eksi k�p")
        {
            DecreaseCharacterCount(other.gameObject.GetComponent<De�er>().sayi);
            other.gameObject.GetComponent<Collider>().enabled = false;
        }

    }
}
