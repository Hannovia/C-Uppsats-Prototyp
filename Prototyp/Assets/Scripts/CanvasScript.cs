﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasScript : MonoBehaviour
{

    public GameObject menu;
    private bool isShowing;

    // Start is called before the first frame update
    void Start()
    {
        menu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            Debug.Log("hejhej");
            isShowing = !isShowing;
            menu.SetActive(isShowing);
        }
    }
}
