using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadEndEnemy : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip damage;
    private Animator animator;
    public GameObject Search;
    public GameObject Count;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Dagger")
        {
            Count.GetComponent<CountDirector>().KillPirate();
            animator.SetTrigger("Death");
            Search.SetActive(false);
            audioSource.PlayOneShot(damage);
            Destroy(this.gameObject);
        }
    }
}
