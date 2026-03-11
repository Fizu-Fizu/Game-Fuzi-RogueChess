using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using SysRandom = System.Random;
public class GameManager : MonoBehaviour
{
    public bool GameStart;
    public long seed;
    // Start is called before the first frame update
    void Start()
    {
        GameStart = false;
    }

    // Update is called once per frame
    void Update()
    {
        GameStart_ = true;
        if (Input.GetKeyDown(KeyCode.Space) && !GameStart)
        {
            GameStart = true;
            seed = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
        }
        if (GameStart && GameStart_)
        {
            Debug.Log("Game Started");
            GameStart_ = false;
        }

    }
}