﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffCameraRotate : MonoBehaviour
{
    public GameObject Camera1;
    public GameObject Camera2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OffToggleChanged(bool isOn)
    {


        if (isOn)
        {
            Camera1.SetActive(false);
            Camera2.SetActive(true);
          
        }
        else
        {
           
            Camera1.SetActive(true);
           Camera2.SetActive(false);
        }



    }
}
