using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float walkSpeed = 20;
    private Rigidbody rgbody;
    private Animator animator;

    private Vector3 Player_Pos;
    // Start is called before the first frame update
    void Start()
    {
        rgbody = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
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
        
    }
}
