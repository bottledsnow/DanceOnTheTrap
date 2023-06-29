using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class QuaternionAngle : MonoBehaviour
{
    public Transform target;
    public float angle;

    void Update()
    {
        angle = Quaternion.Angle(transform.rotation, target.rotation);
    }
}
