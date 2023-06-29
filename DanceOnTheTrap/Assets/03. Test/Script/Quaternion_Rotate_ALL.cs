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
        // ������ʼλ�ú�Ŀ��λ�õ����Dֵ
        startRotation = transform.rotation;
        targetRotation = target.rotation;
    }

    private void Update()
    {
        // ����ʼ��Ŀ��֮�g�M�в�ֵ
        Quaternion newRotation = Quaternion.Lerp(startRotation, targetRotation, lerpSpeed * Time.deltaTime);

        // ���µ����Dֵ���õ������
        transform.rotation = newRotation;
    }
}
