using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageSerect : MonoBehaviour
{
    public GameObject[] StageAssets;
    // Start is called before the first frame update
    void Start()
    {
        int assets = Random.Range(0, StageAssets.Length);
        StageAssets[assets].gameObject.SetActive(true);

    }
}
