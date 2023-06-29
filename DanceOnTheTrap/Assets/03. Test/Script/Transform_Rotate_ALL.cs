using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transform_Rotate_ALL : MonoBehaviour
{
    private Transform Cube;
    public float rotateSpeed;
    public Transform Point;

    private void Awake()
    {
        Cube= transform;
    }

    private void Update()
    {
        TransformRotate();
    }

    private void TransformRotate()
    {
        Cube.transform.Rotate(0, rotateSpeed, 0);
    }

    private void TansformRotateAround()
    {
        Point.transform.RotateAround(Cube.position, Vector3.up, rotateSpeed);
    }

    private void TransformLookAt()
    {
        Cube.transform.LookAt(Point);
    }

}
