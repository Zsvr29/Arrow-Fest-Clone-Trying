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
        if (other.gameObject.tag == "küp")
        {
            
            IncreaseCharacterCount(other.gameObject.GetComponent<Deðer>().sayi);
            other.gameObject.GetComponent<Collider>().enabled = false;


        }


        if (other.gameObject.tag == "eksi küp")
        {
            DecreaseCharacterCount(other.gameObject.GetComponent<Deðer>().sayi);
            other.gameObject.GetComponent<Collider>().enabled = false;
        }

    }
}
