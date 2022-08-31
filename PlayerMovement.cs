using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb2;
    public float speed = 1;
    public bool isStarting = true;
    public GameObject gameOverMenu;
    public PauseMenu pause_m;
    public void Start()
    {
        void Start()
        {
            isStarting = false;
        }
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
            // A tuşuna basınca sola hareket eder.

            rb2.AddForce(Vector3.forward * speed * 0.1f);

            if (Input.GetKey(KeyCode.A))
            {
                rb2.AddForce(Vector3.left * speed);

            }

            // D tuşuna basınca sağa hareket eder.

            if (Input.GetKey(KeyCode.D))
            {
                rb2.AddForce(Vector3.right * speed);
            }

        }


    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ExitTriggerBox")
        {

              Destroy(gameObject);

            //Enable Game Over Menu
            gameOverMenu.SetActive(true);

            //Disable Pause Menu
            pause_m.isGameOver = true;


        }
    }


}