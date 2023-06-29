using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToWard : MonoBehaviour
{
    public Quaternion from;
    public Quaternion to;
    public float MaxDegreDelta;

    void Update()
    {
        transform.rotation = Quaternion.RotateTowards(from, to, MaxDegreDelta);
    }
}
