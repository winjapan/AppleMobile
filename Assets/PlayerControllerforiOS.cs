using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerControllerforiOS : MonoBehaviour
{
    public float walkSpeed = 50;

    private Collider daggerCol;
    private Rigidbody rgbody;
    private Animator animator;

    private Vector3 Player_Pos;
    private AudioSource audioSource;
    public AudioClip damage;
    public Text GameOver;
    public Image join;
    public Button Attacks;

    public Joystick joystick = null;
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

        Vector3 moveVector = (Vector3.right * joystick.Horizontal + Vector3.forward * joystick.Vertical);
        if (moveVector != Vector3.zero)
        {
            animator.SetBool("Run", true);
            transform.rotation = Quaternion.LookRotation(moveVector);
            transform.Translate(moveVector * walkSpeed * Time.deltaTime, Space.World);
        }
        else
        {
            animator.SetBool("Run", false);
        }

        //rgbody.velocity = new Vector3(joystick.Horizontal * walkSpeed, rgbody.velocity.y, joystick.Vertical * walkSpeed);

        //Vector3 diff = transform.position - Player_Pos;


        //if (diff.magnitude > 0.01f)
        //{

        //    transform.rotation = Quaternion.LookRotation(diff *-1);

        //}
        //else
        //{
           
        //}

        //Player_Pos = transform.position;


    }

    public void OnButtonCliclked()
    {
        StartCoroutine(Attack());
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
            audioSource.PlayOneShot(damage);
            GameOver.gameObject.SetActive(true);
            join.gameObject.SetActive(false);
            Attacks.gameObject.SetActive(false);
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
        SceneManager.LoadScene("PirateScene for iOS");
    }
}
