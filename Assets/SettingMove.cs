using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingMove : MonoBehaviour
{
    public Image StartIm;
    public Image SettingIm;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void OnButttonClicked()
    {
        StartIm.gameObject.SetActive(false);
        SettingIm.gameObject.SetActive(true);
    }
}
