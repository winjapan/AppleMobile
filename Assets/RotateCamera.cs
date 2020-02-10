using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateCamera : MonoBehaviour
{
    public Transform player;
    public float rotationSpeed = 40;
    public float smoothing = 5f;
  
    public bool reverse;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 targetCamPos = player.position;

        transform.position = Vector3.Lerp(
            transform.position,
            targetCamPos,
            Time.deltaTime * smoothing);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            rotateCmaeraAngle();
            reverse = true;
        }
        else
        {
            reverse = false;
            return;
        }

    
    }
    private void rotateCmaeraAngle()
    {
        Vector3 angle = new Vector3(
            Input.GetAxis("Mouse X") * rotationSpeed,
            0
        );

        transform.RotateAround(player.transform.position, Vector3.up, angle.x);
        transform.RotateAround(player.transform.position, transform.right, angle.y);
    }
}

