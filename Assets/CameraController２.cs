using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController２ : MonoBehaviour
{
    public Transform target;
    public float smoothing;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - target.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = target.transform.position + offset;

        if (Input.GetMouseButton(0))
        {
            transform.RotateAround(target.transform.position,Vector3.up,-5f);
        }
    }
}
