using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ColAxe : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip damage;
    public Image GameOver;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

 private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Axe")
        {
            this.enabled = false;
            audioSource.PlayOneShot(damage);
  
        }
    }

   
}
