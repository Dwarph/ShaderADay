using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public enum Direction { UP, LEFT, RIGHT, DOWN }
    public float rotationSpeed = 20;
    public Direction direction = Direction.UP;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        switch (direction)
        {
            case Direction.UP:
                transform.Rotate(Vector3.up * (rotationSpeed * Time.deltaTime));
                break;
            case Direction.LEFT:
                transform.Rotate(Vector3.left * (rotationSpeed * Time.deltaTime));
                break;
            case Direction.RIGHT:
                transform.Rotate(Vector3.right * (rotationSpeed * Time.deltaTime));
                break;
            case Direction.DOWN:
                transform.Rotate(Vector3.down * (rotationSpeed * Time.deltaTime));
                break;
        }
    }
}
