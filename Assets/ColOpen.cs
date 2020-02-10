using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColOpen : MonoBehaviour
{
    private Animator animator;
    private AudioSource audioSource;
    public GameObject Count;
    public AudioClip chest;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision get)
    {
        if (get.gameObject.tag == "Player")
        {
            Count.GetComponent<CountDirector>().ColBox();
            animator.enabled = true;
            audioSource.PlayOneShot(chest);
            this.enabled = false;
            Destroy(this.gameObject);
        }
    }
}
