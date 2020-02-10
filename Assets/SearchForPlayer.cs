using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SearchForPlayer : MonoBehaviour
{
    public EnemyMove enemyMove;
    public NavMeshAgent agent;
    public Animator animator;
    public bool playerClosing;
    private BoxCollider box;
    public Light Halo;

    // Start is called before the first frame update
    void Start()
    {
        box = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    //public void OnTriggerStay(Collider other)
    //{
    //    if (other.gameObject.tag == "Player")
    //    {
    //        agent.enabled = true;
    //        enemyMove.enabled = true;
    //        this.enabled = false;
    //        animator.SetBool("run", true);

    //        playerClosing = true;
    //        this.gameObject.SetActive(false);
    //    }
    //}

    //public void OnTriggerExit(Collider col)
    //{
    //    if (col.gameObject.tag == "Player")
    //    {
    //        playerClosing = false;
    //        agent.enabled = false;
    //        enemyMove.enabled = false;
    //        this.enabled = false;
    //        animator.SetBool("run", true);

    //        playerClosing = true;
    //    }
    //}
}