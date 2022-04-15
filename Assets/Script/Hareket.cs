using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hareket : MonoBehaviour
{
    public float speed;
    Rigidbody rb;
    void Start()
    {
       rb=GetComponent<Rigidbody>(); 
    }
    void Update()
    {
        float yatay = Input.GetAxis("Horizontal");
        float dikey = Input.GetAxis("Vertical");
        Vector3 vec= new Vector3(yatay,0,dikey);
        rb.AddForce(vec * speed);

    }
}
