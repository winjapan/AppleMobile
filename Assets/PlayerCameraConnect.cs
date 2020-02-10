using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraConnect : MonoBehaviour
{
    public Transform target;
    public float smoothing = 5f;
    private Vector3 ofset;
   
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetCamPos = target.position + ofset;
        transform.position = Vector3.Lerp(
            transform.position,
            targetCamPos,
            Time.deltaTime * smoothing);
    }
}
