using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public bool player_enter, player_exit;

    public GameObject Magnet;

    public GameObject level;

    public void Awake()
    {
        player_enter = false;

    }
}
