using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorMovement : MonoBehaviour
{
    private Rigidbody rb2;
    private float speed = 1;
    public bool isStarting = true;
    public void Start()
    {
        isStarting = false;
    }

    public void Update()
    {

        if (Input.GetKey(KeyCode.F))
        {
            isStarting = true;
        }

        rb2 = GetComponent<Rigidbody>();
        if (isStarting)

        {
            rb2.AddForce(Vector3.forward * speed * 0.1f);
        }

        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "ExitTriggerBox")
            {
                Destroy(gameObject);

            }
        }

    }



}

