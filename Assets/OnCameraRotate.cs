using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnCameraRotate : MonoBehaviour
{
    public Image join;
    public Button attack;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnToggleChanged(bool isOn)
    {


        if (isOn)
        {
           

            GameObject.Find("Player").GetComponent<PlayerControllerforiOS>().enabled = false;
            GameObject.Find("Main Camera").GetComponent<CameraController２>().enabled = true;
            join.gameObject.SetActive(false);
            attack.gameObject.SetActive(false);
        }
        else
        {
            GameObject.Find("Main Camera").GetComponent<CameraController２>().enabled = false;
          
            GameObject.Find("Player").GetComponent<PlayerControllerforiOS>().enabled = true;
            join.gameObject.SetActive(true);
            attack.gameObject.SetActive(true);
        }



    }

}
