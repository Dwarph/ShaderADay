using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingpongRotation : MonoBehaviour
{
    public Vector3 RotationOffset = Vector3.zero;
    private Quaternion startRot;
    public float speed = 1;


    // Start is called before the first frame update
    void Start()
    {
        startRot = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.SlerpUnclamped(startRot, startRot * Quaternion.Euler(RotationOffset), Mathf.Sin(Time.time * speed));
    }
}
