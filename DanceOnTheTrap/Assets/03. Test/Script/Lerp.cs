using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerp : MonoBehaviour
{
    public Transform from;
    public Transform to;
    public float speed = 0.01f;
    public float timeCount = 0.0f;

    void Update()
    {
        transform.rotation = Quaternion.Lerp(from.rotation, to.rotation, timeCount * speed);
        timeCount = timeCount + Time.deltaTime;
    }
}
