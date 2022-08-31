using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hareket1 : MonoBehaviour
{
    Rigidbody yercekimi;
    public int guc;
    int puan = 0;
    public Text puangoster;
   
    void Start()
    {
        yercekimi = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        float yatay = Input.GetAxisRaw("Horizontal");
        float dikey = Input.GetAxisRaw("Vertical");

        Vector3 vec = new Vector3(yatay, 0, dikey);
        yercekimi.AddForce(vec * guc);
    }
    public  void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            puan++;
            
            Destroy(other.gameObject);
        }
        puangoster.text = "Puanınız:" + puan + " / 10";
    }
}
