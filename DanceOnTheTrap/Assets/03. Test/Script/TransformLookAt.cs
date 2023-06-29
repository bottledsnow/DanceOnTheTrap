using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformLookAt : MonoBehaviour
{
    public Transform Target;
    public Vector3 WorldUp;

    private void Update()
    {
        transform.LookAt(Target, WorldUp);
    }
}
