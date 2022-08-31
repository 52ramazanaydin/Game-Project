using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hesaplama : MonoBehaviour
{
    int puan = 0;
  
 
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            puan++;
        }
    }
}
