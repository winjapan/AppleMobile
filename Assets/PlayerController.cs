using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float walkSpeed = 20;

    private Collider daggerCol;
    private Rigidbody rgbody;
    private Animator animator;

    private Vector3 Player_Pos;
    private AudioSource audioSource;
    public AudioClip damage;
    public Text GameOver;
  
    // Start is called before the first frame update
    void Start()
    {
        rgbody = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        daggerCol = GameObject.Find("Dagger").GetComponent<BoxCollider>();
        audioSource = GetComponent<AudioSource>();

    }

    private void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        rgbody.velocity = new Vector3(x * walkSpeed, 0, z * walkSpeed);

        Vector3 diff = transform.position - Player_Pos;


        if (diff.magnitude > 0.07f)
        {

            transform.rotation = Quaternion.LookRotation(diff);
            animator.SetBool("Run",true);
        }
        else
        {
            animator.SetBool("Run", false);
        }

        Player_Pos = transform.position;

      
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {

            StartCoroutine(Attack());
        }
       
    }

    IEnumerator Attack()
    {
        daggerCol.enabled = true;
        animator.SetBool("Attack1", true);

        yield return new WaitForSeconds(1);

        animator.SetBool("Attack1", false);
        daggerCol.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Sch")
        {

            this.enabled = false;
            //audioSource.PlayOneShot(damage);
            GameOver.gameObject.SetActive(true);
            GameObject.Find("Main Camera").GetComponent<AudioSource>().enabled = false;
            Invoke("Reset", 1);
        }
        if (other.gameObject.tag == "Clear")
        {
            this.enabled = false;
            audioSource.PlayOneShot(damage);
            GameOver.gameObject.SetActive(true);
            GameObject.Find("Main Camera").GetComponent<AudioSource>().enabled = false;
        }
    }
    void Reset()
    {
        SceneManager.LoadScene("PirateScene");
    }
}
