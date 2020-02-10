using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CloPlayer : MonoBehaviour
{
    public GameObject target;
   
    private Rigidbody rgbody;
    private Animator animator;
    public Collider axeCol;

    public NavMeshAgent agent;
    public GameObject Search;

    public float attackTime;
    bool sound;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        rgbody = GetComponent<Rigidbody>();
        attackTime = 3;
    }

    // Update is called once per frame
    void Update()
    {
        attackTime -= Time.deltaTime;
        if (attackTime < 2)
        {
            animator.SetBool("attack", true);
            axeCol.enabled = true;
        }

        if (attackTime <1)
        {
            animator.SetBool("attack", false);
            axeCol.enabled = false;
        }

        if (attackTime <0)
        {
            attackTime = 0;
        }
    }



   
}
