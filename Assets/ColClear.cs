using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ColClear : MonoBehaviour
{
    public Text ClearText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag =="Player")
        {
            ClearText.gameObject.SetActive(true);
            Invoke("Clear",2);
        }
    }

    void Clear()
    {
        SceneManager.LoadScene("PirateScene");
    }
}
