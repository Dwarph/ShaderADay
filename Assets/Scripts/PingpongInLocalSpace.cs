using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingpongInLocalSpace : MonoBehaviour
{
    public Vector3 LocalSpaceOffset = Vector3.zero;
    private Vector3 startPos, endPos;


    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.LerpUnclamped(startPos, startPos - LocalSpaceOffset,  Mathf.Sin(Time.time));
    }
}
