using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Level5 : MonoBehaviour
{
    
    public void Play_btn()
    {
        SceneManager.LoadScene("Level5");
    }

    public void Exit_btn()
    {
        Application.Quit();
    }
}
