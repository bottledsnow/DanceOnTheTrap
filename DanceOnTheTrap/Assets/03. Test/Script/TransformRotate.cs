using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformRotate : MonoBehaviour
{
    private Transform Cube;
    public Vector3 rotate;

    private void Awake()
    {
        Cube = this.transform;
    }

    private void Update()
    {
        Cube.Rotate(rotate);
    }
}
