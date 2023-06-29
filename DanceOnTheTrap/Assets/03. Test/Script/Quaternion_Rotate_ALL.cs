using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quaternion_Rotate_ALL : MonoBehaviour
{
    public Transform target;
    public float lerpSpeed = 0.5f;

    private Quaternion startRotation;
    private Quaternion targetRotation;

    private void Start()
    {
        // 儲存起始位置和目標位置的旋轉值
        startRotation = transform.rotation;
        targetRotation = target.rotation;
    }

    private void Update()
    {
        // 在起始和目標之間進行插值
        Quaternion newRotation = Quaternion.Lerp(startRotation, targetRotation, lerpSpeed * Time.deltaTime);

        // 將新的旋轉值應用到物件上
        transform.rotation = newRotation;
    }
}
