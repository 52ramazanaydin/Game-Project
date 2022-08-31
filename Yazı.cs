using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yazı : MonoBehaviour
{
    // F butonuna basılınca oyuna başla ve "Oyuna başlamak için F tuşuna basın" yazısını ortadan kaldır.

    public bool isClickF = true;
    void Start()
    {
        isClickF = false;
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            isClickF = true;

        }
        if (isClickF)
        {
            Destroy(this.gameObject);
        }
    }
}
