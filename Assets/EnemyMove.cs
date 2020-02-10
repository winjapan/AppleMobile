using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour
{
    private Animator animator;
    private NavMeshAgent agent;
    public GameObject target;
    private Rigidbody rgbody;
    public CloPlayer cloPlayer;

    public bool playerclosing;

    public GameObject Search;

    private Vector3 targetPosition;
    private float changeTargetSqrDistance = 40f;
    private float rotationSmooth = 1f;
    public float runSpeed = 1200;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        rgbody = GetComponent<Rigidbody>();
      
    }

    // Update is called once per frame
    void Update()
    {
        //playerclosing = Search.GetComponent<SearchForPlayer>().playerClosing;
        //float sqrDistanceToTarget = Vector3.SqrMagnitude(transform.position - targetPosition);
        //if (sqrDistanceToTarget < changeTargetSqrDistance)
        //{
        //    targetPosition = GetRandomPositionOnLevel();
        //}
        //if (playerclosing)
        //{
        //    targetPosition = target.transform.position * runSpeed;
        //    animator.SetBool("run", true);
        //}
        //Quaternion TargetRotation = Quaternion.LookRotation(targetPosition - transform.position);
       
        //transform.rotation = Quaternion.Slerp(transform.rotation, TargetRotation, Time.deltaTime * rotationSmooth);

        ////前へ進む
        //rgbody.velocity = (transform.forward * runSpeed * Time.deltaTime + new Vector3(0, rgbody.velocity.y, 0));
    }

    public Vector3 GetRandomPositionOnLevel()
    {
        float levelSize = 30f;
        return new Vector3(Random.Range(-levelSize, levelSize), 0, Random.Range(-levelSize, levelSize));
        //ここで処理を終了（return）し、この関数を開始する直前の位置へ戻る
    }

    //private void OnCollisionEnter(Collision col)
    //{
    //    if (col.gameObject.tag == "Player")
    //    {
    //        rgbody.isKinematic = true;
    //        agent.enabled = false;
    //        this.enabled = false;
    //        animator.SetBool("run", false);
    //        cloPlayer.enabled = true;
    //    }
    //}

}
